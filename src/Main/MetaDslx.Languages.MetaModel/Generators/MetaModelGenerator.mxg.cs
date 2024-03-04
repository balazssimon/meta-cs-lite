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
            #line (150,6)-(150,34) 13 "MetaModelGenerator.mxg"
            foreach (var c in Constants)
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
            #line (165,6)-(165,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                #line (166,10)-(166,127) 17 "MetaModelGenerator.mxg"
                var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
                #line hidden
                
                var __first7 = true;
                #line (167,10)-(167,46) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties)
                #line hidden
                
                {
                    if (__first7)
                    {
                        __first7 = false;
                    }
                    __cb.Push("    ");
                    #line (168,13)-(168,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (168,20)-(168,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (168,21)-(168,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (168,27)-(168,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (168,28)-(168,36) 33 "MetaModelGenerator.mxg"
                    __cb.Write("readonly");
                    #line hidden
                    #line (168,36)-(168,37) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (168,37)-(168,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (168,52)-(168,53) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (168,53)-(168,54) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (168,55)-(168,63) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (168,64)-(168,65) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (168,66)-(168,75) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (168,76)-(168,77) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first7) __cb.AppendLine();
                var __first8 = true;
                #line (170,10)-(170,56) 17 "MetaModelGenerator.mxg"
                foreach (var op in metaCls.DeclaredOperations)
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("    ");
                    #line (171,13)-(171,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (171,20)-(171,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (171,21)-(171,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (171,27)-(171,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (171,28)-(171,36) 33 "MetaModelGenerator.mxg"
                    __cb.Write("readonly");
                    #line hidden
                    #line (171,36)-(171,37) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (171,37)-(171,53) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation");
                    #line hidden
                    #line (171,53)-(171,54) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (171,54)-(171,55) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (171,56)-(171,64) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (171,65)-(171,66) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (171,67)-(171,80) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.UniqueName);
                    #line hidden
                    #line (171,81)-(171,82) 33 "MetaModelGenerator.mxg"
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
            #line (175,5)-(175,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (175,11)-(175,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (175,13)-(175,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (175,28)-(175,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (176,5)-(176,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first9 = true;
            #line (177,10)-(177,38) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                #line (178,14)-(178,131) 17 "MetaModelGenerator.mxg"
                var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
                #line hidden
                
                var __first10 = true;
                #line (179,14)-(179,62) 17 "MetaModelGenerator.mxg"
                foreach (var prop in metaCls.DeclaredProperties)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (180,17)-(180,18) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (180,19)-(180,27) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (180,28)-(180,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (180,30)-(180,39) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (180,40)-(180,41) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,41)-(180,42) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (180,42)-(180,43) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,43)-(180,46) 33 "MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (180,46)-(180,47) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,47)-(180,70) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty(typeof(");
                    #line hidden
                    #line (180,71)-(180,79) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (180,80)-(180,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("),");
                    #line hidden
                    #line (180,82)-(180,83) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,83)-(180,84) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (180,85)-(180,94) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (180,95)-(180,97) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\",");
                    #line hidden
                    #line (180,97)-(180,98) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,98)-(180,105) 33 "MetaModelGenerator.mxg"
                    __cb.Write("typeof(");
                    #line hidden
                    #line (180,106)-(180,125) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Type));
                    #line hidden
                    #line (180,126)-(180,128) 33 "MetaModelGenerator.mxg"
                    __cb.Write("),");
                    #line hidden
                    #line (180,128)-(180,129) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,130)-(180,174) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToDefaultValue(prop.Type, prop.DefaultValue));
                    #line hidden
                    #line (180,175)-(180,176) 33 "MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (180,176)-(180,177) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,178)-(180,198) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Flags));
                    #line hidden
                    #line (180,199)-(180,200) 33 "MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (180,200)-(180,201) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    var __first11 = true;
                    #line (180,202)-(180,233) 21 "MetaModelGenerator.mxg"
                    if(prop.SymbolProperty is null)
                    #line hidden
                    
                    {
                        if (__first11)
                        {
                            __first11 = false;
                        }
                        #line (180,234)-(180,238) 37 "MetaModelGenerator.mxg"
                        __cb.Write("null");
                        #line hidden
                    }
                    #line (180,239)-(180,243) 21 "MetaModelGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first11)
                        {
                            __first11 = false;
                        }
                        #line (180,244)-(180,245) 37 "MetaModelGenerator.mxg"
                        __cb.Write("\"");
                        #line hidden
                        #line (180,246)-(180,265) 36 "MetaModelGenerator.mxg"
                        __cb.Write(prop.SymbolProperty);
                        #line hidden
                        #line (180,266)-(180,267) 37 "MetaModelGenerator.mxg"
                        __cb.Write("\"");
                        #line hidden
                    }
                    #line (180,275)-(180,277) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                var __first12 = true;
                #line (182,14)-(182,60) 17 "MetaModelGenerator.mxg"
                foreach (var op in metaCls.DeclaredOperations)
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("        ");
                    #line (183,17)-(183,18) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (183,19)-(183,27) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (183,28)-(183,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (183,30)-(183,43) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.UniqueName);
                    #line hidden
                    #line (183,44)-(183,45) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (183,45)-(183,46) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (183,46)-(183,47) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (183,47)-(183,50) 33 "MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (183,50)-(183,51) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (183,51)-(183,75) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation(typeof(");
                    #line hidden
                    #line (183,76)-(183,84) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (183,85)-(183,87) 33 "MetaModelGenerator.mxg"
                    __cb.Write("),");
                    #line hidden
                    #line (183,87)-(183,88) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (183,88)-(183,89) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (183,90)-(183,97) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (183,98)-(183,100) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\",");
                    #line hidden
                    #line (183,100)-(183,101) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (183,101)-(183,102) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (183,103)-(183,115) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Signature);
                    #line hidden
                    #line (183,116)-(183,119) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first12) __cb.AppendLine();
            }
            if (!__first9) __cb.AppendLine();
            __cb.Push("        ");
            #line (186,9)-(186,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("_instance");
            #line hidden
            #line (186,18)-(186,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (186,19)-(186,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (186,20)-(186,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (186,21)-(186,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (186,24)-(186,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (186,26)-(186,40) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (186,41)-(186,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (187,5)-(187,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (189,5)-(189,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (189,12)-(189,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,13)-(189,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (189,21)-(189,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,22)-(189,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (189,29)-(189,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,30)-(189,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("_model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
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
            #line (191,22)-(191,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (191,85)-(191,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,86)-(191,97) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumTypes;");
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
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo>");
            #line hidden
            #line (192,90)-(192,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (192,91)-(192,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfos;");
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
            #line (193,22)-(193,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (193,90)-(193,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,91)-(193,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (193,107)-(193,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,108)-(193,125) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByType;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (194,5)-(194,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (194,12)-(194,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (194,13)-(194,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (194,21)-(194,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (194,22)-(194,86) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (194,86)-(194,87) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (194,87)-(194,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (194,103)-(194,104) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (194,104)-(194,121) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
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
            #line (196,22)-(196,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (196,85)-(196,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,86)-(196,98) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classTypes;");
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
            #line (197,22)-(197,91) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (197,91)-(197,92) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (197,92)-(197,104) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfos;");
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
            #line (198,22)-(198,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (198,90)-(198,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,91)-(198,108) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (198,108)-(198,109) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,109)-(198,127) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByType;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (199,5)-(199,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (199,12)-(199,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,13)-(199,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (199,21)-(199,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,22)-(199,86) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (199,86)-(199,87) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,87)-(199,104) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (199,104)-(199,105) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,105)-(199,123) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first13 = true;
            #line (201,6)-(201,34) 13 "MetaModelGenerator.mxg"
            foreach (var c in Constants)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                __cb.Push("    ");
                #line (202,9)-(202,16) 29 "MetaModelGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (202,16)-(202,17) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,17)-(202,25) 29 "MetaModelGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (202,25)-(202,26) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,27)-(202,43) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (202,44)-(202,45) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,45)-(202,46) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (202,47)-(202,67) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name.ToCamelCase());
                #line hidden
                #line (202,68)-(202,69) 29 "MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first13) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (205,5)-(205,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (205,12)-(205,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,14)-(205,28) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (205,29)-(205,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (206,5)-(206,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (207,9)-(207,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumTypes");
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
            #line (207,22)-(207,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__MetaType>(");
            #line hidden
            var __first14 = true;
            #line (207,59)-(207,86) 13 "MetaModelGenerator.mxg"
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
                    #line (207,96)-(207,100) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (207,101)-(207,108) 29 "MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (207,109)-(207,117) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (207,118)-(207,119) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (207,132)-(207,134) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (208,9)-(208,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfos");
            #line hidden
            #line (208,19)-(208,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,20)-(208,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (208,21)-(208,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,22)-(208,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelEnumInfo>(");
            #line hidden
            var __first15 = true;
            #line (208,64)-(208,91) 13 "MetaModelGenerator.mxg"
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
                    #line (208,101)-(208,105) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (208,107)-(208,115) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (208,116)-(208,120) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
            }
            #line (208,133)-(208,135) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (209,9)-(209,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (209,12)-(209,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,13)-(209,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("enumInfosByType");
            #line hidden
            #line (209,28)-(209,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,29)-(209,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (209,30)-(209,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,31)-(209,78) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__MetaType,");
            #line hidden
            #line (209,78)-(209,79) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,79)-(209,98) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first16 = true;
            #line (210,10)-(210,36) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first16)
                {
                    __first16 = false;
                }
                __cb.Push("        ");
                #line (211,13)-(211,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("enumInfosByType.Add(typeof(");
                #line hidden
                #line (211,41)-(211,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (211,50)-(211,52) 29 "MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (211,52)-(211,53) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (211,54)-(211,62) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (211,63)-(211,69) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first16) __cb.AppendLine();
            __cb.Push("        ");
            #line (213,9)-(213,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByType");
            #line hidden
            #line (213,25)-(213,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,26)-(213,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (213,27)-(213,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,28)-(213,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("enumInfosByType.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (214,9)-(214,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (214,12)-(214,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,13)-(214,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("enumInfosByName");
            #line hidden
            #line (214,28)-(214,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,29)-(214,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (214,30)-(214,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,31)-(214,74) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (214,74)-(214,75) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,75)-(214,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first17 = true;
            #line (215,10)-(215,36) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first17)
                {
                    __first17 = false;
                }
                __cb.Push("        ");
                #line (216,13)-(216,34) 29 "MetaModelGenerator.mxg"
                __cb.Write("enumInfosByName.Add(\"");
                #line hidden
                #line (216,35)-(216,43) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (216,44)-(216,46) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (216,46)-(216,47) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (216,48)-(216,56) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (216,57)-(216,63) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first17) __cb.AppendLine();
            __cb.Push("        ");
            #line (218,9)-(218,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByName");
            #line hidden
            #line (218,25)-(218,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (218,26)-(218,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (218,27)-(218,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (218,28)-(218,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("enumInfosByName.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (220,9)-(220,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classTypes");
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
            #line (220,23)-(220,59) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__MetaType>(");
            #line hidden
            var __first18 = true;
            #line (220,60)-(220,89) 13 "MetaModelGenerator.mxg"
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
                    #line (220,99)-(220,103) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (220,104)-(220,111) 29 "MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (220,112)-(220,120) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (220,121)-(220,122) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (220,135)-(220,137) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (221,9)-(221,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfos");
            #line hidden
            #line (221,20)-(221,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,21)-(221,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (221,22)-(221,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,23)-(221,65) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first19 = true;
            #line (221,66)-(221,95) 13 "MetaModelGenerator.mxg"
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
                    #line (221,105)-(221,109) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (221,111)-(221,119) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (221,120)-(221,124) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
            }
            #line (221,137)-(221,139) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (222,9)-(222,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (222,12)-(222,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,13)-(222,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("classInfosByType");
            #line hidden
            #line (222,29)-(222,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,30)-(222,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (222,31)-(222,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,32)-(222,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__MetaType,");
            #line hidden
            #line (222,79)-(222,80) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,80)-(222,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first20 = true;
            #line (223,10)-(223,38) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first20)
                {
                    __first20 = false;
                }
                __cb.Push("        ");
                #line (224,13)-(224,41) 29 "MetaModelGenerator.mxg"
                __cb.Write("classInfosByType.Add(typeof(");
                #line hidden
                #line (224,42)-(224,50) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (224,51)-(224,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (224,53)-(224,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (224,55)-(224,63) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (224,64)-(224,70) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first20) __cb.AppendLine();
            __cb.Push("        ");
            #line (226,9)-(226,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByType");
            #line hidden
            #line (226,26)-(226,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (226,27)-(226,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (226,28)-(226,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (226,29)-(226,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("classInfosByType.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (227,9)-(227,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (227,12)-(227,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,13)-(227,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("classInfosByName");
            #line hidden
            #line (227,29)-(227,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,30)-(227,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (227,31)-(227,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,32)-(227,75) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (227,75)-(227,76) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,76)-(227,96) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first21 = true;
            #line (228,10)-(228,38) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                __cb.Push("        ");
                #line (229,13)-(229,35) 29 "MetaModelGenerator.mxg"
                __cb.Write("classInfosByName.Add(\"");
                #line hidden
                #line (229,36)-(229,44) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (229,45)-(229,47) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (229,47)-(229,48) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (229,49)-(229,57) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (229,58)-(229,64) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first21) __cb.AppendLine();
            __cb.Push("        ");
            #line (231,9)-(231,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByName");
            #line hidden
            #line (231,26)-(231,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,27)-(231,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (231,28)-(231,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,29)-(231,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("classInfosByName.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (232,9)-(232,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("_model");
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
            #line (232,22)-(232,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (233,9)-(233,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (233,12)-(233,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,13)-(233,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("cf");
            #line hidden
            #line (233,15)-(233,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,16)-(233,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (233,17)-(233,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,18)-(233,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (233,21)-(233,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,23)-(233,37) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (233,38)-(233,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(_model,");
            #line hidden
            #line (233,58)-(233,59) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,59)-(233,65) 25 "MetaModelGenerator.mxg"
            __cb.Write("this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first22 = true;
            #line (234,10)-(234,38) 13 "MetaModelGenerator.mxg"
            foreach (var c in Constants)
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("        ");
                #line (235,13)-(235,14) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (235,15)-(235,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name.ToCamelCase());
                #line hidden
                #line (235,36)-(235,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (235,37)-(235,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (235,38)-(235,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (235,39)-(235,42) 29 "MetaModelGenerator.mxg"
                __cb.Write("cf.");
                #line hidden
                #line (235,43)-(235,54) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Type.Type.Name);
                #line hidden
                #line (235,55)-(235,58) 29 "MetaModelGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first22) __cb.AppendLine();
            __cb.Push("        ");
            #line (237,9)-(237,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (237,12)-(237,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (237,13)-(237,14) 25 "MetaModelGenerator.mxg"
            __cb.Write("f");
            #line hidden
            #line (237,14)-(237,15) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (237,15)-(237,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (237,16)-(237,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first23 = true;
            #line (237,18)-(237,38) 13 "MetaModelGenerator.mxg"
            if (IsMetaMetaModel)
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                #line (237,39)-(237,42) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (237,42)-(237,43) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (237,43)-(237,69) 29 "MetaModelGenerator.mxg"
                __cb.Write("__MetaModelFactory(_model,");
                #line hidden
                #line (237,69)-(237,70) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (237,70)-(237,75) 29 "MetaModelGenerator.mxg"
                __cb.Write("this)");
                #line hidden
            }
            #line (237,76)-(237,80) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                #line (237,81)-(237,84) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (237,84)-(237,85) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (237,85)-(237,111) 29 "MetaModelGenerator.mxg"
                __cb.Write("__MetaModelFactory(_model)");
                #line hidden
            }
            #line (237,119)-(237,120) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first24 = true;
            #line (238,10)-(238,38) 13 "MetaModelGenerator.mxg"
            foreach (var obj in Objects)
            #line hidden
            
            {
                if (__first24)
                {
                    __first24 = false;
                }
                __cb.Push("        ");
                #line (239,13)-(239,16) 29 "MetaModelGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (239,16)-(239,17) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (239,18)-(239,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetObjectName(obj));
                #line hidden
                #line (239,31)-(239,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (239,32)-(239,33) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (239,33)-(239,34) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (239,34)-(239,36) 29 "MetaModelGenerator.mxg"
                __cb.Write("f.");
                #line hidden
                #line (239,37)-(239,60) 28 "MetaModelGenerator.mxg"
                __cb.Write(obj.MInfo.MetaType.Name);
                #line hidden
                #line (239,61)-(239,64) 29 "MetaModelGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first24) __cb.AppendLine();
            __cb.Push("        ");
            #line (241,9)-(241,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("__CustomImpl.");
            #line hidden
            #line (241,23)-(241,37) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (241,38)-(241,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first25 = true;
            #line (242,10)-(242,38) 13 "MetaModelGenerator.mxg"
            foreach (var obj in Objects)
            #line hidden
            
            {
                if (__first25)
                {
                    __first25 = false;
                }
                var __first26 = true;
                #line (243,14)-(243,50) 17 "MetaModelGenerator.mxg"
                foreach (var child in obj.MChildren)
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    __cb.Push("        ");
                    #line (244,18)-(244,30) 32 "MetaModelGenerator.mxg"
                    __cb.Write(GetObjectName(obj));
                    #line hidden
                    #line (244,31)-(244,46) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".MChildren.Add(");
                    #line hidden
                    #line (244,47)-(244,61) 32 "MetaModelGenerator.mxg"
                    __cb.Write(GetObjectName(child));
                    #line hidden
                    #line (244,62)-(244,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first26) __cb.AppendLine();
                var __first27 = true;
                #line (246,14)-(246,62) 17 "MetaModelGenerator.mxg"
                foreach (var prop in obj.MInfo.PublicProperties)
                #line hidden
                
                {
                    if (__first27)
                    {
                        __first27 = false;
                    }
                    #line (247,18)-(247,47) 21 "MetaModelGenerator.mxg"
                    var slot = obj.MGetSlot(prop);
                    #line hidden
                    
                    var __first28 = true;
                    #line (248,18)-(248,54) 21 "MetaModelGenerator.mxg"
                    if (slot != null && !slot.IsDefault)
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        var __first29 = true;
                        #line (249,22)-(249,44) 25 "MetaModelGenerator.mxg"
                        if (prop.IsCollection)
                        #line hidden
                        
                        {
                            if (__first29)
                            {
                                __first29 = false;
                            }
                            var __first30 = true;
                            #line (250,26)-(250,60) 29 "MetaModelGenerator.mxg"
                            foreach (var value in slot.Values)
                            #line hidden
                            
                            {
                                if (__first30)
                                {
                                    __first30 = false;
                                }
                                __cb.Push("        ");
                                #line (251,30)-(251,42) 44 "MetaModelGenerator.mxg"
                                __cb.Write(GetObjectName(obj));
                                #line hidden
                                #line (251,43)-(251,44) 45 "MetaModelGenerator.mxg"
                                __cb.Write(".");
                                #line hidden
                                #line (251,45)-(251,54) 44 "MetaModelGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (251,55)-(251,60) 45 "MetaModelGenerator.mxg"
                                __cb.Write(".Add(");
                                #line hidden
                                #line (251,61)-(251,92) 44 "MetaModelGenerator.mxg"
                                __cb.Write(ToCSharpValue(prop.Type, value));
                                #line hidden
                                #line (251,93)-(251,95) 45 "MetaModelGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            if (!__first30) __cb.AppendLine();
                        }
                        #line (253,22)-(253,48) 25 "MetaModelGenerator.mxg"
                        else if (!prop.IsReadOnly)
                        #line hidden
                        
                        {
                            if (__first29)
                            {
                                __first29 = false;
                            }
                            __cb.Push("        ");
                            #line (254,26)-(254,38) 40 "MetaModelGenerator.mxg"
                            __cb.Write(GetObjectName(obj));
                            #line hidden
                            #line (254,39)-(254,40) 41 "MetaModelGenerator.mxg"
                            __cb.Write(".");
                            #line hidden
                            #line (254,41)-(254,50) 40 "MetaModelGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (254,51)-(254,52) 41 "MetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (254,52)-(254,53) 41 "MetaModelGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (254,53)-(254,54) 41 "MetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (254,55)-(254,103) 40 "MetaModelGenerator.mxg"
                            __cb.Write(ToCSharpValue(prop.Type, slot.AsSingle()?.Value));
                            #line hidden
                            #line (254,104)-(254,105) 41 "MetaModelGenerator.mxg"
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
            #line (259,9)-(259,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("_model.IsSealed");
            #line hidden
            #line (259,24)-(259,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,25)-(259,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (259,26)-(259,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,27)-(259,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (260,5)-(260,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
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
            #line (262,28)-(262,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("MName");
            #line hidden
            #line (262,33)-(262,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,34)-(262,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (262,36)-(262,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,37)-(262,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("nameof(");
            #line hidden
            #line (262,45)-(262,59) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (262,60)-(262,62) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
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
            #line (263,21)-(263,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (263,27)-(263,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,28)-(263,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("MNamespace");
            #line hidden
            #line (263,38)-(263,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,39)-(263,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (263,41)-(263,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,42)-(263,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (263,44)-(263,53) 24 "MetaModelGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (263,54)-(263,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("\";");
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
            #line (264,21)-(264,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelVersion");
            #line hidden
            #line (264,35)-(264,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,36)-(264,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("MVersion");
            #line hidden
            #line (264,44)-(264,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,45)-(264,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (264,47)-(264,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,48)-(264,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("default;");
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
            #line (265,28)-(265,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("MUri");
            #line hidden
            #line (265,32)-(265,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,33)-(265,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (265,35)-(265,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,36)-(265,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (265,38)-(265,73) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Uri ?? MetaModel.FullName);
            #line hidden
            #line (265,74)-(265,76) 25 "MetaModelGenerator.mxg"
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
            #line (266,21)-(266,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (266,27)-(266,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,28)-(266,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("MPrefix");
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
            #line (266,39)-(266,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (266,41)-(266,127) 24 "MetaModelGenerator.mxg"
            __cb.Write(string.Concat(MetaModel.Name.Where(c => char.IsUpper(c)).Select(c => char.ToLower(c))));
            #line hidden
            #line (266,128)-(266,130) 25 "MetaModelGenerator.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (267,5)-(267,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (267,11)-(267,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,12)-(267,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (267,20)-(267,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,21)-(267,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (267,28)-(267,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,29)-(267,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("MModel");
            #line hidden
            #line (267,35)-(267,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,36)-(267,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (267,38)-(267,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,39)-(267,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("_model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
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
            #line (269,21)-(269,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (269,89)-(269,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,90)-(269,106) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (269,106)-(269,107) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,107)-(269,123) 25 "MetaModelGenerator.mxg"
            __cb.Write("MEnumInfosByType");
            #line hidden
            #line (269,123)-(269,124) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,124)-(269,126) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (269,126)-(269,127) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,127)-(269,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByType;");
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
            #line (270,21)-(270,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (270,85)-(270,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,86)-(270,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (270,102)-(270,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,103)-(270,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("MEnumInfosByName");
            #line hidden
            #line (270,119)-(270,120) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,120)-(270,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (270,122)-(270,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,123)-(270,140) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByName;");
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
            #line (271,21)-(271,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (271,89)-(271,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,90)-(271,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (271,107)-(271,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,108)-(271,125) 25 "MetaModelGenerator.mxg"
            __cb.Write("MClassInfosByType");
            #line hidden
            #line (271,125)-(271,126) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,126)-(271,128) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (271,128)-(271,129) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,129)-(271,147) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByType;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (272,5)-(272,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (272,11)-(272,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,12)-(272,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (272,20)-(272,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,21)-(272,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (272,85)-(272,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,86)-(272,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (272,103)-(272,104) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,104)-(272,121) 25 "MetaModelGenerator.mxg"
            __cb.Write("MClassInfosByName");
            #line hidden
            #line (272,121)-(272,122) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,122)-(272,124) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (272,124)-(272,125) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,125)-(272,143) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
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
            #line (274,21)-(274,84) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (274,84)-(274,85) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,85)-(274,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("MEnumTypes");
            #line hidden
            #line (274,95)-(274,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,96)-(274,98) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (274,98)-(274,99) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,99)-(274,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumTypes;");
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
            #line (275,21)-(275,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo>");
            #line hidden
            #line (275,89)-(275,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,90)-(275,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("MEnumInfos");
            #line hidden
            #line (275,100)-(275,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,101)-(275,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (275,103)-(275,104) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,104)-(275,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfos;");
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
            #line (276,21)-(276,84) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (276,84)-(276,85) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,85)-(276,96) 25 "MetaModelGenerator.mxg"
            __cb.Write("MClassTypes");
            #line hidden
            #line (276,96)-(276,97) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,97)-(276,99) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (276,99)-(276,100) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,100)-(276,112) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classTypes;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (277,5)-(277,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (277,11)-(277,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,12)-(277,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (277,20)-(277,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,21)-(277,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (277,90)-(277,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,91)-(277,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("MClassInfos");
            #line hidden
            #line (277,102)-(277,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,103)-(277,105) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (277,105)-(277,106) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,106)-(277,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first31 = true;
            #line (279,6)-(279,34) 13 "MetaModelGenerator.mxg"
            foreach (var c in Constants)
            #line hidden
            
            {
                if (__first31)
                {
                    __first31 = false;
                }
                __cb.Push("    ");
                #line (280,10)-(280,26) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (280,27)-(280,28) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (280,28)-(280,29) 29 "MetaModelGenerator.mxg"
                __cb.Write("I");
                #line hidden
                #line (280,30)-(280,44) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (280,45)-(280,46) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (280,47)-(280,53) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (280,54)-(280,55) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (280,55)-(280,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (280,57)-(280,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (280,58)-(280,59) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (280,60)-(280,80) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name.ToCamelCase());
                #line hidden
                #line (280,81)-(280,82) 29 "MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first31) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first32 = true;
            #line (283,6)-(283,34) 13 "MetaModelGenerator.mxg"
            foreach (var c in Constants)
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                __cb.Push("    ");
                #line (284,10)-(284,36) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(c));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (285,9)-(285,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (285,15)-(285,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (285,16)-(285,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (285,22)-(285,23) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (285,24)-(285,40) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (285,41)-(285,42) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (285,43)-(285,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (285,50)-(285,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (285,51)-(285,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (285,53)-(285,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (285,54)-(285,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("((I");
                #line hidden
                #line (285,58)-(285,72) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (285,73)-(285,85) 29 "MetaModelGenerator.mxg"
                __cb.Write(")MInstance).");
                #line hidden
                #line (285,86)-(285,92) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (285,93)-(285,94) 29 "MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first32) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first33 = true;
            #line (288,6)-(288,32) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("    ");
                #line (289,9)-(289,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (289,15)-(289,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (289,16)-(289,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (289,22)-(289,23) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (289,23)-(289,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelEnumInfo");
                #line hidden
                #line (289,38)-(289,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (289,40)-(289,48) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (289,49)-(289,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
                #line (289,53)-(289,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (289,54)-(289,56) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (289,56)-(289,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (289,57)-(289,66) 29 "MetaModelGenerator.mxg"
                __cb.Write("__Impl.__");
                #line hidden
                #line (289,67)-(289,75) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (289,76)-(289,91) 29 "MetaModelGenerator.mxg"
                __cb.Write("_Info.Instance;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first33) __cb.AppendLine();
            var __first34 = true;
            #line (291,6)-(291,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.Push("    ");
                #line (292,9)-(292,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (292,15)-(292,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (292,16)-(292,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (292,22)-(292,23) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (292,23)-(292,39) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelClassInfo");
                #line hidden
                #line (292,39)-(292,40) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (292,41)-(292,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (292,50)-(292,54) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
                #line (292,54)-(292,55) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (292,55)-(292,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (292,57)-(292,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (292,58)-(292,65) 29 "MetaModelGenerator.mxg"
                __cb.Write("__Impl.");
                #line hidden
                #line (292,66)-(292,74) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (292,75)-(292,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("_Impl.__Info.Instance;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (293,10)-(293,127) 17 "MetaModelGenerator.mxg"
                var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
                #line hidden
                
                var __first35 = true;
                #line (294,10)-(294,46) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    __cb.Push("    ");
                    #line (295,13)-(295,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (295,19)-(295,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (295,20)-(295,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (295,26)-(295,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (295,27)-(295,42) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (295,42)-(295,43) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (295,44)-(295,52) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (295,53)-(295,54) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (295,55)-(295,64) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (295,65)-(295,66) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (295,66)-(295,68) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (295,68)-(295,69) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (295,69)-(295,70) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (295,71)-(295,79) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (295,80)-(295,81) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (295,82)-(295,91) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (295,92)-(295,93) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first35) __cb.AppendLine();
                var __first36 = true;
                #line (297,10)-(297,56) 17 "MetaModelGenerator.mxg"
                foreach (var op in metaCls.DeclaredOperations)
                #line hidden
                
                {
                    if (__first36)
                    {
                        __first36 = false;
                    }
                    __cb.Push("    ");
                    #line (298,13)-(298,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (298,19)-(298,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (298,20)-(298,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (298,26)-(298,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (298,27)-(298,43) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation");
                    #line hidden
                    #line (298,43)-(298,44) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (298,45)-(298,53) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (298,54)-(298,55) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (298,56)-(298,69) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.UniqueName);
                    #line hidden
                    #line (298,70)-(298,71) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (298,71)-(298,73) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (298,73)-(298,74) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (298,74)-(298,75) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (298,76)-(298,84) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (298,85)-(298,86) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (298,87)-(298,100) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.UniqueName);
                    #line hidden
                    #line (298,101)-(298,102) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first36) __cb.AppendLine();
            }
            if (!__first34) __cb.AppendLine();
            __cb.Push("");
            #line (301,1)-(301,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (304,9)-(304,27) 22 "MetaModelGenerator.mxg"
        public string GenerateFactory()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (305,1)-(305,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (305,7)-(305,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,8)-(305,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (305,13)-(305,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,15)-(305,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (305,30)-(305,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory");
            #line hidden
            #line (305,42)-(305,43) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,43)-(305,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (305,44)-(305,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,45)-(305,59) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelFactory");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (306,1)-(306,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (307,5)-(307,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (307,11)-(307,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,13)-(307,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (307,28)-(307,48) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(__Model");
            #line hidden
            #line (307,48)-(307,49) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,49)-(307,55) 25 "MetaModelGenerator.mxg"
            __cb.Write("model)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (308,9)-(308,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (308,10)-(308,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (308,11)-(308,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(model,");
            #line hidden
            #line (308,22)-(308,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (308,24)-(308,38) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (308,39)-(308,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (309,5)-(309,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (310,5)-(310,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (312,5)-(312,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (312,13)-(312,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,15)-(312,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (312,30)-(312,50) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(__Model");
            #line hidden
            #line (312,50)-(312,51) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,51)-(312,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (312,57)-(312,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,59)-(312,73) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (312,74)-(312,75) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,75)-(312,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("metaModel)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (313,9)-(313,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (313,10)-(313,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (313,11)-(313,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(model,");
            #line hidden
            #line (313,22)-(313,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (313,23)-(313,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("metaModel)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (314,5)-(314,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (315,5)-(315,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first37 = true;
            #line (317,6)-(317,60) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes.Where(c => !c.IsAbstract))
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.Push("    ");
                #line (318,10)-(318,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(cls));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (319,9)-(319,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (319,15)-(319,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (319,17)-(319,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (319,31)-(319,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (319,33)-(319,41) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (319,42)-(319,50) 29 "MetaModelGenerator.mxg"
                __cb.Write("(string?");
                #line hidden
                #line (319,50)-(319,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (319,51)-(319,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("id");
                #line hidden
                #line (319,53)-(319,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (319,54)-(319,55) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (319,55)-(319,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (319,56)-(319,61) 29 "MetaModelGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (320,9)-(320,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (321,13)-(321,19) 29 "MetaModelGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (321,19)-(321,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (321,20)-(321,21) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (321,22)-(321,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (321,36)-(321,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (321,38)-(321,52) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (321,53)-(321,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (321,55)-(321,63) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (321,64)-(321,87) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info.Create(base.Model,");
                #line hidden
                #line (321,87)-(321,88) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (321,88)-(321,93) 29 "MetaModelGenerator.mxg"
                __cb.Write("id)!;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (322,9)-(322,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first37) __cb.AppendLine();
            __cb.Push("");
            #line (325,1)-(325,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (327,1)-(327,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (327,7)-(327,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,8)-(327,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (327,13)-(327,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,15)-(327,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (327,30)-(327,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelMultiFactory");
            #line hidden
            #line (327,47)-(327,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,48)-(327,49) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (327,49)-(327,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,50)-(327,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MultiModelFactory");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (328,1)-(328,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (329,5)-(329,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (329,11)-(329,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,13)-(329,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (329,28)-(329,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelMultiFactory()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (330,9)-(330,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (330,10)-(330,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,11)-(330,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(new");
            #line hidden
            #line (330,19)-(330,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,20)-(330,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (330,32)-(330,36) 24 "MetaModelGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (330,37)-(330,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,38)-(330,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (330,39)-(330,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,41)-(330,55) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (330,56)-(330,66) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance");
            #line hidden
            #line (330,66)-(330,67) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,67)-(330,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("})");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (331,5)-(331,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (332,5)-(332,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first38 = true;
            #line (334,6)-(334,60) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes.Where(c => !c.IsAbstract))
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("    ");
                #line (335,10)-(335,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(cls));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (336,9)-(336,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (336,15)-(336,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (336,17)-(336,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (336,31)-(336,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (336,33)-(336,41) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (336,42)-(336,50) 29 "MetaModelGenerator.mxg"
                __cb.Write("(__Model");
                #line hidden
                #line (336,50)-(336,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (336,51)-(336,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("model,");
                #line hidden
                #line (336,57)-(336,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (336,58)-(336,65) 29 "MetaModelGenerator.mxg"
                __cb.Write("string?");
                #line hidden
                #line (336,65)-(336,66) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (336,66)-(336,68) 29 "MetaModelGenerator.mxg"
                __cb.Write("id");
                #line hidden
                #line (336,68)-(336,69) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (336,69)-(336,70) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (336,70)-(336,71) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (336,71)-(336,76) 29 "MetaModelGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (337,9)-(337,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (338,13)-(338,19) 29 "MetaModelGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (338,19)-(338,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (338,20)-(338,21) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (338,22)-(338,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (338,36)-(338,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (338,38)-(338,52) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (338,53)-(338,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (338,55)-(338,63) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (338,64)-(338,82) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info.Create(model,");
                #line hidden
                #line (338,82)-(338,83) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (338,83)-(338,88) 29 "MetaModelGenerator.mxg"
                __cb.Write("id)!;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (339,9)-(339,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first38) __cb.AppendLine();
            __cb.Push("");
            #line (342,1)-(342,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (346,9)-(346,36) 22 "MetaModelGenerator.mxg"
        public string GenerateEnum(MetaEnum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (347,2)-(347,30) 24 "MetaModelGenerator.mxg"
            __cb.Write(GetDocumentationComment(enm));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (348,1)-(348,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (348,7)-(348,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (348,8)-(348,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("enum");
            #line hidden
            #line (348,12)-(348,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (348,14)-(348,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (349,1)-(349,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first39 = true;
            #line (350,6)-(350,39) 13 "MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals)
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                __cb.Push("    ");
                #line (351,10)-(351,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(lit));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (352,10)-(352,18) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (352,19)-(352,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first39) __cb.AppendLine();
            __cb.Push("");
            #line (354,1)-(354,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (357,9)-(357,40) 22 "MetaModelGenerator.mxg"
        public string GenerateEnumInfo(MetaEnum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (358,1)-(358,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (358,9)-(358,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,10)-(358,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (358,15)-(358,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,16)-(358,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (358,19)-(358,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (358,28)-(358,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info");
            #line hidden
            #line (358,33)-(358,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,34)-(358,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (358,35)-(358,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,36)-(358,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (359,1)-(359,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (360,5)-(360,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (360,11)-(360,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,12)-(360,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (360,18)-(360,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,19)-(360,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (360,27)-(360,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,28)-(360,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (360,31)-(360,39) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (360,40)-(360,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info");
            #line hidden
            #line (360,45)-(360,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,46)-(360,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (360,54)-(360,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,55)-(360,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (360,56)-(360,57) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,57)-(360,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (360,60)-(360,61) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,61)-(360,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (360,64)-(360,72) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (360,73)-(360,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (362,5)-(362,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (362,12)-(362,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,13)-(362,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (362,21)-(362,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,22)-(362,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<string>");
            #line hidden
            #line (362,81)-(362,82) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,82)-(362,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (363,5)-(363,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (363,12)-(363,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (363,13)-(363,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (363,21)-(363,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (363,22)-(363,86) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (363,86)-(363,87) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (363,87)-(363,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>");
            #line hidden
            #line (363,100)-(363,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (363,101)-(363,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (365,5)-(365,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (365,12)-(365,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (365,13)-(365,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (365,16)-(365,24) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (365,25)-(365,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (366,5)-(366,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (367,9)-(367,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals");
            #line hidden
            #line (367,18)-(367,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (367,19)-(367,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (367,20)-(367,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (367,21)-(367,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<string>(");
            #line hidden
            var __first40 = true;
            #line (367,54)-(367,88) 13 "MetaModelGenerator.mxg"
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
                    #line (367,98)-(367,102) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (367,104)-(367,142) 28 "MetaModelGenerator.mxg"
                __cb.Write(StringUtilities.EncodeString(lit.Name));
                #line hidden
            }
            #line (367,156)-(367,158) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (368,9)-(368,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (368,12)-(368,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (368,13)-(368,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("literalsByName");
            #line hidden
            #line (368,27)-(368,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (368,28)-(368,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (368,29)-(368,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (368,30)-(368,73) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (368,73)-(368,74) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (368,74)-(368,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first41 = true;
            #line (369,10)-(369,43) 13 "MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals)
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                __cb.Push("        ");
                #line (370,13)-(370,33) 29 "MetaModelGenerator.mxg"
                __cb.Write("literalsByName.Add(\"");
                #line hidden
                #line (370,34)-(370,42) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (370,43)-(370,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (370,45)-(370,46) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (370,46)-(370,69) 29 "MetaModelGenerator.mxg"
                __cb.Write("__MetaSymbol.FromValue(");
                #line hidden
                #line (370,70)-(370,78) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (370,79)-(370,80) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (370,81)-(370,89) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (370,90)-(370,93) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first41) __cb.AppendLine();
            __cb.Push("        ");
            #line (372,9)-(372,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName");
            #line hidden
            #line (372,24)-(372,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (372,25)-(372,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (372,26)-(372,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (372,27)-(372,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("literalsByName.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (373,5)-(373,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
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
            #line (375,21)-(375,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (375,32)-(375,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,33)-(375,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaModel");
            #line hidden
            #line (375,42)-(375,43) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,43)-(375,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (375,45)-(375,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,47)-(375,61) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (375,62)-(375,73) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (376,5)-(376,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (376,11)-(376,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,12)-(376,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (376,20)-(376,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,21)-(376,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (376,31)-(376,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,32)-(376,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaType");
            #line hidden
            #line (376,40)-(376,41) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,41)-(376,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (376,43)-(376,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,44)-(376,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (376,52)-(376,60) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (376,61)-(376,63) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (377,5)-(377,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (377,11)-(377,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,12)-(377,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (377,20)-(377,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,21)-(377,80) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<string>");
            #line hidden
            #line (377,80)-(377,81) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,81)-(377,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("Literals");
            #line hidden
            #line (377,89)-(377,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,90)-(377,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (377,92)-(377,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,93)-(377,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (378,5)-(378,14) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (378,14)-(378,15) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,15)-(378,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (378,23)-(378,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,24)-(378,88) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (378,88)-(378,89) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,89)-(378,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>");
            #line hidden
            #line (378,102)-(378,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,103)-(378,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("LiteralsByName");
            #line hidden
            #line (378,117)-(378,118) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,118)-(378,120) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (378,120)-(378,121) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,121)-(378,137) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (379,1)-(379,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (382,9)-(382,42) 22 "MetaModelGenerator.mxg"
        public string GenerateInterface(MetaClass cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (383,2)-(383,119) 13 "MetaModelGenerator.mxg"
            var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
            #line hidden
            
            __cb.Push("");
            #line (384,2)-(384,30) 24 "MetaModelGenerator.mxg"
            __cb.Write(GetDocumentationComment(cls));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (385,1)-(385,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (385,7)-(385,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,8)-(385,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (385,17)-(385,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,19)-(385,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            var __first42 = true;
            #line (385,29)-(385,53) 13 "MetaModelGenerator.mxg"
            if (cls.BaseTypes.Any())
            #line hidden
            
            {
                if (__first42)
                {
                    __first42 = false;
                }
                #line (385,54)-(385,55) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (385,55)-(385,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (385,56)-(385,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first43 = true;
                #line (385,58)-(385,92) 17 "MetaModelGenerator.mxg"
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
                        #line (385,102)-(385,106) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (385,107)-(385,115) 33 "MetaModelGenerator.mxg"
                    __cb.Write("global::");
                    #line hidden
                    #line (385,116)-(385,127) 32 "MetaModelGenerator.mxg"
                    __cb.Write(bt.FullName);
                    #line hidden
                }
            }
            #line (385,142)-(385,146) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first42)
                {
                    __first42 = false;
                }
                #line (385,147)-(385,148) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (385,148)-(385,149) 29 "MetaModelGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (385,149)-(385,150) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (385,150)-(385,164) 29 "MetaModelGenerator.mxg"
                __cb.Write("__IModelObject");
                #line hidden
            }
            if (!__first42) __cb.AppendLine();
            __cb.Push("");
            #line (386,1)-(386,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first44 = true;
            #line (387,6)-(387,54) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.DeclaredProperties)
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                #line (388,10)-(388,53) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                __cb.Push("    ");
                #line (389,10)-(389,58) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(prop.UnderlyingProperty));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                var __first45 = true;
                #line (390,10)-(390,47) 17 "MetaModelGenerator.mxg"
                if (info.HiddenProperties.Length > 0)
                #line hidden
                
                {
                    if (__first45)
                    {
                        __first45 = false;
                    }
                    #line (390,48)-(390,51) 33 "MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (390,51)-(390,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (390,61)-(390,182) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                #line hidden
                #line (390,183)-(390,184) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (390,185)-(390,194) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (390,195)-(390,196) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (390,196)-(390,197) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (390,197)-(390,198) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (390,198)-(390,202) 29 "MetaModelGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (390,202)-(390,203) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first46 = true;
                #line (390,204)-(390,224) 17 "MetaModelGenerator.mxg"
                if (HasSetter(prop))
                #line hidden
                
                {
                    if (__first46)
                    {
                        __first46 = false;
                    }
                    #line (390,225)-(390,229) 33 "MetaModelGenerator.mxg"
                    __cb.Write("set;");
                    #line hidden
                    #line (390,229)-(390,230) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (390,238)-(390,239) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first44) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first47 = true;
            #line (393,6)-(393,40) 13 "MetaModelGenerator.mxg"
            foreach (var op in cls.Operations)
            #line hidden
            
            {
                if (__first47)
                {
                    __first47 = false;
                }
                __cb.Push("    ");
                #line (394,10)-(394,37) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(op));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (395,10)-(395,39) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharpOpType(op.ReturnType));
                #line hidden
                #line (395,40)-(395,41) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (395,42)-(395,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (395,50)-(395,51) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first48 = true;
                #line (395,52)-(395,89) 17 "MetaModelGenerator.mxg"
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
                        #line (395,99)-(395,103) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (395,105)-(395,131) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(param.Type));
                    #line hidden
                    #line (395,132)-(395,133) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (395,134)-(395,166) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name.EscapeCSharpKeyword());
                    #line hidden
                }
                #line (395,180)-(395,182) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first47) __cb.AppendLine();
            __cb.Push("");
            #line (397,1)-(397,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (400,9)-(400,38) 22 "MetaModelGenerator.mxg"
        public string GenerateClass(MetaClass cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (401,2)-(401,119) 13 "MetaModelGenerator.mxg"
            var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
            #line hidden
            
            __cb.Push("");
            #line (402,1)-(402,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (402,9)-(402,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (402,10)-(402,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (402,15)-(402,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (402,17)-(402,25) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (402,26)-(402,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl");
            #line hidden
            #line (402,31)-(402,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (402,32)-(402,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (402,33)-(402,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (402,34)-(402,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModelObject,");
            #line hidden
            #line (402,52)-(402,53) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (402,54)-(402,62) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (403,1)-(403,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (404,5)-(404,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (404,12)-(404,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (404,14)-(404,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (404,23)-(404,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl(string?");
            #line hidden
            #line (404,36)-(404,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (404,37)-(404,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("id)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (405,9)-(405,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (405,10)-(405,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,11)-(405,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(id)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (406,5)-(406,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first49 = true;
            #line (407,10)-(407,45) 13 "MetaModelGenerator.mxg"
            foreach (var slot in metaCls.Slots)
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                #line (408,14)-(408,103) 17 "MetaModelGenerator.mxg"
                var defaultValue = ToDefaultValue(slot.SlotProperty.Type, slot.SlotProperty.DefaultValue);
                #line hidden
                
                var __first50 = true;
                #line (409,14)-(409,83) 17 "MetaModelGenerator.mxg"
                if (!string.IsNullOrEmpty(defaultValue) && defaultValue != "default")
                #line hidden
                
                {
                    if (__first50)
                    {
                        __first50 = false;
                    }
                    __cb.Push("        ");
                    #line (410,17)-(410,49) 33 "MetaModelGenerator.mxg"
                    __cb.Write("((__IModelObject)this).MGetSlot(");
                    #line hidden
                    #line (410,50)-(410,77) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(slot.SlotProperty));
                    #line hidden
                    #line (410,78)-(410,86) 33 "MetaModelGenerator.mxg"
                    __cb.Write(")?.Add((");
                    #line hidden
                    #line (410,87)-(410,119) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(slot.SlotProperty.Type));
                    #line hidden
                    #line (410,120)-(410,121) 33 "MetaModelGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (410,122)-(410,134) 32 "MetaModelGenerator.mxg"
                    __cb.Write(defaultValue);
                    #line hidden
                    #line (410,135)-(410,137) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first50) __cb.AppendLine();
            }
            if (!__first49) __cb.AppendLine();
            var __first51 = true;
            #line (413,10)-(413,66) 13 "MetaModelGenerator.mxg"
            foreach (var baseType in metaCls.AllBaseTypes.Reverse())
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                __cb.Push("        ");
                #line (414,14)-(414,28) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (414,29)-(414,43) 29 "MetaModelGenerator.mxg"
                __cb.Write(".__CustomImpl.");
                #line hidden
                #line (414,44)-(414,57) 28 "MetaModelGenerator.mxg"
                __cb.Write(baseType.Name);
                #line hidden
                #line (414,58)-(414,65) 29 "MetaModelGenerator.mxg"
                __cb.Write("(this);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first51) __cb.AppendLine();
            __cb.Push("        ");
            #line (416,10)-(416,24) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (416,25)-(416,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(".__CustomImpl.");
            #line hidden
            #line (416,40)-(416,48) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (416,49)-(416,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (417,5)-(417,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (419,5)-(419,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (419,11)-(419,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,12)-(419,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (419,20)-(419,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,21)-(419,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            #line (419,37)-(419,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,38)-(419,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("MInfo");
            #line hidden
            #line (419,43)-(419,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,44)-(419,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (419,46)-(419,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,47)-(419,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info.Instance;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first52 = true;
            #line (421,6)-(421,57) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties)
            #line hidden
            
            {
                if (__first52)
                {
                    __first52 = false;
                }
                #line (422,10)-(422,53) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                var __first53 = true;
                #line (423,10)-(423,54) 17 "MetaModelGenerator.mxg"
                if (metaCls.PublicProperties.Contains(prop))
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("    ");
                    #line (424,13)-(424,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (424,19)-(424,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (424,21)-(424,142) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (424,143)-(424,144) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (424,145)-(424,154) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (425,10)-(425,14) 17 "MetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("    ");
                    #line (426,14)-(426,17) 32 "MetaModelGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (426,18)-(426,119) 33 "MetaModelGenerator.mxg"
                    __cb.Write("global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)");
                    #line hidden
                    #line (426,120)-(426,123) 32 "MetaModelGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (427,14)-(427,135) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (427,136)-(427,137) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (427,138)-(427,181) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.DeclaringType.UnderlyingType));
                    #line hidden
                    #line (427,182)-(427,183) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (427,184)-(427,193) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first53) __cb.AppendLine();
                __cb.Push("    ");
                #line (429,9)-(429,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first54 = true;
                #line (430,14)-(430,52) 17 "MetaModelGenerator.mxg"
                if (prop.UnderlyingProperty.IsDerived)
                #line hidden
                
                {
                    if (__first54)
                    {
                        __first54 = false;
                    }
                    #line (431,18)-(431,81) 21 "MetaModelGenerator.mxg"
                    var actualProp = info.HidingProperties.FirstOrDefault() ?? prop;
                    #line hidden
                    
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
                    #line (432,25)-(432,39) 32 "MetaModelGenerator.mxg"
                    __cb.Write(MetaModel.Name);
                    #line hidden
                    #line (432,40)-(432,54) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".__CustomImpl.");
                    #line hidden
                    #line (432,55)-(432,84) 32 "MetaModelGenerator.mxg"
                    __cb.Write(actualProp.DeclaringType.Name);
                    #line hidden
                    #line (432,85)-(432,86) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (432,87)-(432,102) 32 "MetaModelGenerator.mxg"
                    __cb.Write(actualProp.Name);
                    #line hidden
                    #line (432,103)-(432,110) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (433,14)-(433,41) 17 "MetaModelGenerator.mxg"
                else if (prop.IsCollection)
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
                    #line (434,24)-(434,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write("MGetCollection<");
                    #line hidden
                    #line (434,40)-(434,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Type));
                    #line hidden
                    #line (434,60)-(434,62) 33 "MetaModelGenerator.mxg"
                    __cb.Write(">(");
                    #line hidden
                    #line (434,63)-(434,77) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop));
                    #line hidden
                    #line (434,78)-(434,80) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (435,14)-(435,18) 17 "MetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first54)
                    {
                        __first54 = false;
                    }
                    __cb.Push("        ");
                    #line (436,17)-(436,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (436,20)-(436,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (436,21)-(436,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (436,23)-(436,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (436,24)-(436,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write("MGet<");
                    #line hidden
                    #line (436,30)-(436,68) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (436,69)-(436,71) 33 "MetaModelGenerator.mxg"
                    __cb.Write(">(");
                    #line hidden
                    #line (436,72)-(436,86) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop));
                    #line hidden
                    #line (436,87)-(436,89) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first55 = true;
                    #line (437,18)-(437,38) 21 "MetaModelGenerator.mxg"
                    if (HasSetter(prop))
                    #line hidden
                    
                    {
                        if (__first55)
                        {
                            __first55 = false;
                        }
                        __cb.Push("        ");
                        #line (438,21)-(438,24) 37 "MetaModelGenerator.mxg"
                        __cb.Write("set");
                        #line hidden
                        #line (438,24)-(438,25) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (438,25)-(438,27) 37 "MetaModelGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (438,27)-(438,28) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (438,28)-(438,33) 37 "MetaModelGenerator.mxg"
                        __cb.Write("MSet<");
                        #line hidden
                        #line (438,34)-(438,72) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharp(prop.UnderlyingProperty.Type));
                        #line hidden
                        #line (438,73)-(438,75) 37 "MetaModelGenerator.mxg"
                        __cb.Write(">(");
                        #line hidden
                        #line (438,76)-(438,90) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharp(prop));
                        #line hidden
                        #line (438,91)-(438,92) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (438,92)-(438,93) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (438,93)-(438,100) 37 "MetaModelGenerator.mxg"
                        __cb.Write("value);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first55) __cb.AppendLine();
                }
                if (!__first54) __cb.AppendLine();
                __cb.Push("    ");
                #line (441,9)-(441,10) 29 "MetaModelGenerator.mxg"
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
            #line (445,6)-(445,55) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations)
            #line hidden
            
            {
                if (__first56)
                {
                    __first56 = false;
                }
                #line (446,10)-(446,52) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelOperationInfos[op];
                #line hidden
                
                #line (447,10)-(447,73) 17 "MetaModelGenerator.mxg"
                var actualOp = info.OverridingOperations.FirstOrDefault() ?? op;
                #line hidden
                
                __cb.Push("    ");
                #line (448,10)-(448,59) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharpOpType(op.UnderlyingOperation.ReturnType));
                #line hidden
                #line (448,60)-(448,61) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (448,62)-(448,103) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op.DeclaringType.UnderlyingType));
                #line hidden
                #line (448,104)-(448,105) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (448,106)-(448,113) 28 "MetaModelGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (448,114)-(448,115) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first57 = true;
                #line (448,116)-(448,173) 17 "MetaModelGenerator.mxg"
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
                        #line (448,183)-(448,187) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (448,189)-(448,215) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(param.Type));
                    #line hidden
                    #line (448,216)-(448,217) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (448,218)-(448,250) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name.EscapeCSharpKeyword());
                    #line hidden
                }
                #line (448,264)-(448,265) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (448,265)-(448,266) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (448,266)-(448,268) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (448,268)-(448,269) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (448,270)-(448,284) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (448,285)-(448,299) 29 "MetaModelGenerator.mxg"
                __cb.Write(".__CustomImpl.");
                #line hidden
                #line (448,300)-(448,327) 28 "MetaModelGenerator.mxg"
                __cb.Write(actualOp.DeclaringType.Name);
                #line hidden
                #line (448,328)-(448,329) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (448,330)-(448,343) 28 "MetaModelGenerator.mxg"
                __cb.Write(actualOp.Name);
                #line hidden
                #line (448,344)-(448,349) 29 "MetaModelGenerator.mxg"
                __cb.Write("(this");
                #line hidden
                var __first58 = true;
                #line (448,350)-(448,412) 17 "MetaModelGenerator.mxg"
                foreach (var param in actualOp.UnderlyingOperation.Parameters)
                #line hidden
                
                {
                    if (__first58)
                    {
                        __first58 = false;
                    }
                    #line (448,413)-(448,414) 33 "MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (448,414)-(448,415) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (448,416)-(448,448) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name.EscapeCSharpKeyword());
                    #line hidden
                }
                #line (448,462)-(448,464) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first56) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (451,5)-(451,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (451,13)-(451,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,14)-(451,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (451,19)-(451,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,20)-(451,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info");
            #line hidden
            #line (451,26)-(451,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,27)-(451,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (451,28)-(451,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,29)-(451,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (452,5)-(452,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (453,9)-(453,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (453,15)-(453,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,16)-(453,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (453,22)-(453,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,23)-(453,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (453,31)-(453,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,32)-(453,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info");
            #line hidden
            #line (453,38)-(453,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,39)-(453,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (453,47)-(453,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,48)-(453,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (453,49)-(453,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,50)-(453,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (453,53)-(453,54) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,54)-(453,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
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
            #line (455,26)-(455,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (455,95)-(455,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (455,96)-(455,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes;");
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
            #line (456,26)-(456,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (456,95)-(456,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (456,96)-(456,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes;");
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
            #line (457,95)-(457,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties;");
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
            #line (458,26)-(458,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (458,94)-(458,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (458,95)-(458,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties;");
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
            #line (459,26)-(459,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (459,94)-(459,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,95)-(459,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties;");
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
            #line (460,26)-(460,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (460,90)-(460,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,91)-(460,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>");
            #line hidden
            #line (460,107)-(460,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,108)-(460,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName;");
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
            #line (461,26)-(461,99) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty,");
            #line hidden
            #line (461,99)-(461,100) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (461,100)-(461,120) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>");
            #line hidden
            #line (461,120)-(461,121) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (461,121)-(461,141) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos;");
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
            #line (462,96)-(462,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations;");
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
            #line (463,26)-(463,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (463,95)-(463,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,96)-(463,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (464,9)-(464,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (464,16)-(464,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (464,17)-(464,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (464,25)-(464,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (464,26)-(464,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (464,95)-(464,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (464,96)-(464,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (465,9)-(465,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (465,16)-(465,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (465,17)-(465,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (465,25)-(465,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (465,26)-(465,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation,");
            #line hidden
            #line (465,100)-(465,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (465,101)-(465,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>");
            #line hidden
            #line (465,122)-(465,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (465,123)-(465,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (467,9)-(467,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (467,16)-(467,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,17)-(467,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info()");
            #line hidden
            #line (467,25)-(467,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (468,9)-(468,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (469,13)-(469,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes");
            #line hidden
            #line (469,23)-(469,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (469,24)-(469,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (469,25)-(469,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (469,26)-(469,68) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first59 = true;
            #line (469,69)-(469,107) 13 "MetaModelGenerator.mxg"
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
                    #line (469,117)-(469,121) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (469,123)-(469,135) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(bt));
                #line hidden
            }
            #line (469,149)-(469,151) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (470,13)-(470,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes");
            #line hidden
            #line (470,26)-(470,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (470,27)-(470,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (470,28)-(470,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (470,29)-(470,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first60 = true;
            #line (470,72)-(470,113) 13 "MetaModelGenerator.mxg"
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
                    #line (470,123)-(470,127) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (470,129)-(470,141) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(bt));
                #line hidden
            }
            #line (470,155)-(470,157) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (471,13)-(471,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties");
            #line hidden
            #line (471,32)-(471,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (471,33)-(471,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (471,34)-(471,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (471,35)-(471,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first61 = true;
            #line (471,77)-(471,126) 13 "MetaModelGenerator.mxg"
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
                    #line (471,136)-(471,140) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (471,142)-(471,156) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (471,170)-(471,172) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (472,13)-(472,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties");
            #line hidden
            #line (472,35)-(472,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (472,36)-(472,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (472,37)-(472,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (472,38)-(472,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first62 = true;
            #line (472,80)-(472,132) 13 "MetaModelGenerator.mxg"
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
                    #line (472,142)-(472,146) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (472,148)-(472,162) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (472,176)-(472,178) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (473,13)-(473,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties");
            #line hidden
            #line (473,30)-(473,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (473,31)-(473,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (473,32)-(473,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (473,33)-(473,74) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first63 = true;
            #line (473,75)-(473,122) 13 "MetaModelGenerator.mxg"
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
                    #line (473,132)-(473,136) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (473,138)-(473,152) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (473,166)-(473,168) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (474,13)-(474,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (474,16)-(474,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (474,17)-(474,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("publicPropertiesByName");
            #line hidden
            #line (474,39)-(474,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (474,40)-(474,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (474,41)-(474,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (474,42)-(474,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (474,85)-(474,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (474,86)-(474,105) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first64 = true;
            #line (475,14)-(475,60) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.PublicProperties)
            #line hidden
            
            {
                if (__first64)
                {
                    __first64 = false;
                }
                __cb.Push("            ");
                #line (476,17)-(476,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("publicPropertiesByName.Add(\"");
                #line hidden
                #line (476,46)-(476,55) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (476,56)-(476,58) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (476,58)-(476,59) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (476,60)-(476,74) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
                #line (476,75)-(476,77) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first64) __cb.AppendLine();
            __cb.Push("            ");
            #line (478,13)-(478,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName");
            #line hidden
            #line (478,36)-(478,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (478,37)-(478,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (478,38)-(478,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (478,39)-(478,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("publicPropertiesByName.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (479,13)-(479,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (479,16)-(479,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (479,17)-(479,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelPropertyInfos");
            #line hidden
            #line (479,35)-(479,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (479,36)-(479,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (479,37)-(479,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (479,38)-(479,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__ModelProperty,");
            #line hidden
            #line (479,90)-(479,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (479,91)-(479,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first65 = true;
            #line (480,14)-(480,65) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties)
            #line hidden
            
            {
                if (__first65)
                {
                    __first65 = false;
                }
                #line (481,18)-(481,61) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                #line (482,18)-(482,38) 17 "MetaModelGenerator.mxg"
                var slot = info.Slot;
                #line hidden
                
                __cb.Push("            ");
                #line (483,17)-(483,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("modelPropertyInfos.Add(");
                #line hidden
                #line (483,41)-(483,55) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
                #line (483,56)-(483,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (483,57)-(483,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,58)-(483,61) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (483,61)-(483,62) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,62)-(483,85) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelPropertyInfo(new");
                #line hidden
                #line (483,85)-(483,86) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,86)-(483,106) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelPropertySlot(");
                #line hidden
                #line (483,107)-(483,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.SlotProperty));
                #line hidden
                #line (483,135)-(483,136) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (483,136)-(483,137) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,138)-(483,167) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.SlotProperties));
                #line hidden
                #line (483,168)-(483,169) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (483,169)-(483,170) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,171)-(483,215) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToDefaultValue(prop.Type, prop.DefaultValue));
                #line hidden
                #line (483,216)-(483,217) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (483,217)-(483,218) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,219)-(483,239) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.Flags));
                #line hidden
                #line (483,240)-(483,242) 29 "MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (483,242)-(483,243) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,244)-(483,277) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OppositeProperties));
                #line hidden
                #line (483,278)-(483,279) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (483,279)-(483,280) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,281)-(483,315) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.SubsettedProperties));
                #line hidden
                #line (483,316)-(483,317) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (483,317)-(483,318) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,319)-(483,354) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.SubsettingProperties));
                #line hidden
                #line (483,355)-(483,356) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (483,356)-(483,357) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,358)-(483,392) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.RedefinedProperties));
                #line hidden
                #line (483,393)-(483,394) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (483,394)-(483,395) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,396)-(483,431) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.RedefiningProperties));
                #line hidden
                #line (483,432)-(483,433) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (483,433)-(483,434) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,435)-(483,466) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.HiddenProperties));
                #line hidden
                #line (483,467)-(483,468) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (483,468)-(483,469) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,470)-(483,501) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.HidingProperties));
                #line hidden
                #line (483,502)-(483,505) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first65) __cb.AppendLine();
            __cb.Push("            ");
            #line (485,13)-(485,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos");
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
            #line (485,35)-(485,68) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelPropertyInfos.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (487,13)-(487,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations");
            #line hidden
            #line (487,32)-(487,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (487,33)-(487,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (487,34)-(487,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (487,35)-(487,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first66 = true;
            #line (487,78)-(487,125) 13 "MetaModelGenerator.mxg"
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
                    #line (487,135)-(487,139) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (487,141)-(487,153) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (487,167)-(487,169) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (488,13)-(488,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations");
            #line hidden
            #line (488,35)-(488,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,36)-(488,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (488,37)-(488,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,38)-(488,80) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first67 = true;
            #line (488,81)-(488,131) 13 "MetaModelGenerator.mxg"
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
                    #line (488,141)-(488,145) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (488,147)-(488,159) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (488,173)-(488,175) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (489,13)-(489,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations");
            #line hidden
            #line (489,30)-(489,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,31)-(489,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (489,32)-(489,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,33)-(489,75) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first68 = true;
            #line (489,76)-(489,121) 13 "MetaModelGenerator.mxg"
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
                    #line (489,131)-(489,135) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (489,137)-(489,149) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (489,163)-(489,165) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (490,13)-(490,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (490,16)-(490,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (490,17)-(490,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelOperationInfos");
            #line hidden
            #line (490,36)-(490,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (490,37)-(490,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (490,38)-(490,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (490,39)-(490,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__ModelOperation,");
            #line hidden
            #line (490,92)-(490,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (490,93)-(490,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first69 = true;
            #line (491,14)-(491,63) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations)
            #line hidden
            
            {
                if (__first69)
                {
                    __first69 = false;
                }
                #line (492,14)-(492,56) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelOperationInfos[op];
                #line hidden
                
                __cb.Push("                ");
                #line (493,17)-(493,41) 29 "MetaModelGenerator.mxg"
                __cb.Write("modelOperationInfos.Add(");
                #line hidden
                #line (493,42)-(493,54) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
                #line (493,55)-(493,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (493,56)-(493,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (493,57)-(493,60) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (493,60)-(493,61) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (493,61)-(493,82) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelOperationInfo(");
                #line hidden
                #line (493,83)-(493,117) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OverridenOperations));
                #line hidden
                #line (493,118)-(493,119) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (493,119)-(493,120) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (493,121)-(493,156) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OverridingOperations));
                #line hidden
                #line (493,157)-(493,160) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first69) __cb.AppendLine();
            __cb.Push("            ");
            #line (495,13)-(495,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos");
            #line hidden
            #line (495,33)-(495,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,34)-(495,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (495,35)-(495,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,36)-(495,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelOperationInfos.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (496,9)-(496,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (498,9)-(498,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (498,15)-(498,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,16)-(498,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (498,24)-(498,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,25)-(498,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (498,36)-(498,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,37)-(498,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaModel");
            #line hidden
            #line (498,46)-(498,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,47)-(498,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (498,49)-(498,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,51)-(498,65) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (498,66)-(498,77) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance;");
            #line hidden
            __cb.AppendLine();
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
            #line (499,36)-(499,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaType");
            #line hidden
            #line (499,44)-(499,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (499,45)-(499,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (499,47)-(499,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (499,48)-(499,55) 25 "MetaModelGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (499,56)-(499,64) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (499,65)-(499,67) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
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
            #line (501,25)-(501,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (501,35)-(501,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (501,36)-(501,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("SymbolType");
            #line hidden
            #line (501,46)-(501,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (501,47)-(501,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (501,49)-(501,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first70 = true;
            #line (501,51)-(501,82) 13 "MetaModelGenerator.mxg"
            if (metaCls.SymbolType is null)
            #line hidden
            
            {
                if (__first70)
                {
                    __first70 = false;
                }
                #line (501,83)-(501,90) 29 "MetaModelGenerator.mxg"
                __cb.Write("default");
                #line hidden
            }
            #line (501,91)-(501,95) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first70)
                {
                    __first70 = false;
                }
                #line (501,96)-(501,103) 29 "MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (501,104)-(501,132) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.SymbolType));
                #line hidden
                #line (501,133)-(501,134) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (501,142)-(501,143) 25 "MetaModelGenerator.mxg"
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
            #line (502,25)-(502,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty?");
            #line hidden
            #line (502,41)-(502,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,42)-(502,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("NameProperty");
            #line hidden
            #line (502,54)-(502,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,55)-(502,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (502,57)-(502,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first71 = true;
            #line (502,59)-(502,92) 13 "MetaModelGenerator.mxg"
            if (metaCls.NameProperty is null)
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                #line (502,93)-(502,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("null");
                #line hidden
            }
            #line (502,98)-(502,102) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                #line (502,104)-(502,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.NameProperty));
                #line hidden
            }
            #line (502,143)-(502,144) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
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
            #line (503,25)-(503,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty?");
            #line hidden
            #line (503,41)-(503,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,42)-(503,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("TypeProperty");
            #line hidden
            #line (503,54)-(503,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,55)-(503,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (503,57)-(503,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first72 = true;
            #line (503,59)-(503,92) 13 "MetaModelGenerator.mxg"
            if (metaCls.TypeProperty is null)
            #line hidden
            
            {
                if (__first72)
                {
                    __first72 = false;
                }
                #line (503,93)-(503,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("null");
                #line hidden
            }
            #line (503,98)-(503,102) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first72)
                {
                    __first72 = false;
                }
                #line (503,104)-(503,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.TypeProperty));
                #line hidden
            }
            #line (503,143)-(503,144) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
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
            #line (504,25)-(504,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (504,94)-(504,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,95)-(504,104) 25 "MetaModelGenerator.mxg"
            __cb.Write("BaseTypes");
            #line hidden
            #line (504,104)-(504,105) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,105)-(504,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (504,107)-(504,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,108)-(504,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes;");
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
            #line (505,25)-(505,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (505,94)-(505,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,95)-(505,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllBaseTypes");
            #line hidden
            #line (505,107)-(505,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,108)-(505,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (505,110)-(505,111) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,111)-(505,125) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes;");
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
            #line (506,94)-(506,112) 25 "MetaModelGenerator.mxg"
            __cb.Write("DeclaredProperties");
            #line hidden
            #line (506,112)-(506,113) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (506,113)-(506,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (506,115)-(506,116) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (506,116)-(506,136) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties;");
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
            #line (507,25)-(507,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (507,93)-(507,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,94)-(507,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllDeclaredProperties");
            #line hidden
            #line (507,115)-(507,116) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,116)-(507,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (507,118)-(507,119) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,119)-(507,142) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties;");
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
            #line (508,25)-(508,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (508,93)-(508,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (508,94)-(508,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicProperties");
            #line hidden
            #line (508,110)-(508,111) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (508,111)-(508,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (508,113)-(508,114) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (508,114)-(508,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties;");
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
            #line (509,95)-(509,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("DeclaredOperations");
            #line hidden
            #line (509,113)-(509,114) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,114)-(509,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (509,116)-(509,117) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,117)-(509,137) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (510,9)-(510,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (510,15)-(510,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (510,16)-(510,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (510,24)-(510,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (510,25)-(510,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (510,94)-(510,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (510,95)-(510,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllDeclaredOperations");
            #line hidden
            #line (510,116)-(510,117) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (510,117)-(510,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (510,119)-(510,120) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (510,120)-(510,143) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (511,9)-(511,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (511,15)-(511,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,16)-(511,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (511,24)-(511,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,25)-(511,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (511,94)-(511,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,95)-(511,111) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicOperations");
            #line hidden
            #line (511,111)-(511,112) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,112)-(511,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (511,114)-(511,115) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,115)-(511,133) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
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
            #line (513,28)-(513,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (513,92)-(513,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,93)-(513,109) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>");
            #line hidden
            #line (513,109)-(513,110) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,110)-(513,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicPropertiesByName");
            #line hidden
            #line (513,132)-(513,133) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,133)-(513,135) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (513,135)-(513,136) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,136)-(513,160) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (514,9)-(514,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (514,18)-(514,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,19)-(514,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (514,27)-(514,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,28)-(514,101) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty,");
            #line hidden
            #line (514,101)-(514,102) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,102)-(514,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>");
            #line hidden
            #line (514,122)-(514,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,123)-(514,141) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelPropertyInfos");
            #line hidden
            #line (514,141)-(514,142) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,142)-(514,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (514,144)-(514,145) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,145)-(514,165) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (515,9)-(515,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (515,18)-(515,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,19)-(515,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (515,27)-(515,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,28)-(515,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation,");
            #line hidden
            #line (515,102)-(515,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,103)-(515,124) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>");
            #line hidden
            #line (515,124)-(515,125) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,125)-(515,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelOperationInfos");
            #line hidden
            #line (515,144)-(515,145) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,145)-(515,147) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (515,147)-(515,148) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,148)-(515,169) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (517,9)-(517,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (517,15)-(517,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,16)-(517,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (517,24)-(517,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,25)-(517,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (517,40)-(517,41) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,41)-(517,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("Create(__Model?");
            #line hidden
            #line (517,56)-(517,57) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,57)-(517,62) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (517,62)-(517,63) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,63)-(517,64) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (517,64)-(517,65) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,65)-(517,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (517,70)-(517,71) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,71)-(517,78) 25 "MetaModelGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (517,78)-(517,79) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,79)-(517,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("id");
            #line hidden
            #line (517,81)-(517,82) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,82)-(517,83) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (517,83)-(517,84) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,84)-(517,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (518,9)-(518,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (519,13)-(519,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (519,16)-(519,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (519,17)-(519,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (519,23)-(519,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (519,24)-(519,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (519,25)-(519,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (519,26)-(519,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (519,29)-(519,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (519,31)-(519,39) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (519,40)-(519,50) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl(id);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (520,13)-(520,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (520,15)-(520,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (520,16)-(520,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("(model");
            #line hidden
            #line (520,22)-(520,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (520,23)-(520,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (520,25)-(520,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (520,26)-(520,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (520,29)-(520,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (520,30)-(520,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (520,35)-(520,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (520,36)-(520,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("model.AttachObject(result);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (521,13)-(521,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (521,19)-(521,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (521,20)-(521,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (522,9)-(522,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (524,9)-(524,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (524,15)-(524,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (524,16)-(524,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (524,24)-(524,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (524,25)-(524,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (524,31)-(524,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (524,32)-(524,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("ToString()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (525,9)-(525,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (526,13)-(526,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (526,19)-(526,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,20)-(526,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (526,22)-(526,36) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (526,37)-(526,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(".");
            #line hidden
            #line (526,39)-(526,47) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (526,48)-(526,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("Info\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (527,9)-(527,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (528,5)-(528,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (529,1)-(529,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (532,9)-(532,35) 22 "MetaModelGenerator.mxg"
        public string GenerateCustomInterface()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (533,1)-(533,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (533,9)-(533,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (533,10)-(533,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (533,19)-(533,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (533,20)-(533,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("ICustom");
            #line hidden
            #line (533,28)-(533,42) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (533,43)-(533,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (534,1)-(534,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
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
            #line (535,9)-(535,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (536,5)-(536,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (536,8)-(536,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (536,9)-(536,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("Constructor");
            #line hidden
            #line (536,20)-(536,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (536,21)-(536,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (536,24)-(536,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (536,25)-(536,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (536,28)-(536,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (536,29)-(536,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("meta");
            #line hidden
            #line (536,33)-(536,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (536,34)-(536,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (536,39)-(536,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (536,41)-(536,55) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (537,5)-(537,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (537,8)-(537,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (537,9)-(537,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (538,5)-(538,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (538,9)-(538,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (538,11)-(538,25) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (538,26)-(538,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("(I");
            #line hidden
            #line (538,29)-(538,43) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (538,44)-(538,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (538,45)-(538,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("_this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first73 = true;
            #line (540,6)-(540,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first73)
                {
                    __first73 = false;
                }
                __cb.Push("    ");
                #line (541,9)-(541,13) 29 "MetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                #line (541,13)-(541,14) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (541,15)-(541,23) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (541,24)-(541,25) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (541,26)-(541,34) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (541,35)-(541,36) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (541,36)-(541,43) 29 "MetaModelGenerator.mxg"
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
            #line (545,6)-(545,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first74)
                {
                    __first74 = false;
                }
                var __first75 = true;
                #line (546,10)-(546,70) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties.Where(p => p.IsDerived))
                #line hidden
                
                {
                    if (__first75)
                    {
                        __first75 = false;
                    }
                    __cb.Push("    ");
                    #line (547,14)-(547,39) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(prop.Type));
                    #line hidden
                    #line (547,40)-(547,41) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (547,42)-(547,50) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (547,51)-(547,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (547,53)-(547,62) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (547,63)-(547,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (547,65)-(547,73) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (547,74)-(547,75) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (547,75)-(547,82) 33 "MetaModelGenerator.mxg"
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
            #line (552,6)-(552,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                var __first77 = true;
                #line (553,10)-(553,44) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first77)
                    {
                        __first77 = false;
                    }
                    __cb.Push("    ");
                    #line (554,14)-(554,43) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(op.ReturnType));
                    #line hidden
                    #line (554,44)-(554,45) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (554,46)-(554,54) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (554,55)-(554,56) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (554,57)-(554,64) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (554,65)-(554,66) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (554,67)-(554,75) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (554,76)-(554,77) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (554,77)-(554,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this");
                    #line hidden
                    var __first78 = true;
                    #line (554,83)-(554,119) 21 "MetaModelGenerator.mxg"
                    foreach (var param in op.Parameters)
                    #line hidden
                    
                    {
                        if (__first78)
                        {
                            __first78 = false;
                        }
                        #line (554,120)-(554,121) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (554,121)-(554,122) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (554,123)-(554,149) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharpOpType(param.Type));
                        #line hidden
                        #line (554,150)-(554,151) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (554,152)-(554,184) 36 "MetaModelGenerator.mxg"
                        __cb.Write(param.Name.EscapeCSharpKeyword());
                        #line hidden
                    }
                    #line (554,198)-(554,200) 33 "MetaModelGenerator.mxg"
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
            #line (558,1)-(558,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (561,9)-(561,40) 22 "MetaModelGenerator.mxg"
        public string GenerateCustomImplementation()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (562,1)-(562,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (562,9)-(562,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (562,10)-(562,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (562,18)-(562,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (562,19)-(562,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (562,24)-(562,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (562,25)-(562,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("Custom");
            #line hidden
            #line (562,32)-(562,46) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (562,47)-(562,65) 25 "MetaModelGenerator.mxg"
            __cb.Write("ImplementationBase");
            #line hidden
            #line (562,65)-(562,66) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (562,66)-(562,67) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (562,67)-(562,68) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (562,68)-(562,75) 25 "MetaModelGenerator.mxg"
            __cb.Write("ICustom");
            #line hidden
            #line (562,76)-(562,90) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (562,91)-(562,105) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (563,1)-(563,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
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
            #line (564,9)-(564,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (565,5)-(565,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (565,8)-(565,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,9)-(565,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("Constructor");
            #line hidden
            #line (565,20)-(565,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,21)-(565,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (565,24)-(565,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,25)-(565,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (565,28)-(565,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,29)-(565,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("meta");
            #line hidden
            #line (565,33)-(565,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,34)-(565,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (565,39)-(565,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,41)-(565,55) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (566,5)-(566,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (566,8)-(566,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (566,9)-(566,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (567,5)-(567,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (567,11)-(567,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (567,12)-(567,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (567,19)-(567,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (567,20)-(567,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (567,24)-(567,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (567,26)-(567,40) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (567,41)-(567,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("(I");
            #line hidden
            #line (567,44)-(567,58) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (567,59)-(567,60) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (567,60)-(567,66) 25 "MetaModelGenerator.mxg"
            __cb.Write("_this)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (568,5)-(568,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (569,5)-(569,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first79 = true;
            #line (571,6)-(571,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                __cb.Push("    ");
                #line (572,10)-(572,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(cls));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (573,9)-(573,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (573,15)-(573,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (573,16)-(573,23) 29 "MetaModelGenerator.mxg"
                __cb.Write("virtual");
                #line hidden
                #line (573,23)-(573,24) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (573,24)-(573,28) 29 "MetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                #line (573,28)-(573,29) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (573,30)-(573,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (573,39)-(573,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (573,41)-(573,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (573,50)-(573,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (573,51)-(573,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("_this)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (574,9)-(574,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (575,9)-(575,10) 29 "MetaModelGenerator.mxg"
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
            #line (579,6)-(579,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first80)
                {
                    __first80 = false;
                }
                var __first81 = true;
                #line (580,10)-(580,70) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties.Where(p => p.IsDerived))
                #line hidden
                
                {
                    if (__first81)
                    {
                        __first81 = false;
                    }
                    __cb.Push("    ");
                    #line (581,14)-(581,43) 32 "MetaModelGenerator.mxg"
                    __cb.Write(GetDocumentationComment(prop));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (582,13)-(582,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (582,19)-(582,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (582,20)-(582,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (582,28)-(582,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (582,30)-(582,55) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(prop.Type));
                    #line hidden
                    #line (582,56)-(582,57) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (582,58)-(582,66) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (582,67)-(582,68) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (582,69)-(582,78) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (582,79)-(582,80) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (582,81)-(582,89) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (582,90)-(582,91) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (582,91)-(582,98) 33 "MetaModelGenerator.mxg"
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
            #line (587,6)-(587,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first82)
                {
                    __first82 = false;
                }
                var __first83 = true;
                #line (588,10)-(588,44) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first83)
                    {
                        __first83 = false;
                    }
                    __cb.Push("    ");
                    #line (589,14)-(589,41) 32 "MetaModelGenerator.mxg"
                    __cb.Write(GetDocumentationComment(op));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (590,13)-(590,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (590,19)-(590,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (590,20)-(590,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (590,28)-(590,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (590,30)-(590,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(op.ReturnType));
                    #line hidden
                    #line (590,60)-(590,61) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (590,62)-(590,70) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (590,71)-(590,72) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (590,73)-(590,80) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (590,81)-(590,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (590,83)-(590,91) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (590,92)-(590,93) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (590,93)-(590,98) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this");
                    #line hidden
                    var __first84 = true;
                    #line (590,99)-(590,135) 21 "MetaModelGenerator.mxg"
                    foreach (var param in op.Parameters)
                    #line hidden
                    
                    {
                        if (__first84)
                        {
                            __first84 = false;
                        }
                        #line (590,136)-(590,137) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (590,137)-(590,138) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (590,139)-(590,165) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharpOpType(param.Type));
                        #line hidden
                        #line (590,166)-(590,167) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (590,168)-(590,200) 36 "MetaModelGenerator.mxg"
                        __cb.Write(param.Name.EscapeCSharpKeyword());
                        #line hidden
                    }
                    #line (590,214)-(590,216) 33 "MetaModelGenerator.mxg"
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
            #line (594,1)-(594,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}