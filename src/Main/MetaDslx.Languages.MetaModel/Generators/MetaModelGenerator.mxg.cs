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
                #line (283,9)-(283,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (283,15)-(283,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (283,16)-(283,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (283,22)-(283,23) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (283,24)-(283,40) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (283,41)-(283,42) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (283,43)-(283,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (283,50)-(283,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (283,51)-(283,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (283,53)-(283,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (283,54)-(283,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("((I");
                #line hidden
                #line (283,58)-(283,72) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (283,73)-(283,85) 29 "MetaModelGenerator.mxg"
                __cb.Write(")MInstance).");
                #line hidden
                #line (283,86)-(283,92) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (283,93)-(283,94) 29 "MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first32) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first33 = true;
            #line (286,6)-(286,32) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("    ");
                #line (287,9)-(287,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (287,15)-(287,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (287,16)-(287,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (287,22)-(287,23) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (287,23)-(287,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelEnumInfo");
                #line hidden
                #line (287,38)-(287,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (287,40)-(287,48) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (287,49)-(287,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
                #line (287,53)-(287,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (287,54)-(287,56) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (287,56)-(287,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (287,57)-(287,66) 29 "MetaModelGenerator.mxg"
                __cb.Write("__Impl.__");
                #line hidden
                #line (287,67)-(287,75) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (287,76)-(287,91) 29 "MetaModelGenerator.mxg"
                __cb.Write("_Info.Instance;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first33) __cb.AppendLine();
            var __first34 = true;
            #line (289,6)-(289,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.Push("    ");
                #line (290,9)-(290,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (290,15)-(290,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (290,16)-(290,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (290,22)-(290,23) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (290,23)-(290,39) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelClassInfo");
                #line hidden
                #line (290,39)-(290,40) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (290,41)-(290,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (290,50)-(290,54) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
                #line (290,54)-(290,55) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (290,55)-(290,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (290,57)-(290,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (290,58)-(290,65) 29 "MetaModelGenerator.mxg"
                __cb.Write("__Impl.");
                #line hidden
                #line (290,66)-(290,74) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (290,75)-(290,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("_Impl.__Info.Instance;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first35 = true;
                #line (291,6)-(291,42) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    __cb.Push("    ");
                    #line (292,9)-(292,15) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (292,15)-(292,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (292,16)-(292,22) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (292,22)-(292,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (292,23)-(292,38) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (292,38)-(292,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (292,40)-(292,48) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (292,49)-(292,50) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (292,51)-(292,60) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (292,61)-(292,62) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (292,62)-(292,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (292,64)-(292,65) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (292,65)-(292,66) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (292,67)-(292,75) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (292,76)-(292,77) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (292,78)-(292,87) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (292,88)-(292,89) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first35) __cb.AppendLine();
                var __first36 = true;
                #line (294,6)-(294,40) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first36)
                    {
                        __first36 = false;
                    }
                    __cb.Push("    ");
                    #line (295,9)-(295,15) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (295,15)-(295,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (295,16)-(295,22) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (295,22)-(295,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (295,23)-(295,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation");
                    #line hidden
                    #line (295,39)-(295,40) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (295,41)-(295,49) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (295,50)-(295,51) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (295,52)-(295,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (295,60)-(295,61) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (295,61)-(295,63) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (295,63)-(295,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (295,64)-(295,65) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (295,66)-(295,74) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (295,75)-(295,76) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (295,77)-(295,84) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (295,85)-(295,86) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first36) __cb.AppendLine();
            }
            if (!__first34) __cb.AppendLine();
            __cb.Push("");
            #line (298,1)-(298,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (301,9)-(301,27) 22 "MetaModelGenerator.mxg"
        public string GenerateFactory()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (302,1)-(302,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (302,7)-(302,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,8)-(302,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (302,13)-(302,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,15)-(302,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (302,30)-(302,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory");
            #line hidden
            #line (302,42)-(302,43) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,43)-(302,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (302,44)-(302,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,45)-(302,59) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelFactory");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (303,1)-(303,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (304,5)-(304,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (304,11)-(304,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,13)-(304,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (304,28)-(304,48) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(__Model");
            #line hidden
            #line (304,48)-(304,49) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,49)-(304,55) 25 "MetaModelGenerator.mxg"
            __cb.Write("model)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (305,9)-(305,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (305,10)-(305,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,11)-(305,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(model,");
            #line hidden
            #line (305,22)-(305,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,24)-(305,38) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (305,39)-(305,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (306,5)-(306,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (307,5)-(307,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (309,5)-(309,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (309,13)-(309,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,15)-(309,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (309,30)-(309,50) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(__Model");
            #line hidden
            #line (309,50)-(309,51) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,51)-(309,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (309,57)-(309,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,59)-(309,73) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (309,74)-(309,75) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,75)-(309,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("metaModel)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (310,9)-(310,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (310,10)-(310,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,11)-(310,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(model,");
            #line hidden
            #line (310,22)-(310,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,23)-(310,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("metaModel)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (311,5)-(311,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (312,5)-(312,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first37 = true;
            #line (314,6)-(314,60) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes.Where(c => !c.IsAbstract))
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.Push("    ");
                #line (315,9)-(315,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (315,15)-(315,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (315,17)-(315,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (315,31)-(315,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (315,33)-(315,41) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (315,42)-(315,50) 29 "MetaModelGenerator.mxg"
                __cb.Write("(string?");
                #line hidden
                #line (315,50)-(315,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (315,51)-(315,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("id");
                #line hidden
                #line (315,53)-(315,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (315,54)-(315,55) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (315,55)-(315,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (315,56)-(315,61) 29 "MetaModelGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (316,9)-(316,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (317,13)-(317,19) 29 "MetaModelGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (317,19)-(317,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (317,20)-(317,21) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (317,22)-(317,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (317,36)-(317,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (317,38)-(317,52) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (317,53)-(317,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (317,55)-(317,63) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (317,64)-(317,87) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info.Create(base.Model,");
                #line hidden
                #line (317,87)-(317,88) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (317,88)-(317,93) 29 "MetaModelGenerator.mxg"
                __cb.Write("id)!;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (318,9)-(318,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first37) __cb.AppendLine();
            __cb.Push("");
            #line (321,1)-(321,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (323,1)-(323,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (323,7)-(323,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,8)-(323,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (323,13)-(323,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,15)-(323,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (323,30)-(323,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelMultiFactory");
            #line hidden
            #line (323,47)-(323,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,48)-(323,49) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (323,49)-(323,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,50)-(323,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MultiModelFactory");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (324,1)-(324,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (325,5)-(325,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (325,11)-(325,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (325,13)-(325,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (325,28)-(325,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelMultiFactory()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (326,9)-(326,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (326,10)-(326,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,11)-(326,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(new");
            #line hidden
            #line (326,19)-(326,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,20)-(326,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (326,32)-(326,36) 24 "MetaModelGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (326,37)-(326,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,38)-(326,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (326,39)-(326,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,41)-(326,55) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (326,56)-(326,66) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance");
            #line hidden
            #line (326,66)-(326,67) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,67)-(326,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("})");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (327,5)-(327,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (328,5)-(328,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first38 = true;
            #line (330,6)-(330,60) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes.Where(c => !c.IsAbstract))
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("    ");
                #line (331,9)-(331,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (331,15)-(331,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (331,17)-(331,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (331,31)-(331,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (331,33)-(331,41) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (331,42)-(331,50) 29 "MetaModelGenerator.mxg"
                __cb.Write("(__Model");
                #line hidden
                #line (331,50)-(331,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (331,51)-(331,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("model,");
                #line hidden
                #line (331,57)-(331,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (331,58)-(331,65) 29 "MetaModelGenerator.mxg"
                __cb.Write("string?");
                #line hidden
                #line (331,65)-(331,66) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (331,66)-(331,68) 29 "MetaModelGenerator.mxg"
                __cb.Write("id");
                #line hidden
                #line (331,68)-(331,69) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (331,69)-(331,70) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (331,70)-(331,71) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (331,71)-(331,76) 29 "MetaModelGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (332,9)-(332,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (333,13)-(333,19) 29 "MetaModelGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (333,19)-(333,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (333,20)-(333,21) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (333,22)-(333,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (333,36)-(333,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (333,38)-(333,52) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (333,53)-(333,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (333,55)-(333,63) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (333,64)-(333,82) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info.Create(model,");
                #line hidden
                #line (333,82)-(333,83) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (333,83)-(333,88) 29 "MetaModelGenerator.mxg"
                __cb.Write("id)!;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (334,9)-(334,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first38) __cb.AppendLine();
            __cb.Push("");
            #line (337,1)-(337,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (341,9)-(341,36) 22 "MetaModelGenerator.mxg"
        public string GenerateEnum(MetaEnum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (342,1)-(342,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (342,7)-(342,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,8)-(342,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("enum");
            #line hidden
            #line (342,12)-(342,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,14)-(342,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (343,1)-(343,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first39 = true;
            #line (344,6)-(344,39) 13 "MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals)
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                __cb.Push("    ");
                #line (345,10)-(345,18) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (345,19)-(345,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first39) __cb.AppendLine();
            __cb.Push("");
            #line (347,1)-(347,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (350,9)-(350,40) 22 "MetaModelGenerator.mxg"
        public string GenerateEnumInfo(MetaEnum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (351,1)-(351,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (351,9)-(351,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (351,10)-(351,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (351,15)-(351,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (351,16)-(351,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (351,19)-(351,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (351,28)-(351,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info");
            #line hidden
            #line (351,33)-(351,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (351,34)-(351,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (351,35)-(351,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (351,36)-(351,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (352,1)-(352,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (353,5)-(353,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (353,11)-(353,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (353,12)-(353,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (353,18)-(353,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (353,19)-(353,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (353,27)-(353,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (353,28)-(353,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (353,31)-(353,39) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (353,40)-(353,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info");
            #line hidden
            #line (353,45)-(353,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (353,46)-(353,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (353,54)-(353,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (353,55)-(353,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (353,56)-(353,57) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (353,57)-(353,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (353,60)-(353,61) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (353,61)-(353,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (353,64)-(353,72) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (353,73)-(353,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (355,5)-(355,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (355,12)-(355,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,13)-(355,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (355,21)-(355,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,22)-(355,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<string>");
            #line hidden
            #line (355,81)-(355,82) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,82)-(355,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (356,5)-(356,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (356,12)-(356,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,13)-(356,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (356,21)-(356,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,22)-(356,86) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (356,86)-(356,87) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,87)-(356,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>");
            #line hidden
            #line (356,100)-(356,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,101)-(356,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (358,5)-(358,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (358,12)-(358,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,13)-(358,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (358,16)-(358,24) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (358,25)-(358,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (359,5)-(359,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (360,9)-(360,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals");
            #line hidden
            #line (360,18)-(360,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,19)-(360,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (360,20)-(360,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,21)-(360,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<string>(");
            #line hidden
            var __first40 = true;
            #line (360,54)-(360,88) 13 "MetaModelGenerator.mxg"
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
                    #line (360,98)-(360,102) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (360,104)-(360,142) 28 "MetaModelGenerator.mxg"
                __cb.Write(StringUtilities.EncodeString(lit.Name));
                #line hidden
            }
            #line (360,156)-(360,158) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (361,9)-(361,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (361,12)-(361,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (361,13)-(361,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("literalsByName");
            #line hidden
            #line (361,27)-(361,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (361,28)-(361,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (361,29)-(361,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (361,30)-(361,73) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (361,73)-(361,74) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (361,74)-(361,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first41 = true;
            #line (362,10)-(362,43) 13 "MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals)
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                __cb.Push("        ");
                #line (363,13)-(363,33) 29 "MetaModelGenerator.mxg"
                __cb.Write("literalsByName.Add(\"");
                #line hidden
                #line (363,34)-(363,42) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (363,43)-(363,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (363,45)-(363,46) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (363,46)-(363,69) 29 "MetaModelGenerator.mxg"
                __cb.Write("__MetaSymbol.FromValue(");
                #line hidden
                #line (363,70)-(363,78) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (363,79)-(363,80) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (363,81)-(363,89) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (363,90)-(363,93) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first41) __cb.AppendLine();
            __cb.Push("        ");
            #line (365,9)-(365,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName");
            #line hidden
            #line (365,24)-(365,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (365,25)-(365,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (365,26)-(365,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (365,27)-(365,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("literalsByName.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (366,5)-(366,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (368,5)-(368,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (368,11)-(368,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (368,12)-(368,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (368,20)-(368,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (368,21)-(368,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (368,32)-(368,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (368,33)-(368,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaModel");
            #line hidden
            #line (368,42)-(368,43) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (368,43)-(368,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (368,45)-(368,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (368,47)-(368,61) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (368,62)-(368,73) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (369,5)-(369,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (369,11)-(369,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,12)-(369,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (369,20)-(369,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,21)-(369,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (369,31)-(369,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,32)-(369,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaType");
            #line hidden
            #line (369,40)-(369,41) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,41)-(369,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (369,43)-(369,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,44)-(369,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (369,52)-(369,60) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (369,61)-(369,63) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (370,5)-(370,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (370,11)-(370,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (370,12)-(370,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (370,20)-(370,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (370,21)-(370,80) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<string>");
            #line hidden
            #line (370,80)-(370,81) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (370,81)-(370,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("Literals");
            #line hidden
            #line (370,89)-(370,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (370,90)-(370,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (370,92)-(370,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (370,93)-(370,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (371,5)-(371,14) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (371,14)-(371,15) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,15)-(371,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (371,23)-(371,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,24)-(371,88) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (371,88)-(371,89) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,89)-(371,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>");
            #line hidden
            #line (371,102)-(371,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,103)-(371,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("LiteralsByName");
            #line hidden
            #line (371,117)-(371,118) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,118)-(371,120) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (371,120)-(371,121) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,121)-(371,137) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (372,1)-(372,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (375,9)-(375,42) 22 "MetaModelGenerator.mxg"
        public string GenerateInterface(MetaClass cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (376,2)-(376,119) 13 "MetaModelGenerator.mxg"
            var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
            #line hidden
            
            #line (377,1)-(377,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (377,7)-(377,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,8)-(377,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (377,17)-(377,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,19)-(377,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            var __first42 = true;
            #line (377,29)-(377,53) 13 "MetaModelGenerator.mxg"
            if (cls.BaseTypes.Any())
            #line hidden
            
            {
                if (__first42)
                {
                    __first42 = false;
                }
                #line (377,54)-(377,55) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (377,55)-(377,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (377,56)-(377,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first43 = true;
                #line (377,58)-(377,92) 17 "MetaModelGenerator.mxg"
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
                        #line (377,102)-(377,106) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (377,107)-(377,115) 33 "MetaModelGenerator.mxg"
                    __cb.Write("global::");
                    #line hidden
                    #line (377,116)-(377,127) 32 "MetaModelGenerator.mxg"
                    __cb.Write(bt.FullName);
                    #line hidden
                }
            }
            #line (377,142)-(377,146) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first42)
                {
                    __first42 = false;
                }
                #line (377,147)-(377,148) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (377,148)-(377,149) 29 "MetaModelGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (377,149)-(377,150) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (377,150)-(377,164) 29 "MetaModelGenerator.mxg"
                __cb.Write("__IModelObject");
                #line hidden
            }
            if (!__first42) __cb.AppendLine();
            __cb.Push("");
            #line (378,1)-(378,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first44 = true;
            #line (379,6)-(379,54) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.DeclaredProperties)
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                #line (380,10)-(380,53) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                __cb.Push("    ");
                var __first45 = true;
                #line (381,10)-(381,47) 17 "MetaModelGenerator.mxg"
                if (info.HiddenProperties.Length > 0)
                #line hidden
                
                {
                    if (__first45)
                    {
                        __first45 = false;
                    }
                    #line (381,48)-(381,51) 33 "MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (381,51)-(381,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (381,61)-(381,182) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                #line hidden
                #line (381,183)-(381,184) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (381,185)-(381,194) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (381,195)-(381,196) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (381,196)-(381,197) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (381,197)-(381,198) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (381,198)-(381,202) 29 "MetaModelGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (381,202)-(381,203) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first46 = true;
                #line (381,204)-(381,224) 17 "MetaModelGenerator.mxg"
                if (HasSetter(prop))
                #line hidden
                
                {
                    if (__first46)
                    {
                        __first46 = false;
                    }
                    #line (381,225)-(381,229) 33 "MetaModelGenerator.mxg"
                    __cb.Write("set;");
                    #line hidden
                    #line (381,229)-(381,230) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (381,238)-(381,239) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first44) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first47 = true;
            #line (384,6)-(384,40) 13 "MetaModelGenerator.mxg"
            foreach (var op in cls.Operations)
            #line hidden
            
            {
                if (__first47)
                {
                    __first47 = false;
                }
                __cb.Push("    ");
                #line (385,10)-(385,39) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharpOpType(op.ReturnType));
                #line hidden
                #line (385,40)-(385,41) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (385,42)-(385,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (385,50)-(385,51) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first48 = true;
                #line (385,52)-(385,89) 17 "MetaModelGenerator.mxg"
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
                        #line (385,99)-(385,103) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (385,105)-(385,131) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(param.Type));
                    #line hidden
                    #line (385,132)-(385,133) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (385,134)-(385,144) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (385,158)-(385,160) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first47) __cb.AppendLine();
            __cb.Push("");
            #line (387,1)-(387,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (390,9)-(390,38) 22 "MetaModelGenerator.mxg"
        public string GenerateClass(MetaClass cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (391,2)-(391,119) 13 "MetaModelGenerator.mxg"
            var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
            #line hidden
            
            __cb.Push("");
            #line (392,1)-(392,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (392,9)-(392,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (392,10)-(392,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (392,15)-(392,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (392,17)-(392,25) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (392,26)-(392,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl");
            #line hidden
            #line (392,31)-(392,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (392,32)-(392,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (392,33)-(392,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (392,34)-(392,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModelObject,");
            #line hidden
            #line (392,52)-(392,53) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (392,54)-(392,62) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (393,1)-(393,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (394,5)-(394,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (394,12)-(394,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (394,14)-(394,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (394,23)-(394,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl(string?");
            #line hidden
            #line (394,36)-(394,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (394,37)-(394,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("id)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (395,9)-(395,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (395,10)-(395,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,11)-(395,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(id)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (396,5)-(396,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first49 = true;
            #line (397,10)-(397,45) 13 "MetaModelGenerator.mxg"
            foreach (var slot in metaCls.Slots)
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                #line (398,14)-(398,103) 17 "MetaModelGenerator.mxg"
                var defaultValue = ToDefaultValue(slot.SlotProperty.Type, slot.SlotProperty.DefaultValue);
                #line hidden
                
                var __first50 = true;
                #line (399,14)-(399,83) 17 "MetaModelGenerator.mxg"
                if (!string.IsNullOrEmpty(defaultValue) && defaultValue != "default")
                #line hidden
                
                {
                    if (__first50)
                    {
                        __first50 = false;
                    }
                    __cb.Push("        ");
                    #line (400,17)-(400,49) 33 "MetaModelGenerator.mxg"
                    __cb.Write("((__IModelObject)this).MGetSlot(");
                    #line hidden
                    #line (400,50)-(400,77) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(slot.SlotProperty));
                    #line hidden
                    #line (400,78)-(400,86) 33 "MetaModelGenerator.mxg"
                    __cb.Write(")?.Add((");
                    #line hidden
                    #line (400,87)-(400,119) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(slot.SlotProperty.Type));
                    #line hidden
                    #line (400,120)-(400,121) 33 "MetaModelGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (400,122)-(400,134) 32 "MetaModelGenerator.mxg"
                    __cb.Write(defaultValue);
                    #line hidden
                    #line (400,135)-(400,137) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first50) __cb.AppendLine();
            }
            if (!__first49) __cb.AppendLine();
            var __first51 = true;
            #line (403,10)-(403,66) 13 "MetaModelGenerator.mxg"
            foreach (var baseType in metaCls.AllBaseTypes.Reverse())
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                __cb.Push("        ");
                #line (404,14)-(404,28) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (404,29)-(404,43) 29 "MetaModelGenerator.mxg"
                __cb.Write(".__CustomImpl.");
                #line hidden
                #line (404,44)-(404,57) 28 "MetaModelGenerator.mxg"
                __cb.Write(baseType.Name);
                #line hidden
                #line (404,58)-(404,65) 29 "MetaModelGenerator.mxg"
                __cb.Write("(this);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first51) __cb.AppendLine();
            __cb.Push("        ");
            #line (406,10)-(406,24) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (406,25)-(406,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(".__CustomImpl.");
            #line hidden
            #line (406,40)-(406,48) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (406,49)-(406,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (407,5)-(407,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (409,5)-(409,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (409,11)-(409,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (409,12)-(409,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (409,20)-(409,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (409,21)-(409,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            #line (409,37)-(409,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (409,38)-(409,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("MInfo");
            #line hidden
            #line (409,43)-(409,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (409,44)-(409,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (409,46)-(409,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (409,47)-(409,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info.Instance;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first52 = true;
            #line (411,6)-(411,57) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties)
            #line hidden
            
            {
                if (__first52)
                {
                    __first52 = false;
                }
                #line (412,10)-(412,53) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                var __first53 = true;
                #line (413,10)-(413,54) 17 "MetaModelGenerator.mxg"
                if (metaCls.PublicProperties.Contains(prop))
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("    ");
                    #line (414,13)-(414,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (414,19)-(414,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (414,21)-(414,142) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (414,143)-(414,144) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (414,145)-(414,154) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (415,10)-(415,14) 17 "MetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("    ");
                    #line (416,14)-(416,17) 32 "MetaModelGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (416,18)-(416,119) 33 "MetaModelGenerator.mxg"
                    __cb.Write("global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)");
                    #line hidden
                    #line (416,120)-(416,123) 32 "MetaModelGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (417,14)-(417,135) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (417,136)-(417,137) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (417,138)-(417,181) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.DeclaringType.UnderlyingType));
                    #line hidden
                    #line (417,182)-(417,183) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (417,184)-(417,193) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first53) __cb.AppendLine();
                __cb.Push("    ");
                #line (419,9)-(419,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first54 = true;
                #line (420,14)-(420,52) 17 "MetaModelGenerator.mxg"
                if (prop.UnderlyingProperty.IsDerived)
                #line hidden
                
                {
                    if (__first54)
                    {
                        __first54 = false;
                    }
                    #line (421,18)-(421,81) 21 "MetaModelGenerator.mxg"
                    var actualProp = info.HidingProperties.FirstOrDefault() ?? prop;
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (422,17)-(422,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (422,20)-(422,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (422,21)-(422,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (422,23)-(422,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (422,25)-(422,39) 32 "MetaModelGenerator.mxg"
                    __cb.Write(MetaModel.Name);
                    #line hidden
                    #line (422,40)-(422,54) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".__CustomImpl.");
                    #line hidden
                    #line (422,55)-(422,84) 32 "MetaModelGenerator.mxg"
                    __cb.Write(actualProp.DeclaringType.Name);
                    #line hidden
                    #line (422,85)-(422,86) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (422,87)-(422,102) 32 "MetaModelGenerator.mxg"
                    __cb.Write(actualProp.Name);
                    #line hidden
                    #line (422,103)-(422,110) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (423,14)-(423,41) 17 "MetaModelGenerator.mxg"
                else if (prop.IsCollection)
                #line hidden
                
                {
                    if (__first54)
                    {
                        __first54 = false;
                    }
                    __cb.Push("        ");
                    #line (424,17)-(424,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (424,20)-(424,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (424,21)-(424,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (424,23)-(424,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (424,24)-(424,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write("MGetCollection<");
                    #line hidden
                    #line (424,40)-(424,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Type));
                    #line hidden
                    #line (424,60)-(424,62) 33 "MetaModelGenerator.mxg"
                    __cb.Write(">(");
                    #line hidden
                    #line (424,63)-(424,77) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop));
                    #line hidden
                    #line (424,78)-(424,80) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (425,14)-(425,18) 17 "MetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first54)
                    {
                        __first54 = false;
                    }
                    __cb.Push("        ");
                    #line (426,17)-(426,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (426,20)-(426,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (426,21)-(426,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (426,23)-(426,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (426,24)-(426,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write("MGet<");
                    #line hidden
                    #line (426,30)-(426,68) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (426,69)-(426,71) 33 "MetaModelGenerator.mxg"
                    __cb.Write(">(");
                    #line hidden
                    #line (426,72)-(426,86) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop));
                    #line hidden
                    #line (426,87)-(426,89) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first55 = true;
                    #line (427,18)-(427,38) 21 "MetaModelGenerator.mxg"
                    if (HasSetter(prop))
                    #line hidden
                    
                    {
                        if (__first55)
                        {
                            __first55 = false;
                        }
                        __cb.Push("        ");
                        #line (428,21)-(428,24) 37 "MetaModelGenerator.mxg"
                        __cb.Write("set");
                        #line hidden
                        #line (428,24)-(428,25) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (428,25)-(428,27) 37 "MetaModelGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (428,27)-(428,28) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (428,28)-(428,33) 37 "MetaModelGenerator.mxg"
                        __cb.Write("MSet<");
                        #line hidden
                        #line (428,34)-(428,72) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharp(prop.UnderlyingProperty.Type));
                        #line hidden
                        #line (428,73)-(428,75) 37 "MetaModelGenerator.mxg"
                        __cb.Write(">(");
                        #line hidden
                        #line (428,76)-(428,90) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharp(prop));
                        #line hidden
                        #line (428,91)-(428,92) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (428,92)-(428,93) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (428,93)-(428,100) 37 "MetaModelGenerator.mxg"
                        __cb.Write("value);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first55) __cb.AppendLine();
                }
                if (!__first54) __cb.AppendLine();
                __cb.Push("    ");
                #line (431,9)-(431,10) 29 "MetaModelGenerator.mxg"
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
            #line (435,6)-(435,55) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations)
            #line hidden
            
            {
                if (__first56)
                {
                    __first56 = false;
                }
                #line (436,10)-(436,52) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelOperationInfos[op];
                #line hidden
                
                #line (437,10)-(437,73) 17 "MetaModelGenerator.mxg"
                var actualOp = info.OverridingOperations.FirstOrDefault() ?? op;
                #line hidden
                
                __cb.Push("    ");
                #line (438,10)-(438,59) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharpOpType(op.UnderlyingOperation.ReturnType));
                #line hidden
                #line (438,60)-(438,61) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (438,62)-(438,103) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op.DeclaringType.UnderlyingType));
                #line hidden
                #line (438,104)-(438,105) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (438,106)-(438,113) 28 "MetaModelGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (438,114)-(438,115) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first57 = true;
                #line (438,116)-(438,173) 17 "MetaModelGenerator.mxg"
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
                        #line (438,183)-(438,187) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (438,189)-(438,215) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(param.Type));
                    #line hidden
                    #line (438,216)-(438,217) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (438,218)-(438,228) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (438,242)-(438,243) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (438,243)-(438,244) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (438,244)-(438,246) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (438,246)-(438,247) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (438,248)-(438,262) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (438,263)-(438,277) 29 "MetaModelGenerator.mxg"
                __cb.Write(".__CustomImpl.");
                #line hidden
                #line (438,278)-(438,305) 28 "MetaModelGenerator.mxg"
                __cb.Write(actualOp.DeclaringType.Name);
                #line hidden
                #line (438,306)-(438,307) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (438,308)-(438,321) 28 "MetaModelGenerator.mxg"
                __cb.Write(actualOp.Name);
                #line hidden
                #line (438,322)-(438,327) 29 "MetaModelGenerator.mxg"
                __cb.Write("(this");
                #line hidden
                var __first58 = true;
                #line (438,328)-(438,390) 17 "MetaModelGenerator.mxg"
                foreach (var param in actualOp.UnderlyingOperation.Parameters)
                #line hidden
                
                {
                    if (__first58)
                    {
                        __first58 = false;
                    }
                    #line (438,391)-(438,392) 33 "MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (438,392)-(438,393) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (438,394)-(438,404) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (438,418)-(438,420) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first56) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (441,5)-(441,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (441,13)-(441,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,14)-(441,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (441,19)-(441,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,20)-(441,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info");
            #line hidden
            #line (441,26)-(441,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,27)-(441,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (441,28)-(441,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,29)-(441,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (442,5)-(442,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (443,9)-(443,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (443,15)-(443,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,16)-(443,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (443,22)-(443,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,23)-(443,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (443,31)-(443,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,32)-(443,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info");
            #line hidden
            #line (443,38)-(443,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,39)-(443,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (443,47)-(443,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,48)-(443,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (443,49)-(443,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,50)-(443,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (443,53)-(443,54) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,54)-(443,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (445,9)-(445,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (445,16)-(445,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,17)-(445,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (445,25)-(445,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,26)-(445,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (445,95)-(445,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,96)-(445,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (446,9)-(446,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (446,16)-(446,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,17)-(446,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (446,25)-(446,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,26)-(446,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (446,95)-(446,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,96)-(446,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (447,9)-(447,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (447,16)-(447,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (447,17)-(447,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (447,25)-(447,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (447,26)-(447,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (447,94)-(447,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (447,95)-(447,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (448,9)-(448,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (448,16)-(448,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,17)-(448,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (448,25)-(448,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,26)-(448,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (448,94)-(448,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,95)-(448,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (449,9)-(449,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (449,16)-(449,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,17)-(449,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (449,25)-(449,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,26)-(449,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (449,94)-(449,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,95)-(449,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (450,9)-(450,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (450,16)-(450,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,17)-(450,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (450,25)-(450,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,26)-(450,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (450,90)-(450,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,91)-(450,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>");
            #line hidden
            #line (450,107)-(450,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,108)-(450,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (451,9)-(451,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (451,16)-(451,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,17)-(451,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (451,25)-(451,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,26)-(451,99) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty,");
            #line hidden
            #line (451,99)-(451,100) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,100)-(451,120) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>");
            #line hidden
            #line (451,120)-(451,121) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,121)-(451,141) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (452,9)-(452,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (452,16)-(452,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (452,17)-(452,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (452,25)-(452,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (452,26)-(452,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (452,95)-(452,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (452,96)-(452,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations;");
            #line hidden
            __cb.AppendLine();
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
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (453,95)-(453,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,96)-(453,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations;");
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
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (454,95)-(454,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (454,96)-(454,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations;");
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
            #line (455,26)-(455,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation,");
            #line hidden
            #line (455,100)-(455,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (455,101)-(455,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>");
            #line hidden
            #line (455,122)-(455,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (455,123)-(455,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (457,9)-(457,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (457,16)-(457,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,17)-(457,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info()");
            #line hidden
            #line (457,25)-(457,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (458,9)-(458,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (459,13)-(459,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes");
            #line hidden
            #line (459,23)-(459,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,24)-(459,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (459,25)-(459,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,26)-(459,68) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first59 = true;
            #line (459,69)-(459,107) 13 "MetaModelGenerator.mxg"
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
                    #line (459,117)-(459,121) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (459,123)-(459,135) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(bt));
                #line hidden
            }
            #line (459,149)-(459,151) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (460,13)-(460,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes");
            #line hidden
            #line (460,26)-(460,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,27)-(460,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (460,28)-(460,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,29)-(460,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first60 = true;
            #line (460,72)-(460,113) 13 "MetaModelGenerator.mxg"
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
                    #line (460,123)-(460,127) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (460,129)-(460,141) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(bt));
                #line hidden
            }
            #line (460,155)-(460,157) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (461,13)-(461,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties");
            #line hidden
            #line (461,32)-(461,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (461,33)-(461,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (461,34)-(461,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (461,35)-(461,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first61 = true;
            #line (461,77)-(461,126) 13 "MetaModelGenerator.mxg"
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
                    #line (461,136)-(461,140) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (461,142)-(461,156) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (461,170)-(461,172) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (462,13)-(462,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties");
            #line hidden
            #line (462,35)-(462,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,36)-(462,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (462,37)-(462,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,38)-(462,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first62 = true;
            #line (462,80)-(462,132) 13 "MetaModelGenerator.mxg"
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
                    #line (462,142)-(462,146) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (462,148)-(462,162) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (462,176)-(462,178) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (463,13)-(463,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties");
            #line hidden
            #line (463,30)-(463,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,31)-(463,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (463,32)-(463,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,33)-(463,74) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first63 = true;
            #line (463,75)-(463,122) 13 "MetaModelGenerator.mxg"
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
                    #line (463,132)-(463,136) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (463,138)-(463,152) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (463,166)-(463,168) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (464,13)-(464,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (464,16)-(464,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (464,17)-(464,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("publicPropertiesByName");
            #line hidden
            #line (464,39)-(464,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (464,40)-(464,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (464,41)-(464,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (464,42)-(464,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (464,85)-(464,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (464,86)-(464,105) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first64 = true;
            #line (465,14)-(465,60) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.PublicProperties)
            #line hidden
            
            {
                if (__first64)
                {
                    __first64 = false;
                }
                __cb.Push("            ");
                #line (466,17)-(466,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("publicPropertiesByName.Add(\"");
                #line hidden
                #line (466,46)-(466,55) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (466,56)-(466,58) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (466,58)-(466,59) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (466,60)-(466,74) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
                #line (466,75)-(466,77) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first64) __cb.AppendLine();
            __cb.Push("            ");
            #line (468,13)-(468,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName");
            #line hidden
            #line (468,36)-(468,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (468,37)-(468,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (468,38)-(468,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (468,39)-(468,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("publicPropertiesByName.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (469,13)-(469,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (469,16)-(469,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (469,17)-(469,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelPropertyInfos");
            #line hidden
            #line (469,35)-(469,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (469,36)-(469,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (469,37)-(469,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (469,38)-(469,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__ModelProperty,");
            #line hidden
            #line (469,90)-(469,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (469,91)-(469,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first65 = true;
            #line (470,14)-(470,65) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties)
            #line hidden
            
            {
                if (__first65)
                {
                    __first65 = false;
                }
                #line (471,18)-(471,61) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                #line (472,18)-(472,38) 17 "MetaModelGenerator.mxg"
                var slot = info.Slot;
                #line hidden
                
                __cb.Push("            ");
                #line (473,17)-(473,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("modelPropertyInfos.Add(");
                #line hidden
                #line (473,41)-(473,55) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
                #line (473,56)-(473,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (473,57)-(473,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,58)-(473,61) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (473,61)-(473,62) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,62)-(473,85) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelPropertyInfo(new");
                #line hidden
                #line (473,85)-(473,86) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,86)-(473,106) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelPropertySlot(");
                #line hidden
                #line (473,107)-(473,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.SlotProperty));
                #line hidden
                #line (473,135)-(473,136) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (473,136)-(473,137) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,138)-(473,167) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.SlotProperties));
                #line hidden
                #line (473,168)-(473,169) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (473,169)-(473,170) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,171)-(473,215) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToDefaultValue(prop.Type, prop.DefaultValue));
                #line hidden
                #line (473,216)-(473,217) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (473,217)-(473,218) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,219)-(473,239) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.Flags));
                #line hidden
                #line (473,240)-(473,242) 29 "MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (473,242)-(473,243) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,244)-(473,277) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OppositeProperties));
                #line hidden
                #line (473,278)-(473,279) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (473,279)-(473,280) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,281)-(473,315) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.SubsettedProperties));
                #line hidden
                #line (473,316)-(473,317) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (473,317)-(473,318) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,319)-(473,354) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.SubsettingProperties));
                #line hidden
                #line (473,355)-(473,356) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (473,356)-(473,357) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,358)-(473,392) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.RedefinedProperties));
                #line hidden
                #line (473,393)-(473,394) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (473,394)-(473,395) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,396)-(473,431) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.RedefiningProperties));
                #line hidden
                #line (473,432)-(473,433) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (473,433)-(473,434) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,435)-(473,466) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.HiddenProperties));
                #line hidden
                #line (473,467)-(473,468) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (473,468)-(473,469) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,470)-(473,501) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.HidingProperties));
                #line hidden
                #line (473,502)-(473,505) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first65) __cb.AppendLine();
            __cb.Push("            ");
            #line (475,13)-(475,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos");
            #line hidden
            #line (475,32)-(475,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (475,33)-(475,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (475,34)-(475,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (475,35)-(475,68) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelPropertyInfos.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (477,13)-(477,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations");
            #line hidden
            #line (477,32)-(477,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (477,33)-(477,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (477,34)-(477,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (477,35)-(477,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first66 = true;
            #line (477,78)-(477,125) 13 "MetaModelGenerator.mxg"
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
                    #line (477,135)-(477,139) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (477,141)-(477,153) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (477,167)-(477,169) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (478,13)-(478,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations");
            #line hidden
            #line (478,35)-(478,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (478,36)-(478,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (478,37)-(478,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (478,38)-(478,80) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first67 = true;
            #line (478,81)-(478,131) 13 "MetaModelGenerator.mxg"
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
                    #line (478,141)-(478,145) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (478,147)-(478,159) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (478,173)-(478,175) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (479,13)-(479,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations");
            #line hidden
            #line (479,30)-(479,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (479,31)-(479,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (479,32)-(479,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (479,33)-(479,75) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first68 = true;
            #line (479,76)-(479,121) 13 "MetaModelGenerator.mxg"
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
                    #line (479,131)-(479,135) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (479,137)-(479,149) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (479,163)-(479,165) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (480,13)-(480,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (480,16)-(480,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (480,17)-(480,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelOperationInfos");
            #line hidden
            #line (480,36)-(480,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (480,37)-(480,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (480,38)-(480,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (480,39)-(480,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__ModelOperation,");
            #line hidden
            #line (480,92)-(480,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (480,93)-(480,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first69 = true;
            #line (481,14)-(481,63) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations)
            #line hidden
            
            {
                if (__first69)
                {
                    __first69 = false;
                }
                #line (482,14)-(482,56) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelOperationInfos[op];
                #line hidden
                
                __cb.Push("                ");
                #line (483,17)-(483,41) 29 "MetaModelGenerator.mxg"
                __cb.Write("modelOperationInfos.Add(");
                #line hidden
                #line (483,42)-(483,54) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
                #line (483,55)-(483,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (483,56)-(483,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,57)-(483,60) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (483,60)-(483,61) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,61)-(483,82) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelOperationInfo(");
                #line hidden
                #line (483,83)-(483,117) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OverridenOperations));
                #line hidden
                #line (483,118)-(483,119) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (483,119)-(483,120) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (483,121)-(483,156) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OverridingOperations));
                #line hidden
                #line (483,157)-(483,160) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first69) __cb.AppendLine();
            __cb.Push("            ");
            #line (485,13)-(485,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos");
            #line hidden
            #line (485,33)-(485,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (485,34)-(485,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (485,35)-(485,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (485,36)-(485,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelOperationInfos.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (486,9)-(486,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (488,9)-(488,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (488,15)-(488,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,16)-(488,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (488,24)-(488,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,25)-(488,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (488,36)-(488,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,37)-(488,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaModel");
            #line hidden
            #line (488,46)-(488,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,47)-(488,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (488,49)-(488,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,51)-(488,65) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (488,66)-(488,77) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (489,9)-(489,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (489,15)-(489,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,16)-(489,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (489,24)-(489,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,25)-(489,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (489,35)-(489,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,36)-(489,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaType");
            #line hidden
            #line (489,44)-(489,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,45)-(489,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (489,47)-(489,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,48)-(489,55) 25 "MetaModelGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (489,56)-(489,64) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (489,65)-(489,67) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (491,9)-(491,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (491,15)-(491,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (491,16)-(491,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (491,24)-(491,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (491,25)-(491,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (491,35)-(491,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (491,36)-(491,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("SymbolType");
            #line hidden
            #line (491,46)-(491,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (491,47)-(491,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (491,49)-(491,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first70 = true;
            #line (491,51)-(491,82) 13 "MetaModelGenerator.mxg"
            if (metaCls.SymbolType is null)
            #line hidden
            
            {
                if (__first70)
                {
                    __first70 = false;
                }
                #line (491,83)-(491,90) 29 "MetaModelGenerator.mxg"
                __cb.Write("default");
                #line hidden
            }
            #line (491,91)-(491,95) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first70)
                {
                    __first70 = false;
                }
                #line (491,96)-(491,103) 29 "MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (491,104)-(491,132) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.SymbolType));
                #line hidden
                #line (491,133)-(491,134) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (491,142)-(491,143) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (492,9)-(492,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (492,15)-(492,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (492,16)-(492,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (492,24)-(492,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (492,25)-(492,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty?");
            #line hidden
            #line (492,41)-(492,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (492,42)-(492,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("NameProperty");
            #line hidden
            #line (492,54)-(492,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (492,55)-(492,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (492,57)-(492,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first71 = true;
            #line (492,59)-(492,92) 13 "MetaModelGenerator.mxg"
            if (metaCls.NameProperty is null)
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                #line (492,93)-(492,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("null");
                #line hidden
            }
            #line (492,98)-(492,102) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                #line (492,104)-(492,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.NameProperty));
                #line hidden
            }
            #line (492,143)-(492,144) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (493,9)-(493,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (493,15)-(493,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (493,16)-(493,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (493,24)-(493,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (493,25)-(493,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty?");
            #line hidden
            #line (493,41)-(493,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (493,42)-(493,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("TypeProperty");
            #line hidden
            #line (493,54)-(493,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (493,55)-(493,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (493,57)-(493,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first72 = true;
            #line (493,59)-(493,92) 13 "MetaModelGenerator.mxg"
            if (metaCls.TypeProperty is null)
            #line hidden
            
            {
                if (__first72)
                {
                    __first72 = false;
                }
                #line (493,93)-(493,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("null");
                #line hidden
            }
            #line (493,98)-(493,102) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first72)
                {
                    __first72 = false;
                }
                #line (493,104)-(493,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.TypeProperty));
                #line hidden
            }
            #line (493,143)-(493,144) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (494,9)-(494,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (494,15)-(494,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (494,16)-(494,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (494,24)-(494,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (494,25)-(494,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (494,94)-(494,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (494,95)-(494,104) 25 "MetaModelGenerator.mxg"
            __cb.Write("BaseTypes");
            #line hidden
            #line (494,104)-(494,105) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (494,105)-(494,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (494,107)-(494,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (494,108)-(494,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (495,9)-(495,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (495,15)-(495,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,16)-(495,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (495,24)-(495,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,25)-(495,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (495,94)-(495,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,95)-(495,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllBaseTypes");
            #line hidden
            #line (495,107)-(495,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,108)-(495,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (495,110)-(495,111) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,111)-(495,125) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes;");
            #line hidden
            __cb.AppendLine();
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
            #line (496,25)-(496,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (496,93)-(496,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,94)-(496,112) 25 "MetaModelGenerator.mxg"
            __cb.Write("DeclaredProperties");
            #line hidden
            #line (496,112)-(496,113) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,113)-(496,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (496,115)-(496,116) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,116)-(496,136) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties;");
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
            #line (497,25)-(497,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (497,93)-(497,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,94)-(497,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllDeclaredProperties");
            #line hidden
            #line (497,115)-(497,116) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,116)-(497,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (497,118)-(497,119) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,119)-(497,142) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties;");
            #line hidden
            __cb.AppendLine();
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
            #line (498,25)-(498,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (498,93)-(498,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,94)-(498,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicProperties");
            #line hidden
            #line (498,110)-(498,111) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,111)-(498,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (498,113)-(498,114) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,114)-(498,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties;");
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
            #line (499,25)-(499,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (499,94)-(499,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (499,95)-(499,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("DeclaredOperations");
            #line hidden
            #line (499,113)-(499,114) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (499,114)-(499,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (499,116)-(499,117) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (499,117)-(499,137) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations;");
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
            #line (500,25)-(500,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (500,94)-(500,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,95)-(500,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllDeclaredOperations");
            #line hidden
            #line (500,116)-(500,117) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,117)-(500,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (500,119)-(500,120) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,120)-(500,143) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations;");
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
            #line (501,25)-(501,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (501,94)-(501,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (501,95)-(501,111) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicOperations");
            #line hidden
            #line (501,111)-(501,112) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (501,112)-(501,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (501,114)-(501,115) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (501,115)-(501,133) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (503,9)-(503,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (503,18)-(503,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,19)-(503,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (503,27)-(503,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,28)-(503,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (503,92)-(503,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,93)-(503,109) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>");
            #line hidden
            #line (503,109)-(503,110) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,110)-(503,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicPropertiesByName");
            #line hidden
            #line (503,132)-(503,133) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,133)-(503,135) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (503,135)-(503,136) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,136)-(503,160) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (504,9)-(504,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (504,18)-(504,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,19)-(504,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (504,27)-(504,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,28)-(504,101) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty,");
            #line hidden
            #line (504,101)-(504,102) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,102)-(504,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>");
            #line hidden
            #line (504,122)-(504,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,123)-(504,141) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelPropertyInfos");
            #line hidden
            #line (504,141)-(504,142) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,142)-(504,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (504,144)-(504,145) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,145)-(504,165) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (505,9)-(505,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (505,18)-(505,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,19)-(505,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (505,27)-(505,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,28)-(505,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation,");
            #line hidden
            #line (505,102)-(505,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,103)-(505,124) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>");
            #line hidden
            #line (505,124)-(505,125) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,125)-(505,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelOperationInfos");
            #line hidden
            #line (505,144)-(505,145) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,145)-(505,147) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (505,147)-(505,148) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,148)-(505,169) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
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
            #line (507,25)-(507,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (507,40)-(507,41) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,41)-(507,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("Create(__Model?");
            #line hidden
            #line (507,56)-(507,57) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,57)-(507,62) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (507,62)-(507,63) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,63)-(507,64) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (507,64)-(507,65) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,65)-(507,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (507,70)-(507,71) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,71)-(507,78) 25 "MetaModelGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (507,78)-(507,79) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,79)-(507,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("id");
            #line hidden
            #line (507,81)-(507,82) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,82)-(507,83) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (507,83)-(507,84) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,84)-(507,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (508,9)-(508,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (509,13)-(509,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (509,16)-(509,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,17)-(509,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (509,23)-(509,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,24)-(509,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (509,25)-(509,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,26)-(509,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (509,29)-(509,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,31)-(509,39) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (509,40)-(509,50) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl(id);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (510,13)-(510,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (510,15)-(510,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (510,16)-(510,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("(model");
            #line hidden
            #line (510,22)-(510,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (510,23)-(510,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (510,25)-(510,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (510,26)-(510,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (510,29)-(510,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (510,30)-(510,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (510,35)-(510,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (510,36)-(510,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("model.AttachObject(result);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (511,13)-(511,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (511,19)-(511,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,20)-(511,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (512,9)-(512,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (514,9)-(514,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (514,15)-(514,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,16)-(514,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (514,24)-(514,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,25)-(514,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (514,31)-(514,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,32)-(514,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("ToString()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (515,9)-(515,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (516,13)-(516,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (516,19)-(516,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (516,20)-(516,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (516,22)-(516,36) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (516,37)-(516,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(".");
            #line hidden
            #line (516,39)-(516,47) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (516,48)-(516,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("Info\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (517,9)-(517,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (518,5)-(518,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (519,1)-(519,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (522,9)-(522,35) 22 "MetaModelGenerator.mxg"
        public string GenerateCustomInterface()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (523,1)-(523,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (523,9)-(523,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (523,10)-(523,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (523,19)-(523,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (523,20)-(523,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("ICustom");
            #line hidden
            #line (523,28)-(523,42) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (523,43)-(523,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (524,1)-(524,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (525,5)-(525,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (525,8)-(525,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (525,9)-(525,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (526,5)-(526,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (526,8)-(526,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,9)-(526,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("Constructor");
            #line hidden
            #line (526,20)-(526,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,21)-(526,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (526,24)-(526,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,25)-(526,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (526,28)-(526,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,29)-(526,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("meta");
            #line hidden
            #line (526,33)-(526,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,34)-(526,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (526,39)-(526,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,41)-(526,55) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (527,5)-(527,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (527,8)-(527,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (527,9)-(527,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (528,5)-(528,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (528,9)-(528,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (528,11)-(528,25) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (528,26)-(528,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("(I");
            #line hidden
            #line (528,29)-(528,43) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (528,44)-(528,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (528,45)-(528,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("_this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first73 = true;
            #line (530,6)-(530,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first73)
                {
                    __first73 = false;
                }
                __cb.Push("    ");
                #line (531,9)-(531,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (531,12)-(531,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (531,13)-(531,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("<summary>");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (532,9)-(532,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (532,12)-(532,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (532,13)-(532,24) 29 "MetaModelGenerator.mxg"
                __cb.Write("Constructor");
                #line hidden
                #line (532,24)-(532,25) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (532,25)-(532,28) 29 "MetaModelGenerator.mxg"
                __cb.Write("for");
                #line hidden
                #line (532,28)-(532,29) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (532,29)-(532,32) 29 "MetaModelGenerator.mxg"
                __cb.Write("the");
                #line hidden
                #line (532,32)-(532,33) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (532,33)-(532,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("class");
                #line hidden
                #line (532,38)-(532,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (532,40)-(532,48) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (533,9)-(533,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (533,12)-(533,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (533,13)-(533,23) 29 "MetaModelGenerator.mxg"
                __cb.Write("</summary>");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (534,9)-(534,13) 29 "MetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                #line (534,13)-(534,14) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (534,15)-(534,23) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (534,24)-(534,25) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (534,26)-(534,34) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (534,35)-(534,36) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (534,36)-(534,43) 29 "MetaModelGenerator.mxg"
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
            #line (538,6)-(538,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first74)
                {
                    __first74 = false;
                }
                var __first75 = true;
                #line (539,10)-(539,70) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties.Where(p => p.IsDerived))
                #line hidden
                
                {
                    if (__first75)
                    {
                        __first75 = false;
                    }
                    __cb.Push("    ");
                    #line (540,13)-(540,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (540,16)-(540,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (540,17)-(540,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (541,13)-(541,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (541,16)-(541,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (541,17)-(541,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("Computation");
                    #line hidden
                    #line (541,28)-(541,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (541,29)-(541,31) 33 "MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (541,31)-(541,32) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (541,32)-(541,35) 33 "MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (541,35)-(541,36) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (541,36)-(541,43) 33 "MetaModelGenerator.mxg"
                    __cb.Write("derived");
                    #line hidden
                    #line (541,43)-(541,44) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (541,44)-(541,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("property");
                    #line hidden
                    #line (541,52)-(541,53) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (541,54)-(541,62) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (541,63)-(541,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (541,65)-(541,74) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (542,13)-(542,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (542,16)-(542,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (542,17)-(542,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (543,14)-(543,39) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(prop.Type));
                    #line hidden
                    #line (543,40)-(543,41) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (543,42)-(543,50) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (543,51)-(543,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (543,53)-(543,62) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (543,63)-(543,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (543,65)-(543,73) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (543,74)-(543,75) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (543,75)-(543,82) 33 "MetaModelGenerator.mxg"
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
            #line (548,6)-(548,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                var __first77 = true;
                #line (549,10)-(549,44) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first77)
                    {
                        __first77 = false;
                    }
                    __cb.Push("    ");
                    #line (550,13)-(550,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (550,16)-(550,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (550,17)-(550,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (551,13)-(551,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (551,16)-(551,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (551,17)-(551,31) 33 "MetaModelGenerator.mxg"
                    __cb.Write("Implementation");
                    #line hidden
                    #line (551,31)-(551,32) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (551,32)-(551,34) 33 "MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (551,34)-(551,35) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (551,35)-(551,38) 33 "MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (551,38)-(551,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (551,39)-(551,48) 33 "MetaModelGenerator.mxg"
                    __cb.Write("operation");
                    #line hidden
                    #line (551,48)-(551,49) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (551,50)-(551,58) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (551,59)-(551,60) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (551,61)-(551,68) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (552,13)-(552,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (552,16)-(552,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (552,17)-(552,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (553,14)-(553,43) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(op.ReturnType));
                    #line hidden
                    #line (553,44)-(553,45) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (553,46)-(553,54) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (553,55)-(553,56) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (553,57)-(553,64) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (553,65)-(553,66) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (553,67)-(553,75) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (553,76)-(553,77) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (553,77)-(553,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this");
                    #line hidden
                    var __first78 = true;
                    #line (553,83)-(553,119) 21 "MetaModelGenerator.mxg"
                    foreach (var param in op.Parameters)
                    #line hidden
                    
                    {
                        if (__first78)
                        {
                            __first78 = false;
                        }
                        #line (553,120)-(553,121) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (553,121)-(553,122) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (553,123)-(553,149) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharpOpType(param.Type));
                        #line hidden
                        #line (553,150)-(553,151) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (553,152)-(553,162) 36 "MetaModelGenerator.mxg"
                        __cb.Write(param.Name);
                        #line hidden
                    }
                    #line (553,176)-(553,178) 33 "MetaModelGenerator.mxg"
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
            #line (557,1)-(557,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (560,9)-(560,40) 22 "MetaModelGenerator.mxg"
        public string GenerateCustomImplementation()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (561,1)-(561,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (561,9)-(561,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,10)-(561,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (561,18)-(561,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,19)-(561,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (561,24)-(561,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,25)-(561,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("Custom");
            #line hidden
            #line (561,32)-(561,46) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (561,47)-(561,65) 25 "MetaModelGenerator.mxg"
            __cb.Write("ImplementationBase");
            #line hidden
            #line (561,65)-(561,66) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,66)-(561,67) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (561,67)-(561,68) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,68)-(561,75) 25 "MetaModelGenerator.mxg"
            __cb.Write("ICustom");
            #line hidden
            #line (561,76)-(561,90) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (561,91)-(561,105) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (562,1)-(562,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
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
            #line (563,9)-(563,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("<summary>");
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
            #line (564,9)-(564,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("Constructor");
            #line hidden
            #line (564,20)-(564,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (564,21)-(564,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (564,24)-(564,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (564,25)-(564,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (564,28)-(564,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (564,29)-(564,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("meta");
            #line hidden
            #line (564,33)-(564,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (564,34)-(564,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (564,39)-(564,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (564,41)-(564,55) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
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
            #line (565,9)-(565,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (566,5)-(566,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (566,11)-(566,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (566,12)-(566,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (566,19)-(566,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (566,20)-(566,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (566,24)-(566,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (566,26)-(566,40) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (566,41)-(566,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("(I");
            #line hidden
            #line (566,44)-(566,58) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (566,59)-(566,60) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (566,60)-(566,66) 25 "MetaModelGenerator.mxg"
            __cb.Write("_this)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (567,5)-(567,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (568,5)-(568,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first79 = true;
            #line (570,6)-(570,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                __cb.Push("    ");
                #line (571,9)-(571,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (571,12)-(571,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (571,13)-(571,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("<summary>");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (572,9)-(572,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (572,12)-(572,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (572,13)-(572,24) 29 "MetaModelGenerator.mxg"
                __cb.Write("Constructor");
                #line hidden
                #line (572,24)-(572,25) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (572,25)-(572,28) 29 "MetaModelGenerator.mxg"
                __cb.Write("for");
                #line hidden
                #line (572,28)-(572,29) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (572,29)-(572,32) 29 "MetaModelGenerator.mxg"
                __cb.Write("the");
                #line hidden
                #line (572,32)-(572,33) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (572,33)-(572,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("class");
                #line hidden
                #line (572,38)-(572,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (572,40)-(572,48) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (573,9)-(573,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (573,12)-(573,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (573,13)-(573,23) 29 "MetaModelGenerator.mxg"
                __cb.Write("</summary>");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (574,9)-(574,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (574,15)-(574,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (574,16)-(574,23) 29 "MetaModelGenerator.mxg"
                __cb.Write("virtual");
                #line hidden
                #line (574,23)-(574,24) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (574,24)-(574,28) 29 "MetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                #line (574,28)-(574,29) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (574,30)-(574,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (574,39)-(574,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (574,41)-(574,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (574,50)-(574,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (574,51)-(574,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("_this)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (575,9)-(575,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (576,9)-(576,10) 29 "MetaModelGenerator.mxg"
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
            #line (580,6)-(580,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first80)
                {
                    __first80 = false;
                }
                var __first81 = true;
                #line (581,10)-(581,70) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties.Where(p => p.IsDerived))
                #line hidden
                
                {
                    if (__first81)
                    {
                        __first81 = false;
                    }
                    __cb.Push("    ");
                    #line (582,13)-(582,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (582,16)-(582,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (582,17)-(582,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (583,13)-(583,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (583,16)-(583,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (583,17)-(583,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("Computation");
                    #line hidden
                    #line (583,28)-(583,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (583,29)-(583,31) 33 "MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (583,31)-(583,32) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (583,32)-(583,35) 33 "MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (583,35)-(583,36) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (583,36)-(583,43) 33 "MetaModelGenerator.mxg"
                    __cb.Write("derived");
                    #line hidden
                    #line (583,43)-(583,44) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (583,44)-(583,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("property");
                    #line hidden
                    #line (583,52)-(583,53) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (583,54)-(583,62) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (583,63)-(583,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (583,65)-(583,74) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (584,13)-(584,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (584,16)-(584,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (584,17)-(584,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (585,13)-(585,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (585,19)-(585,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (585,20)-(585,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (585,28)-(585,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (585,30)-(585,55) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(prop.Type));
                    #line hidden
                    #line (585,56)-(585,57) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (585,58)-(585,66) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (585,67)-(585,68) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (585,69)-(585,78) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (585,79)-(585,80) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (585,81)-(585,89) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (585,90)-(585,91) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (585,91)-(585,98) 33 "MetaModelGenerator.mxg"
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
            #line (590,6)-(590,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first82)
                {
                    __first82 = false;
                }
                var __first83 = true;
                #line (591,10)-(591,44) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first83)
                    {
                        __first83 = false;
                    }
                    __cb.Push("    ");
                    #line (592,13)-(592,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (592,16)-(592,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (592,17)-(592,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (593,13)-(593,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (593,16)-(593,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (593,17)-(593,31) 33 "MetaModelGenerator.mxg"
                    __cb.Write("Implementation");
                    #line hidden
                    #line (593,31)-(593,32) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (593,32)-(593,34) 33 "MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (593,34)-(593,35) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (593,35)-(593,38) 33 "MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (593,38)-(593,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (593,39)-(593,48) 33 "MetaModelGenerator.mxg"
                    __cb.Write("operation");
                    #line hidden
                    #line (593,48)-(593,49) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (593,50)-(593,58) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (593,59)-(593,60) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (593,61)-(593,68) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (594,13)-(594,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (594,16)-(594,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (594,17)-(594,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (595,13)-(595,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (595,19)-(595,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (595,20)-(595,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (595,28)-(595,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (595,30)-(595,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(op.ReturnType));
                    #line hidden
                    #line (595,60)-(595,61) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (595,62)-(595,70) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (595,71)-(595,72) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (595,73)-(595,80) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (595,81)-(595,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (595,83)-(595,91) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (595,92)-(595,93) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (595,93)-(595,98) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this");
                    #line hidden
                    var __first84 = true;
                    #line (595,99)-(595,135) 21 "MetaModelGenerator.mxg"
                    foreach (var param in op.Parameters)
                    #line hidden
                    
                    {
                        if (__first84)
                        {
                            __first84 = false;
                        }
                        #line (595,136)-(595,137) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (595,137)-(595,138) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (595,139)-(595,165) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharpOpType(param.Type));
                        #line hidden
                        #line (595,166)-(595,167) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (595,168)-(595,178) 36 "MetaModelGenerator.mxg"
                        __cb.Write(param.Name);
                        #line hidden
                    }
                    #line (595,192)-(595,194) 33 "MetaModelGenerator.mxg"
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
            #line (599,1)-(599,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}