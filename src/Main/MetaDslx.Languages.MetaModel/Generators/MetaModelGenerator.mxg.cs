#line (1,10)-(1,50) 10 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
namespace MetaDslx.Languages.MetaModel.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,13) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
    System;
    #line hidden
    #line (4,1)-(4,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,18) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
    System.Linq;
    #line hidden
    #line (5,1)-(5,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,23) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
    Roslyn.Utilities;
    #line hidden
    #line (6,1)-(6,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,41) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
    MetaDslx.Languages.MetaModel.Model;
    #line hidden
    
    #line (8,10)-(8,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
    public partial class MetaModelGenerator
    #line hidden
    {
        #line (10,9)-(10,20) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
        public string Generate()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (11,1)-(11,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (11,10)-(11,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,11)-(11,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (13,10)-(13,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,12)-(13,21) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (15,5)-(15,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (15,10)-(15,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,11)-(15,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaMetaModel");
            #line hidden
            #line (15,26)-(15,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,27)-(15,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (15,28)-(15,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,29)-(15,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Languages.MetaModel.Model.Meta;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (16,5)-(16,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (16,10)-(16,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,11)-(16,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaModelFactory");
            #line hidden
            #line (16,29)-(16,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,30)-(16,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (16,31)-(16,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,32)-(16,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Languages.MetaModel.Model.MetaModelFactory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (17,5)-(17,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (17,10)-(17,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,11)-(17,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (17,18)-(17,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,19)-(17,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (17,20)-(17,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,21)-(17,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (18,5)-(18,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (18,10)-(18,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,11)-(18,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (18,22)-(18,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,23)-(18,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (18,24)-(18,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,25)-(18,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.MetaModel;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (19,5)-(19,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (19,10)-(19,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,11)-(19,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (19,25)-(19,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,26)-(19,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (19,27)-(19,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,28)-(19,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (20,5)-(20,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (20,10)-(20,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,11)-(20,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelFactory");
            #line hidden
            #line (20,25)-(20,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,26)-(20,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (20,27)-(20,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,28)-(20,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelFactory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (21,5)-(21,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (21,10)-(21,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,11)-(21,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MultiModelFactory");
            #line hidden
            #line (21,30)-(21,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,31)-(21,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (21,32)-(21,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,33)-(21,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.MultiModelFactory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,5)-(22,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (22,10)-(22,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,11)-(22,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelVersion");
            #line hidden
            #line (22,25)-(22,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,26)-(22,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (22,27)-(22,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,28)-(22,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelVersion;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (23,5)-(23,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (23,10)-(23,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,11)-(23,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo");
            #line hidden
            #line (23,26)-(23,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,27)-(23,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (23,28)-(23,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,29)-(23,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelEnumInfo;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (24,5)-(24,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (24,10)-(24,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,11)-(24,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            #line (24,27)-(24,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,28)-(24,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (24,29)-(24,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,30)-(24,71) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelClassInfo;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (25,5)-(25,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (25,10)-(25,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,11)-(25,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (25,26)-(25,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,27)-(25,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (25,28)-(25,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,29)-(25,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelProperty;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (26,5)-(26,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (26,10)-(26,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,11)-(26,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyFlags");
            #line hidden
            #line (26,31)-(26,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,32)-(26,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (26,33)-(26,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,34)-(26,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelPropertyFlags;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (27,5)-(27,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (27,10)-(27,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,11)-(27,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelOperation");
            #line hidden
            #line (27,27)-(27,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,28)-(27,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (27,29)-(27,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,30)-(27,71) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelOperation;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (28,5)-(28,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (28,10)-(28,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,11)-(28,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo");
            #line hidden
            #line (28,31)-(28,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,32)-(28,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (28,33)-(28,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,34)-(28,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelOperationInfo;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (29,5)-(29,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (29,10)-(29,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,11)-(29,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray");
            #line hidden
            #line (29,27)-(29,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,28)-(29,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (29,29)-(29,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,30)-(29,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (30,5)-(30,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (30,10)-(30,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,11)-(30,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary");
            #line hidden
            #line (30,32)-(30,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,33)-(30,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (30,34)-(30,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,35)-(30,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (31,5)-(31,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (31,10)-(31,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,11)-(31,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (31,21)-(31,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,22)-(31,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (31,23)-(31,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,24)-(31,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.MetaType;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (32,5)-(32,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (32,10)-(32,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,11)-(32,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol");
            #line hidden
            #line (32,23)-(32,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,24)-(32,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (32,25)-(32,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,26)-(32,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.MetaSymbol;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (33,5)-(33,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (33,10)-(33,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,11)-(33,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (33,17)-(33,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,18)-(33,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (33,19)-(33,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,20)-(33,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Type;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (34,5)-(34,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (34,10)-(34,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,11)-(34,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Enum");
            #line hidden
            #line (34,17)-(34,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,18)-(34,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (34,19)-(34,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,20)-(34,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Enum;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (36,6)-(36,34) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(GenerateMetaModel(MetaModel));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (38,6)-(38,32) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(GenerateFactory(MetaModel));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first1 = true;
            #line (40,6)-(40,32) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                __cb.Push("    ");
                #line (41,10)-(41,38) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(GenerateEnum(MetaModel, enm));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first1) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first2 = true;
            #line (45,6)-(45,34) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first2)
                {
                    __first2 = false;
                }
                __cb.Push("    ");
                #line (46,10)-(46,43) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(GenerateInterface(MetaModel, cls));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (50,6)-(50,40) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(GenerateCustomInterface(MetaModel));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (52,6)-(52,45) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(GenerateCustomImplementation(MetaModel));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (53,1)-(53,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (55,1)-(55,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (55,10)-(55,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,12)-(55,21) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (55,22)-(55,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (56,1)-(56,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (57,5)-(57,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (57,10)-(57,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,11)-(57,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (57,18)-(57,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,19)-(57,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (57,20)-(57,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,21)-(57,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (58,5)-(58,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (58,10)-(58,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,11)-(58,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (58,22)-(58,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,23)-(58,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (58,24)-(58,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,25)-(58,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.MetaModel;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (59,5)-(59,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (59,10)-(59,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,11)-(59,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (59,25)-(59,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,26)-(59,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (59,27)-(59,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,28)-(59,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (60,5)-(60,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (60,10)-(60,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,11)-(60,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaModelObject");
            #line hidden
            #line (60,28)-(60,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,29)-(60,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (60,30)-(60,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,31)-(60,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.MetaModelObject;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (61,5)-(61,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (61,10)-(61,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,11)-(61,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo");
            #line hidden
            #line (61,26)-(61,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,27)-(61,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (61,28)-(61,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,29)-(61,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelEnumInfo;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (62,5)-(62,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (62,10)-(62,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,11)-(62,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            #line (62,27)-(62,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,28)-(62,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (62,29)-(62,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,30)-(62,71) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelClassInfo;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (63,5)-(63,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (63,10)-(63,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,11)-(63,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (63,26)-(63,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,27)-(63,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (63,28)-(63,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,29)-(63,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelProperty;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (64,5)-(64,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (64,10)-(64,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,11)-(64,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyFlags");
            #line hidden
            #line (64,31)-(64,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,32)-(64,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (64,33)-(64,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,34)-(64,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelPropertyFlags;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (65,5)-(65,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (65,10)-(65,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,11)-(65,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo");
            #line hidden
            #line (65,30)-(65,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,31)-(65,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (65,32)-(65,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,33)-(65,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelPropertyInfo;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (66,5)-(66,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (66,10)-(66,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,11)-(66,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertySlot");
            #line hidden
            #line (66,30)-(66,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,31)-(66,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (66,32)-(66,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,33)-(66,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelPropertySlot;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (67,5)-(67,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (67,10)-(67,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,11)-(67,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelOperation");
            #line hidden
            #line (67,27)-(67,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,28)-(67,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (67,29)-(67,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,30)-(67,71) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelOperation;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (68,5)-(68,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (68,10)-(68,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,11)-(68,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo");
            #line hidden
            #line (68,31)-(68,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,32)-(68,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (68,33)-(68,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,34)-(68,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelOperationInfo;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (69,5)-(69,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (69,10)-(69,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,11)-(69,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray");
            #line hidden
            #line (69,27)-(69,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,28)-(69,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (69,29)-(69,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,30)-(69,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (70,5)-(70,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (70,10)-(70,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,11)-(70,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary");
            #line hidden
            #line (70,32)-(70,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,33)-(70,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,34)-(70,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,35)-(70,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (71,5)-(71,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (71,10)-(71,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,11)-(71,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (71,21)-(71,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,22)-(71,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (71,23)-(71,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,24)-(71,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.MetaType;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (72,5)-(72,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (72,10)-(72,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,11)-(72,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol");
            #line hidden
            #line (72,23)-(72,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,24)-(72,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (72,25)-(72,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,26)-(72,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.MetaSymbol;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (73,5)-(73,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (73,10)-(73,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,11)-(73,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (73,17)-(73,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,18)-(73,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,19)-(73,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,20)-(73,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Type;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (74,5)-(74,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (74,10)-(74,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,11)-(74,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Enum");
            #line hidden
            #line (74,17)-(74,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,18)-(74,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,19)-(74,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,20)-(74,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Enum;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first3 = true;
            #line (76,6)-(76,32) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                __cb.Push("    ");
                #line (77,10)-(77,42) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(GenerateEnumInfo(MetaModel, enm));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first3) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first4 = true;
            #line (81,6)-(81,34) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first4)
                {
                    __first4 = false;
                }
                __cb.Push("    ");
                #line (82,10)-(82,39) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(GenerateClass(MetaModel, cls));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first4) __cb.AppendLine();
            __cb.Push("");
            #line (85,1)-(85,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (88,9)-(88,41) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
        public string GenerateMetaModel(MetaModel mm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (89,1)-(89,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (89,9)-(89,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,10)-(89,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (89,19)-(89,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,20)-(89,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("I");
            #line hidden
            #line (89,22)-(89,29) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (90,1)-(90,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first5 = true;
            #line (91,6)-(91,70) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var c in mm.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
                __cb.Push("    ");
                #line (92,10)-(92,26) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (92,27)-(92,28) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (92,29)-(92,35) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (92,36)-(92,37) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (92,37)-(92,38) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (92,38)-(92,39) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (92,39)-(92,43) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (92,43)-(92,44) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (92,44)-(92,45) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            __cb.Push("");
            #line (94,1)-(94,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (96,1)-(96,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (96,7)-(96,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,8)-(96,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("sealed");
            #line hidden
            #line (96,14)-(96,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,15)-(96,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (96,20)-(96,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,22)-(96,29) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (96,30)-(96,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,31)-(96,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (96,32)-(96,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,33)-(96,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaModel,");
            #line hidden
            #line (96,45)-(96,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,46)-(96,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("I");
            #line hidden
            #line (96,48)-(96,55) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (97,1)-(97,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (98,5)-(98,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (98,7)-(98,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,8)-(98,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("If");
            #line hidden
            #line (98,10)-(98,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,11)-(98,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("there");
            #line hidden
            #line (98,16)-(98,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,17)-(98,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (98,19)-(98,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,20)-(98,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("an");
            #line hidden
            #line (98,22)-(98,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,23)-(98,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("error");
            #line hidden
            #line (98,28)-(98,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,29)-(98,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("at");
            #line hidden
            #line (98,31)-(98,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,32)-(98,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (98,35)-(98,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,36)-(98,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("following");
            #line hidden
            #line (98,45)-(98,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,46)-(98,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("line,");
            #line hidden
            #line (98,51)-(98,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,52)-(98,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("create");
            #line hidden
            #line (98,58)-(98,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,59)-(98,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("a");
            #line hidden
            #line (98,60)-(98,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,61)-(98,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (98,64)-(98,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,65)-(98,70) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (98,70)-(98,71) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,71)-(98,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("called");
            #line hidden
            #line (98,77)-(98,78) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,78)-(98,85) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("'Custom");
            #line hidden
            #line (98,86)-(98,93) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (98,94)-(98,109) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Implementation'");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (99,5)-(99,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (99,7)-(99,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,8)-(99,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("inheriting");
            #line hidden
            #line (99,18)-(99,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,19)-(99,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("from");
            #line hidden
            #line (99,23)-(99,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,24)-(99,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (99,27)-(99,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,28)-(99,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (99,33)-(99,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,34)-(99,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("'Custom");
            #line hidden
            #line (99,42)-(99,49) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (99,50)-(99,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("ImplementationBase'");
            #line hidden
            #line (99,69)-(99,70) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,70)-(99,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("and");
            #line hidden
            #line (99,73)-(99,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,74)-(99,81) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("provide");
            #line hidden
            #line (99,81)-(99,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,82)-(99,85) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (99,85)-(99,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,86)-(99,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("custom");
            #line hidden
            #line (99,92)-(99,93) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,93)-(99,107) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("implementation");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (100,5)-(100,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (100,7)-(100,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,8)-(100,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (100,11)-(100,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,12)-(100,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (100,15)-(100,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,16)-(100,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("derived");
            #line hidden
            #line (100,23)-(100,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,24)-(100,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("properties");
            #line hidden
            #line (100,34)-(100,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,35)-(100,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("and");
            #line hidden
            #line (100,38)-(100,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,39)-(100,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("operations");
            #line hidden
            #line (100,49)-(100,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,50)-(100,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("defined");
            #line hidden
            #line (100,57)-(100,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,58)-(100,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("in");
            #line hidden
            #line (100,60)-(100,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,61)-(100,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (100,64)-(100,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,65)-(100,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("metamodel");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (101,5)-(101,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (101,13)-(101,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,14)-(101,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (101,20)-(101,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,21)-(101,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (101,29)-(101,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,30)-(101,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Custom");
            #line hidden
            #line (101,37)-(101,44) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (101,45)-(101,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("ImplementationBase");
            #line hidden
            #line (101,63)-(101,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,64)-(101,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__CustomImpl");
            #line hidden
            #line (101,76)-(101,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,77)-(101,78) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (101,78)-(101,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,79)-(101,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (101,82)-(101,83) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,83)-(101,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Custom");
            #line hidden
            #line (101,90)-(101,97) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (101,98)-(101,115) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Implementation();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (103,5)-(103,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (103,12)-(103,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,13)-(103,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (103,19)-(103,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,20)-(103,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (103,28)-(103,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,30)-(103,37) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (103,38)-(103,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,39)-(103,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_instance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (104,5)-(104,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (104,11)-(104,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,12)-(104,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (104,18)-(104,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,20)-(104,27) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (104,28)-(104,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,29)-(104,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MInstance");
            #line hidden
            #line (104,38)-(104,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,39)-(104,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (104,41)-(104,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,42)-(104,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_instance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first6 = true;
            #line (106,6)-(106,69) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in mm.Parent.Declarations.OfType<MetaClass>())
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                var __first7 = true;
                #line (107,10)-(107,46) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties)
                #line hidden
                
                {
                    if (__first7)
                    {
                        __first7 = false;
                    }
                    __cb.Push("    ");
                    #line (108,13)-(108,20) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (108,20)-(108,21) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (108,21)-(108,27) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (108,27)-(108,28) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (108,28)-(108,36) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("readonly");
                    #line hidden
                    #line (108,36)-(108,37) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (108,37)-(108,52) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (108,52)-(108,53) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (108,53)-(108,54) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (108,55)-(108,63) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (108,64)-(108,65) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (108,66)-(108,75) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (108,76)-(108,77) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first7) __cb.AppendLine();
                var __first8 = true;
                #line (110,10)-(110,44) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("    ");
                    #line (111,13)-(111,20) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (111,20)-(111,21) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (111,21)-(111,27) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (111,27)-(111,28) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (111,28)-(111,36) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("readonly");
                    #line hidden
                    #line (111,36)-(111,37) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (111,37)-(111,53) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation");
                    #line hidden
                    #line (111,53)-(111,54) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (111,54)-(111,55) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (111,56)-(111,64) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (111,65)-(111,66) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (111,67)-(111,74) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (111,75)-(111,76) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first8) __cb.AppendLine();
            }
            if (!__first6) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (115,5)-(115,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (115,11)-(115,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,13)-(115,20) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (115,21)-(115,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (116,5)-(116,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first9 = true;
            #line (117,10)-(117,38) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                #line (118,14)-(118,131) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
                #line hidden
                
                var __first10 = true;
                #line (119,14)-(119,62) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var prop in metaCls.DeclaredProperties)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (120,17)-(120,18) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (120,19)-(120,27) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (120,28)-(120,29) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (120,30)-(120,39) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (120,40)-(120,41) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,41)-(120,42) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (120,42)-(120,43) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,43)-(120,46) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (120,46)-(120,47) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,47)-(120,70) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty(typeof(");
                    #line hidden
                    #line (120,71)-(120,79) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (120,80)-(120,82) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("),");
                    #line hidden
                    #line (120,82)-(120,83) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,83)-(120,84) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (120,85)-(120,94) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (120,95)-(120,97) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("\",");
                    #line hidden
                    #line (120,97)-(120,98) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,98)-(120,105) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("typeof(");
                    #line hidden
                    #line (120,106)-(120,125) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Type));
                    #line hidden
                    #line (120,126)-(120,128) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("),");
                    #line hidden
                    #line (120,128)-(120,129) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,129)-(120,134) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("null,");
                    #line hidden
                    #line (120,134)-(120,135) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,136)-(120,156) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Flags));
                    #line hidden
                    #line (120,157)-(120,158) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (120,158)-(120,159) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    var __first11 = true;
                    #line (120,160)-(120,191) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    if(prop.SymbolProperty is null)
                    #line hidden
                    
                    {
                        if (__first11)
                        {
                            __first11 = false;
                        }
                        #line (120,192)-(120,196) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write("null");
                        #line hidden
                    }
                    #line (120,197)-(120,201) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first11)
                        {
                            __first11 = false;
                        }
                        #line (120,202)-(120,203) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write("\"");
                        #line hidden
                        #line (120,204)-(120,223) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(prop.SymbolProperty);
                        #line hidden
                        #line (120,224)-(120,225) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write("\"");
                        #line hidden
                    }
                    #line (120,233)-(120,235) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                var __first12 = true;
                #line (122,14)-(122,60) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var op in metaCls.DeclaredOperations)
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("        ");
                    #line (123,17)-(123,18) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (123,19)-(123,27) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (123,28)-(123,29) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (123,30)-(123,37) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (123,38)-(123,39) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (123,39)-(123,40) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (123,40)-(123,41) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (123,41)-(123,44) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (123,44)-(123,45) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (123,45)-(123,69) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation(typeof(");
                    #line hidden
                    #line (123,70)-(123,78) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (123,79)-(123,81) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("),");
                    #line hidden
                    #line (123,81)-(123,82) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (123,82)-(123,83) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (123,84)-(123,91) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (123,92)-(123,94) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("\",");
                    #line hidden
                    #line (123,94)-(123,95) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (123,95)-(123,96) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (123,97)-(123,104) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (123,105)-(123,106) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (123,107)-(123,146) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(op.UnderlyingOperation.Parameters.Count);
                    #line hidden
                    #line (123,147)-(123,151) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(")\");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first12) __cb.AppendLine();
            }
            if (!__first9) __cb.AppendLine();
            __cb.Push("        ");
            #line (126,9)-(126,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_instance");
            #line hidden
            #line (126,18)-(126,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,19)-(126,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (126,20)-(126,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,21)-(126,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (126,24)-(126,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,26)-(126,33) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (126,34)-(126,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (127,5)-(127,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (129,5)-(129,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (129,12)-(129,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,13)-(129,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (129,21)-(129,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,22)-(129,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (129,29)-(129,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,30)-(129,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_model;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (131,5)-(131,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (131,12)-(131,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,13)-(131,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (131,21)-(131,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,22)-(131,85) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (131,85)-(131,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,86)-(131,97) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_enumTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (132,5)-(132,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (132,12)-(132,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,13)-(132,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (132,21)-(132,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,22)-(132,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo>");
            #line hidden
            #line (132,90)-(132,91) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,91)-(132,102) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_enumInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (133,5)-(133,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (133,12)-(133,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,13)-(133,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (133,21)-(133,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,22)-(133,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (133,90)-(133,91) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,91)-(133,107) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (133,107)-(133,108) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,108)-(133,125) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByType;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (134,5)-(134,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (134,12)-(134,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,13)-(134,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (134,21)-(134,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,22)-(134,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (134,86)-(134,87) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,87)-(134,103) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (134,103)-(134,104) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,104)-(134,121) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (136,5)-(136,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (136,12)-(136,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,13)-(136,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (136,21)-(136,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,22)-(136,85) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (136,85)-(136,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,86)-(136,98) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_classTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (137,5)-(137,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (137,12)-(137,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,13)-(137,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (137,21)-(137,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,22)-(137,91) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (137,91)-(137,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,92)-(137,104) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_classInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (138,5)-(138,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (138,12)-(138,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,13)-(138,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (138,21)-(138,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,22)-(138,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (138,90)-(138,91) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,91)-(138,108) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (138,108)-(138,109) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,109)-(138,127) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_classInfosByType;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (139,5)-(139,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (139,12)-(139,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,13)-(139,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (139,21)-(139,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,22)-(139,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (139,86)-(139,87) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,87)-(139,104) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (139,104)-(139,105) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,105)-(139,123) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_classInfosByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first13 = true;
            #line (141,6)-(141,70) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var c in mm.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                __cb.Push("    ");
                #line (142,9)-(142,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (142,16)-(142,17) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (142,17)-(142,25) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (142,25)-(142,26) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (142,27)-(142,43) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (142,44)-(142,45) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (142,45)-(142,46) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (142,47)-(142,67) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(c.Name.ToCamelCase());
                #line hidden
                #line (142,68)-(142,69) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first13) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (145,5)-(145,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (145,12)-(145,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,14)-(145,21) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (145,22)-(145,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (146,5)-(146,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (147,9)-(147,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_enumTypes");
            #line hidden
            #line (147,19)-(147,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,20)-(147,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (147,21)-(147,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,22)-(147,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__MetaType>(");
            #line hidden
            var __first14 = true;
            #line (147,59)-(147,86) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (147,96)-(147,100) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (147,101)-(147,108) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (147,109)-(147,117) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (147,118)-(147,119) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (147,132)-(147,134) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (148,9)-(148,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_enumInfos");
            #line hidden
            #line (148,19)-(148,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,20)-(148,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (148,21)-(148,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,22)-(148,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelEnumInfo>(");
            #line hidden
            var __first15 = true;
            #line (148,64)-(148,91) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (148,101)-(148,105) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (148,107)-(148,115) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (148,116)-(148,120) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
            }
            #line (148,133)-(148,135) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (149,9)-(149,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (149,12)-(149,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,13)-(149,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("enumInfosByType");
            #line hidden
            #line (149,28)-(149,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,29)-(149,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (149,30)-(149,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,31)-(149,78) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__MetaType,");
            #line hidden
            #line (149,78)-(149,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,79)-(149,98) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first16 = true;
            #line (150,10)-(150,36) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first16)
                {
                    __first16 = false;
                }
                __cb.Push("        ");
                #line (151,13)-(151,40) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("enumInfosByType.Add(typeof(");
                #line hidden
                #line (151,41)-(151,49) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (151,50)-(151,52) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (151,52)-(151,53) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (151,54)-(151,62) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (151,63)-(151,69) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first16) __cb.AppendLine();
            __cb.Push("        ");
            #line (153,9)-(153,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByType");
            #line hidden
            #line (153,25)-(153,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,26)-(153,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (153,27)-(153,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,28)-(153,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("enumInfosByType.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (154,9)-(154,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (154,12)-(154,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,13)-(154,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("enumInfosByName");
            #line hidden
            #line (154,28)-(154,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,29)-(154,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (154,30)-(154,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,31)-(154,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (154,74)-(154,75) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,75)-(154,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first17 = true;
            #line (155,10)-(155,36) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first17)
                {
                    __first17 = false;
                }
                __cb.Push("        ");
                #line (156,13)-(156,34) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("enumInfosByName.Add(\"");
                #line hidden
                #line (156,35)-(156,43) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (156,44)-(156,46) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (156,46)-(156,47) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (156,48)-(156,56) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (156,57)-(156,63) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first17) __cb.AppendLine();
            __cb.Push("        ");
            #line (158,9)-(158,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByName");
            #line hidden
            #line (158,25)-(158,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,26)-(158,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (158,27)-(158,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,28)-(158,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("enumInfosByName.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (160,9)-(160,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_classTypes");
            #line hidden
            #line (160,20)-(160,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,21)-(160,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (160,22)-(160,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,23)-(160,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__MetaType>(");
            #line hidden
            var __first18 = true;
            #line (160,60)-(160,89) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (160,99)-(160,103) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (160,104)-(160,111) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (160,112)-(160,120) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (160,121)-(160,122) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (160,135)-(160,137) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (161,9)-(161,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_classInfos");
            #line hidden
            #line (161,20)-(161,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (161,21)-(161,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (161,22)-(161,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (161,23)-(161,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first19 = true;
            #line (161,66)-(161,95) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (161,105)-(161,109) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (161,111)-(161,119) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (161,120)-(161,124) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
            }
            #line (161,137)-(161,139) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (162,9)-(162,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (162,12)-(162,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,13)-(162,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("classInfosByType");
            #line hidden
            #line (162,29)-(162,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,30)-(162,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (162,31)-(162,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,32)-(162,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__MetaType,");
            #line hidden
            #line (162,79)-(162,80) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,80)-(162,100) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first20 = true;
            #line (163,10)-(163,38) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first20)
                {
                    __first20 = false;
                }
                __cb.Push("        ");
                #line (164,13)-(164,41) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("classInfosByType.Add(typeof(");
                #line hidden
                #line (164,42)-(164,50) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (164,51)-(164,53) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (164,53)-(164,54) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (164,55)-(164,63) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (164,64)-(164,70) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first20) __cb.AppendLine();
            __cb.Push("        ");
            #line (166,9)-(166,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_classInfosByType");
            #line hidden
            #line (166,26)-(166,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,27)-(166,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (166,28)-(166,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,29)-(166,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("classInfosByType.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (167,9)-(167,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (167,12)-(167,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,13)-(167,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("classInfosByName");
            #line hidden
            #line (167,29)-(167,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,30)-(167,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (167,31)-(167,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,32)-(167,75) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (167,75)-(167,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,76)-(167,96) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first21 = true;
            #line (168,10)-(168,38) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                __cb.Push("        ");
                #line (169,13)-(169,35) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("classInfosByName.Add(\"");
                #line hidden
                #line (169,36)-(169,44) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (169,45)-(169,47) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (169,47)-(169,48) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (169,49)-(169,57) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (169,58)-(169,64) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first21) __cb.AppendLine();
            __cb.Push("        ");
            #line (171,9)-(171,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_classInfosByName");
            #line hidden
            #line (171,26)-(171,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,27)-(171,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (171,28)-(171,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,29)-(171,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("classInfosByName.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (172,9)-(172,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_model");
            #line hidden
            #line (172,15)-(172,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,16)-(172,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (172,17)-(172,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,18)-(172,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (172,21)-(172,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,22)-(172,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Model();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (173,9)-(173,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (173,12)-(173,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,13)-(173,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("f");
            #line hidden
            #line (173,14)-(173,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,15)-(173,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (173,16)-(173,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,17)-(173,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (173,20)-(173,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,21)-(173,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaModelFactory(_model);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first22 = true;
            #line (174,10)-(174,74) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var c in mm.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("        ");
                #line (175,13)-(175,14) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (175,15)-(175,35) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(c.Name.ToCamelCase());
                #line hidden
                #line (175,36)-(175,37) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (175,37)-(175,38) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (175,38)-(175,39) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (175,39)-(175,41) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("f.");
                #line hidden
                #line (175,42)-(175,53) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(c.Type.Name);
                #line hidden
                #line (175,54)-(175,57) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first22) __cb.AppendLine();
            var __first23 = true;
            #line (177,10)-(177,38) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var obj in Objects)
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                __cb.Push("        ");
                #line (178,13)-(178,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (178,16)-(178,17) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,18)-(178,30) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(GetName(obj));
                #line hidden
                #line (178,31)-(178,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,32)-(178,33) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (178,33)-(178,34) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,34)-(178,36) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("f.");
                #line hidden
                #line (178,37)-(178,60) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(obj.MInfo.MetaType.Name);
                #line hidden
                #line (178,61)-(178,64) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first23) __cb.AppendLine();
            __cb.Push("        ");
            #line (180,9)-(180,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__CustomImpl.");
            #line hidden
            #line (180,23)-(180,30) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (180,31)-(180,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first24 = true;
            #line (181,10)-(181,38) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var obj in Objects)
            #line hidden
            
            {
                if (__first24)
                {
                    __first24 = false;
                }
                var __first25 = true;
                #line (182,14)-(182,50) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var child in obj.MChildren)
                #line hidden
                
                {
                    if (__first25)
                    {
                        __first25 = false;
                    }
                    __cb.Push("        ");
                    #line (183,17)-(183,34) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("((__IModelObject)");
                    #line hidden
                    #line (183,35)-(183,47) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(GetName(obj));
                    #line hidden
                    #line (183,48)-(183,80) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(").MChildren.Add((__IModelObject)");
                    #line hidden
                    #line (183,81)-(183,95) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(GetName(child));
                    #line hidden
                    #line (183,96)-(183,98) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first25) __cb.AppendLine();
                var __first26 = true;
                #line (185,14)-(185,62) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var prop in obj.MInfo.PublicProperties)
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    #line (186,18)-(186,47) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    var slot = obj.MGetSlot(prop);
                    #line hidden
                    
                    var __first27 = true;
                    #line (187,18)-(187,54) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    if (slot != null && !slot.IsDefault)
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
                        }
                        var __first28 = true;
                        #line (188,22)-(188,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        if (prop.IsCollection)
                        #line hidden
                        
                        {
                            if (__first28)
                            {
                                __first28 = false;
                            }
                            var __first29 = true;
                            #line (189,26)-(189,60) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                            foreach (var value in slot.Values)
                            #line hidden
                            
                            {
                                if (__first29)
                                {
                                    __first29 = false;
                                }
                                __cb.Push("        ");
                                #line (190,30)-(190,42) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                                __cb.Write(GetName(obj));
                                #line hidden
                                #line (190,43)-(190,44) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                                __cb.Write(".");
                                #line hidden
                                #line (190,45)-(190,54) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (190,55)-(190,60) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                                __cb.Write(".Add(");
                                #line hidden
                                #line (190,61)-(190,92) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                                __cb.Write(ToCSharpValue(prop.Type, value));
                                #line hidden
                                #line (190,93)-(190,95) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                            }
                            if (!__first29) __cb.AppendLine();
                        }
                        #line (192,22)-(192,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        else if (!prop.IsReadOnly)
                        #line hidden
                        
                        {
                            if (__first28)
                            {
                                __first28 = false;
                            }
                            __cb.Push("        ");
                            #line (193,26)-(193,38) 40 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                            __cb.Write(GetName(obj));
                            #line hidden
                            #line (193,39)-(193,40) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                            __cb.Write(".");
                            #line hidden
                            #line (193,41)-(193,50) 40 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (193,51)-(193,52) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (193,52)-(193,53) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (193,53)-(193,54) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (193,55)-(193,103) 40 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                            __cb.Write(ToCSharpValue(prop.Type, slot.AsSingle()?.Value));
                            #line hidden
                            #line (193,104)-(193,105) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
            #line (198,9)-(198,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_model.IsSealed");
            #line hidden
            #line (198,24)-(198,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,25)-(198,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (198,26)-(198,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,27)-(198,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (199,5)-(199,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (201,5)-(201,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (201,11)-(201,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,12)-(201,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (201,20)-(201,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,21)-(201,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (201,27)-(201,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,28)-(201,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MName");
            #line hidden
            #line (201,33)-(201,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,34)-(201,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (201,36)-(201,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,37)-(201,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("nameof(");
            #line hidden
            #line (201,45)-(201,52) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (201,53)-(201,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (202,5)-(202,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (202,11)-(202,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,12)-(202,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (202,20)-(202,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,21)-(202,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (202,27)-(202,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,28)-(202,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MNamespace");
            #line hidden
            #line (202,38)-(202,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,39)-(202,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (202,41)-(202,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,42)-(202,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (202,44)-(202,53) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (202,54)-(202,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (203,5)-(203,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (203,11)-(203,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,12)-(203,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (203,20)-(203,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,21)-(203,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelVersion");
            #line hidden
            #line (203,35)-(203,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,36)-(203,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MVersion");
            #line hidden
            #line (203,44)-(203,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,45)-(203,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (203,47)-(203,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,48)-(203,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("default;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (204,5)-(204,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (204,11)-(204,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,12)-(204,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (204,20)-(204,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,21)-(204,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (204,27)-(204,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,28)-(204,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MUri");
            #line hidden
            #line (204,32)-(204,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,33)-(204,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (204,35)-(204,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,36)-(204,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (204,38)-(204,49) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.FullName);
            #line hidden
            #line (204,50)-(204,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (205,5)-(205,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (205,11)-(205,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,12)-(205,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (205,20)-(205,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,21)-(205,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (205,27)-(205,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,28)-(205,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MPrefix");
            #line hidden
            #line (205,35)-(205,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,36)-(205,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (205,38)-(205,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,39)-(205,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (205,41)-(205,120) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(string.Concat(mm.Name.Where(c => char.IsUpper(c)).Select(c => char.ToLower(c))));
            #line hidden
            #line (205,121)-(205,123) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (206,5)-(206,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (206,11)-(206,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,12)-(206,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (206,20)-(206,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,21)-(206,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (206,28)-(206,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,29)-(206,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MModel");
            #line hidden
            #line (206,35)-(206,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,36)-(206,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (206,38)-(206,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,39)-(206,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_model;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (208,5)-(208,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (208,11)-(208,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,12)-(208,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (208,20)-(208,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,21)-(208,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (208,89)-(208,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,90)-(208,106) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (208,106)-(208,107) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,107)-(208,123) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MEnumInfosByType");
            #line hidden
            #line (208,123)-(208,124) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,124)-(208,126) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (208,126)-(208,127) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,127)-(208,144) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByType;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (209,5)-(209,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (209,11)-(209,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,12)-(209,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (209,20)-(209,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,21)-(209,85) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (209,85)-(209,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,86)-(209,102) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (209,102)-(209,103) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,103)-(209,119) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MEnumInfosByName");
            #line hidden
            #line (209,119)-(209,120) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,120)-(209,122) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (209,122)-(209,123) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,123)-(209,140) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (210,5)-(210,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (210,11)-(210,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,12)-(210,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (210,20)-(210,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,21)-(210,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (210,89)-(210,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,90)-(210,107) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (210,107)-(210,108) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,108)-(210,125) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MClassInfosByType");
            #line hidden
            #line (210,125)-(210,126) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,126)-(210,128) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (210,128)-(210,129) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,129)-(210,147) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_classInfosByType;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (211,5)-(211,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (211,11)-(211,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,12)-(211,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (211,20)-(211,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,21)-(211,85) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (211,85)-(211,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,86)-(211,103) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (211,103)-(211,104) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,104)-(211,121) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MClassInfosByName");
            #line hidden
            #line (211,121)-(211,122) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,122)-(211,124) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (211,124)-(211,125) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,125)-(211,143) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_classInfosByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (213,5)-(213,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (213,11)-(213,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,12)-(213,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (213,20)-(213,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,21)-(213,84) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (213,84)-(213,85) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,85)-(213,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MEnumTypes");
            #line hidden
            #line (213,95)-(213,96) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,96)-(213,98) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (213,98)-(213,99) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,99)-(213,110) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_enumTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (214,5)-(214,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (214,11)-(214,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,12)-(214,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (214,20)-(214,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,21)-(214,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo>");
            #line hidden
            #line (214,89)-(214,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,90)-(214,100) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MEnumInfos");
            #line hidden
            #line (214,100)-(214,101) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,101)-(214,103) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (214,103)-(214,104) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,104)-(214,115) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_enumInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (215,5)-(215,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (215,11)-(215,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,12)-(215,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (215,20)-(215,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,21)-(215,84) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (215,84)-(215,85) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,85)-(215,96) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MClassTypes");
            #line hidden
            #line (215,96)-(215,97) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,97)-(215,99) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (215,99)-(215,100) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,100)-(215,112) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_classTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (216,5)-(216,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (216,11)-(216,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,12)-(216,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (216,20)-(216,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,21)-(216,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (216,90)-(216,91) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,91)-(216,102) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MClassInfos");
            #line hidden
            #line (216,102)-(216,103) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,103)-(216,105) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (216,105)-(216,106) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,106)-(216,118) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_classInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first30 = true;
            #line (218,6)-(218,70) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var c in mm.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                __cb.Push("    ");
                #line (219,10)-(219,26) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (219,27)-(219,28) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (219,28)-(219,29) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("I");
                #line hidden
                #line (219,30)-(219,37) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (219,38)-(219,39) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (219,40)-(219,46) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (219,47)-(219,48) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (219,48)-(219,50) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (219,50)-(219,51) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (219,51)-(219,52) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (219,53)-(219,73) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(c.Name.ToCamelCase());
                #line hidden
                #line (219,74)-(219,75) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first30) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first31 = true;
            #line (222,6)-(222,70) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var c in mm.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first31)
                {
                    __first31 = false;
                }
                __cb.Push("    ");
                #line (223,9)-(223,15) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (223,15)-(223,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,16)-(223,22) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (223,22)-(223,23) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,24)-(223,40) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (223,41)-(223,42) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,43)-(223,49) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (223,50)-(223,51) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,51)-(223,53) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (223,53)-(223,54) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,54)-(223,57) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("((I");
                #line hidden
                #line (223,58)-(223,65) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (223,66)-(223,77) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(")Instance).");
                #line hidden
                #line (223,78)-(223,84) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (223,85)-(223,86) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first31) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first32 = true;
            #line (226,6)-(226,32) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                __cb.Push("    ");
                #line (227,9)-(227,15) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (227,15)-(227,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (227,16)-(227,22) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (227,22)-(227,23) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (227,23)-(227,38) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("__ModelEnumInfo");
                #line hidden
                #line (227,38)-(227,39) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (227,40)-(227,48) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (227,49)-(227,53) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
                #line (227,53)-(227,54) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (227,54)-(227,56) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (227,56)-(227,57) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (227,57)-(227,66) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("__Impl.__");
                #line hidden
                #line (227,67)-(227,75) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (227,76)-(227,91) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("_Info.Instance;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first32) __cb.AppendLine();
            var __first33 = true;
            #line (229,6)-(229,34) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("    ");
                #line (230,9)-(230,15) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (230,15)-(230,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (230,16)-(230,22) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (230,22)-(230,23) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (230,23)-(230,39) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("__ModelClassInfo");
                #line hidden
                #line (230,39)-(230,40) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (230,41)-(230,49) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (230,50)-(230,54) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
                #line (230,54)-(230,55) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (230,55)-(230,57) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (230,57)-(230,58) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (230,58)-(230,65) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("__Impl.");
                #line hidden
                #line (230,66)-(230,74) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (230,75)-(230,97) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("_Impl.__Info.Instance;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first34 = true;
                #line (231,6)-(231,42) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties)
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
                    }
                    __cb.Push("    ");
                    #line (232,9)-(232,15) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (232,15)-(232,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (232,16)-(232,22) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (232,22)-(232,23) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (232,23)-(232,38) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (232,38)-(232,39) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (232,40)-(232,48) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (232,49)-(232,50) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (232,51)-(232,60) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (232,61)-(232,62) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (232,62)-(232,64) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (232,64)-(232,65) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (232,65)-(232,66) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (232,67)-(232,75) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (232,76)-(232,77) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (232,78)-(232,87) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (232,88)-(232,89) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first34) __cb.AppendLine();
                var __first35 = true;
                #line (234,6)-(234,40) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    __cb.Push("    ");
                    #line (235,9)-(235,15) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (235,15)-(235,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (235,16)-(235,22) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (235,22)-(235,23) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (235,23)-(235,39) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation");
                    #line hidden
                    #line (235,39)-(235,40) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (235,41)-(235,49) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (235,50)-(235,51) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (235,52)-(235,59) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (235,60)-(235,61) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (235,61)-(235,63) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (235,63)-(235,64) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (235,64)-(235,65) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (235,66)-(235,74) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (235,75)-(235,76) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (235,77)-(235,84) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (235,85)-(235,86) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first35) __cb.AppendLine();
            }
            if (!__first33) __cb.AppendLine();
            __cb.Push("");
            #line (238,1)-(238,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (241,9)-(241,39) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
        public string GenerateFactory(MetaModel mm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (242,1)-(242,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (242,7)-(242,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (242,8)-(242,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (242,13)-(242,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (242,15)-(242,22) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (242,23)-(242,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("ModelFactory");
            #line hidden
            #line (242,35)-(242,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (242,36)-(242,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (242,37)-(242,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (242,38)-(242,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (243,1)-(243,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (244,5)-(244,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (244,11)-(244,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (244,13)-(244,20) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (244,21)-(244,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(__Model");
            #line hidden
            #line (244,41)-(244,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (244,42)-(244,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("model)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (245,9)-(245,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (245,10)-(245,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (245,11)-(245,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("base(model,");
            #line hidden
            #line (245,22)-(245,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (245,24)-(245,31) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (245,32)-(245,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(".MInstance)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (246,5)-(246,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (247,5)-(247,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first36 = true;
            #line (249,6)-(249,60) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes.Where(c => !c.IsAbstract))
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("    ");
                #line (250,9)-(250,15) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (250,15)-(250,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (250,17)-(250,30) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (250,31)-(250,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (250,33)-(250,41) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (250,42)-(250,50) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("(string?");
                #line hidden
                #line (250,50)-(250,51) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (250,51)-(250,53) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("id");
                #line hidden
                #line (250,53)-(250,54) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (250,54)-(250,55) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (250,55)-(250,56) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (250,56)-(250,61) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (251,9)-(251,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (252,13)-(252,19) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (252,19)-(252,20) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (252,20)-(252,21) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (252,22)-(252,35) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (252,36)-(252,37) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (252,38)-(252,45) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (252,46)-(252,47) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (252,48)-(252,56) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (252,57)-(252,75) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("Info.Create(Model,");
                #line hidden
                #line (252,75)-(252,76) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (252,76)-(252,81) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("id)!;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (253,9)-(253,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first36) __cb.AppendLine();
            __cb.Push("");
            #line (256,1)-(256,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (258,1)-(258,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (258,7)-(258,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,8)-(258,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (258,13)-(258,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,15)-(258,22) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (258,23)-(258,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("ModelMultiFactory");
            #line hidden
            #line (258,40)-(258,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,41)-(258,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (258,42)-(258,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,43)-(258,62) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MultiModelFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (259,1)-(259,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (260,5)-(260,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (260,11)-(260,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,13)-(260,20) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (260,21)-(260,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("ModelMultiFactory()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (261,9)-(261,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (261,10)-(261,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,11)-(261,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("base(new");
            #line hidden
            #line (261,19)-(261,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,20)-(261,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (261,32)-(261,36) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (261,37)-(261,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,38)-(261,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (261,39)-(261,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,41)-(261,48) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (261,49)-(261,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(".MInstance");
            #line hidden
            #line (261,59)-(261,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,60)-(261,62) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("})");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (262,5)-(262,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (263,5)-(263,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first37 = true;
            #line (265,6)-(265,60) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes.Where(c => !c.IsAbstract))
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.Push("    ");
                #line (266,9)-(266,15) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (266,15)-(266,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (266,17)-(266,30) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (266,31)-(266,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (266,33)-(266,41) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (266,42)-(266,50) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("(__Model");
                #line hidden
                #line (266,50)-(266,51) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (266,51)-(266,57) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("model,");
                #line hidden
                #line (266,57)-(266,58) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (266,58)-(266,65) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("string?");
                #line hidden
                #line (266,65)-(266,66) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (266,66)-(266,68) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("id");
                #line hidden
                #line (266,68)-(266,69) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (266,69)-(266,70) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (266,70)-(266,71) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (266,71)-(266,76) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (267,9)-(267,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (268,13)-(268,19) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (268,19)-(268,20) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (268,20)-(268,21) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (268,22)-(268,35) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (268,36)-(268,37) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (268,38)-(268,45) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (268,46)-(268,47) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (268,48)-(268,56) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (268,57)-(268,75) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("Info.Create(model,");
                #line hidden
                #line (268,75)-(268,76) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (268,76)-(268,81) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("id)!;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (269,9)-(269,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first37) __cb.AppendLine();
            __cb.Push("");
            #line (272,1)-(272,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (276,9)-(276,50) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
        public string GenerateEnum(MetaModel mm, MetaEnum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (277,1)-(277,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (277,7)-(277,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,8)-(277,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("enum");
            #line hidden
            #line (277,12)-(277,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,14)-(277,22) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (278,1)-(278,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first38 = true;
            #line (279,6)-(279,39) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals)
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("    ");
                #line (280,10)-(280,18) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (280,19)-(280,20) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first38) __cb.AppendLine();
            __cb.Push("");
            #line (282,1)-(282,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (285,9)-(285,54) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
        public string GenerateEnumInfo(MetaModel mm, MetaEnum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (286,1)-(286,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (286,9)-(286,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,10)-(286,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (286,15)-(286,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,16)-(286,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (286,19)-(286,27) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (286,28)-(286,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_Info");
            #line hidden
            #line (286,33)-(286,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,34)-(286,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (286,35)-(286,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,36)-(286,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (287,1)-(287,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (288,5)-(288,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (288,11)-(288,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (288,12)-(288,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (288,18)-(288,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (288,19)-(288,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (288,27)-(288,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (288,28)-(288,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (288,31)-(288,39) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (288,40)-(288,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_Info");
            #line hidden
            #line (288,45)-(288,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (288,46)-(288,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (288,54)-(288,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (288,55)-(288,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (288,56)-(288,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (288,57)-(288,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (288,60)-(288,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (288,61)-(288,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (288,64)-(288,72) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (288,73)-(288,81) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_Info();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (290,5)-(290,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (290,12)-(290,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (290,13)-(290,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (290,21)-(290,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (290,22)-(290,81) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<string>");
            #line hidden
            #line (290,81)-(290,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (290,82)-(290,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_literals;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (291,5)-(291,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (291,12)-(291,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,13)-(291,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (291,21)-(291,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,22)-(291,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (291,86)-(291,87) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,87)-(291,100) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>");
            #line hidden
            #line (291,100)-(291,101) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,101)-(291,117) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_literalsByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (293,5)-(293,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (293,12)-(293,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (293,13)-(293,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (293,16)-(293,24) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (293,25)-(293,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_Info()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (294,5)-(294,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (295,9)-(295,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_literals");
            #line hidden
            #line (295,18)-(295,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,19)-(295,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (295,20)-(295,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,21)-(295,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<string>(");
            #line hidden
            var __first39 = true;
            #line (295,54)-(295,88) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (295,98)-(295,102) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (295,104)-(295,142) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(StringUtilities.EncodeString(lit.Name));
                #line hidden
            }
            #line (295,156)-(295,158) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (296,9)-(296,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (296,12)-(296,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,13)-(296,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("literalsByName");
            #line hidden
            #line (296,27)-(296,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,28)-(296,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (296,29)-(296,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,30)-(296,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (296,73)-(296,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,74)-(296,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first40 = true;
            #line (297,10)-(297,43) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals)
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                __cb.Push("        ");
                #line (298,13)-(298,33) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("literalsByName.Add(\"");
                #line hidden
                #line (298,34)-(298,42) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (298,43)-(298,45) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (298,45)-(298,46) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (298,46)-(298,69) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("__MetaSymbol.FromValue(");
                #line hidden
                #line (298,70)-(298,78) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (298,79)-(298,80) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (298,81)-(298,89) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (298,90)-(298,93) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first40) __cb.AppendLine();
            __cb.Push("        ");
            #line (300,9)-(300,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_literalsByName");
            #line hidden
            #line (300,24)-(300,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (300,25)-(300,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (300,26)-(300,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (300,27)-(300,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("literalsByName.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (301,5)-(301,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (303,5)-(303,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (303,11)-(303,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,12)-(303,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (303,20)-(303,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,21)-(303,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (303,32)-(303,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,33)-(303,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MetaModel");
            #line hidden
            #line (303,42)-(303,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,43)-(303,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (303,45)-(303,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,47)-(303,54) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (303,55)-(303,66) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(".MInstance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (304,5)-(304,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (304,11)-(304,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,12)-(304,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (304,20)-(304,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,21)-(304,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (304,31)-(304,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,32)-(304,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MetaType");
            #line hidden
            #line (304,40)-(304,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,41)-(304,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (304,43)-(304,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,44)-(304,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (304,52)-(304,60) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (304,61)-(304,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (305,5)-(305,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (305,11)-(305,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,12)-(305,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (305,20)-(305,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,21)-(305,80) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<string>");
            #line hidden
            #line (305,80)-(305,81) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,81)-(305,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Literals");
            #line hidden
            #line (305,89)-(305,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,90)-(305,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (305,92)-(305,93) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,93)-(305,103) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_literals;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (306,5)-(306,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (306,14)-(306,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,15)-(306,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (306,23)-(306,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,24)-(306,88) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (306,88)-(306,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,89)-(306,102) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>");
            #line hidden
            #line (306,102)-(306,103) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,103)-(306,117) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("LiteralsByName");
            #line hidden
            #line (306,117)-(306,118) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,118)-(306,120) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (306,120)-(306,121) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,121)-(306,137) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_literalsByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (307,1)-(307,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (310,9)-(310,56) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
        public string GenerateInterface(MetaModel mm, MetaClass cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (311,2)-(311,119) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
            #line hidden
            
            #line (312,1)-(312,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (312,7)-(312,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,8)-(312,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (312,17)-(312,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,19)-(312,27) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            var __first41 = true;
            #line (312,29)-(312,53) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            if (cls.BaseTypes.Any())
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                #line (312,54)-(312,55) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (312,55)-(312,56) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (312,56)-(312,57) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first42 = true;
                #line (312,58)-(312,92) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                        #line (312,102)-(312,106) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (312,107)-(312,115) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("global::");
                    #line hidden
                    #line (312,116)-(312,127) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(bt.FullName);
                    #line hidden
                }
            }
            #line (312,142)-(312,146) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                #line (312,147)-(312,148) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (312,148)-(312,149) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (312,149)-(312,150) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (312,150)-(312,164) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("__IModelObject");
                #line hidden
            }
            if (!__first41) __cb.AppendLine();
            __cb.Push("");
            #line (313,1)-(313,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first43 = true;
            #line (314,6)-(314,54) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var prop in metaCls.DeclaredProperties)
            #line hidden
            
            {
                if (__first43)
                {
                    __first43 = false;
                }
                #line (315,10)-(315,53) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                __cb.Push("    ");
                var __first44 = true;
                #line (316,10)-(316,47) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                if (info.HiddenProperties.Length > 0)
                #line hidden
                
                {
                    if (__first44)
                    {
                        __first44 = false;
                    }
                    #line (316,48)-(316,51) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (316,51)-(316,52) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (316,61)-(316,182) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                #line hidden
                #line (316,183)-(316,184) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (316,185)-(316,194) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (316,195)-(316,196) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (316,196)-(316,197) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (316,197)-(316,198) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (316,198)-(316,202) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (316,202)-(316,203) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first45 = true;
                #line (316,204)-(316,224) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                if (HasSetter(prop))
                #line hidden
                
                {
                    if (__first45)
                    {
                        __first45 = false;
                    }
                    #line (316,225)-(316,229) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("set;");
                    #line hidden
                    #line (316,229)-(316,230) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (316,238)-(316,239) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first43) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first46 = true;
            #line (319,6)-(319,40) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var op in cls.Operations)
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                __cb.Push("    ");
                #line (320,10)-(320,33) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op.ReturnType));
                #line hidden
                #line (320,34)-(320,35) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (320,36)-(320,43) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (320,44)-(320,45) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first47 = true;
                #line (320,46)-(320,83) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                        #line (320,93)-(320,97) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (320,99)-(320,119) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(param.Type));
                    #line hidden
                    #line (320,120)-(320,121) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (320,122)-(320,132) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (320,146)-(320,148) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first46) __cb.AppendLine();
            __cb.Push("");
            #line (322,1)-(322,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (325,9)-(325,52) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
        public string GenerateClass(MetaModel mm, MetaClass cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (326,2)-(326,119) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
            #line hidden
            
            __cb.Push("");
            #line (327,1)-(327,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (327,9)-(327,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,10)-(327,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (327,15)-(327,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,17)-(327,25) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (327,26)-(327,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_Impl");
            #line hidden
            #line (327,31)-(327,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,32)-(327,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (327,33)-(327,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,34)-(327,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaModelObject,");
            #line hidden
            #line (327,52)-(327,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,54)-(327,62) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (328,1)-(328,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (329,5)-(329,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (329,12)-(329,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,14)-(329,22) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (329,23)-(329,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_Impl(string?");
            #line hidden
            #line (329,36)-(329,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,37)-(329,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("id)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (330,9)-(330,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (330,10)-(330,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,11)-(330,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("base(id)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (331,5)-(331,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first48 = true;
            #line (332,10)-(332,45) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var slot in metaCls.Slots)
            #line hidden
            
            {
                if (__first48)
                {
                    __first48 = false;
                }
                var __first49 = true;
                #line (333,14)-(333,44) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                if (!slot.DefaultValue.IsDefaultOrNull)
                #line hidden
                
                {
                    if (__first49)
                    {
                        __first49 = false;
                    }
                    __cb.Push("        ");
                    #line (334,17)-(334,45) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("((__IModelObject)this).Init(");
                    #line hidden
                    #line (334,46)-(334,73) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(slot.SlotProperty));
                    #line hidden
                    #line (334,74)-(334,75) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (334,75)-(334,76) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (334,76)-(334,77) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (334,78)-(334,110) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(slot.SlotProperty.Type));
                    #line hidden
                    #line (334,111)-(334,112) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (334,113)-(334,169) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpValue(slot.SlotProperty.Type, slot.DefaultValue));
                    #line hidden
                    #line (334,170)-(334,172) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first49) __cb.AppendLine();
            }
            if (!__first48) __cb.AppendLine();
            var __first50 = true;
            #line (337,10)-(337,66) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var baseType in metaCls.AllBaseTypes.Reverse())
            #line hidden
            
            {
                if (__first50)
                {
                    __first50 = false;
                }
                __cb.Push("        ");
                #line (338,14)-(338,21) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (338,22)-(338,36) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(".__CustomImpl.");
                #line hidden
                #line (338,37)-(338,50) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(baseType.Name);
                #line hidden
                #line (338,51)-(338,58) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("(this);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first50) __cb.AppendLine();
            __cb.Push("        ");
            #line (340,10)-(340,17) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (340,18)-(340,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(".__CustomImpl.");
            #line hidden
            #line (340,33)-(340,41) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (340,42)-(340,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (341,5)-(341,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (343,5)-(343,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (343,11)-(343,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (343,12)-(343,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (343,20)-(343,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (343,21)-(343,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            #line (343,37)-(343,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (343,38)-(343,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MInfo");
            #line hidden
            #line (343,43)-(343,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (343,44)-(343,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (343,46)-(343,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (343,47)-(343,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Info.Instance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first51 = true;
            #line (345,6)-(345,57) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties)
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                #line (346,10)-(346,53) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                var __first52 = true;
                #line (347,10)-(347,54) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                if (metaCls.PublicProperties.Contains(prop))
                #line hidden
                
                {
                    if (__first52)
                    {
                        __first52 = false;
                    }
                    __cb.Push("    ");
                    #line (348,13)-(348,19) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (348,19)-(348,20) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (348,21)-(348,142) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (348,143)-(348,144) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (348,145)-(348,154) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (349,10)-(349,14) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first52)
                    {
                        __first52 = false;
                    }
                    __cb.Push("    ");
                    #line (350,14)-(350,17) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (350,18)-(350,119) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)");
                    #line hidden
                    #line (350,120)-(350,123) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (351,14)-(351,135) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (351,136)-(351,137) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (351,138)-(351,181) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.DeclaringType.UnderlyingType));
                    #line hidden
                    #line (351,182)-(351,183) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (351,184)-(351,193) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first52) __cb.AppendLine();
                __cb.Push("    ");
                #line (353,9)-(353,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first53 = true;
                #line (354,14)-(354,52) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                if (prop.UnderlyingProperty.IsDerived)
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    #line (355,18)-(355,81) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    var actualProp = info.HidingProperties.FirstOrDefault() ?? prop;
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (356,17)-(356,20) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (356,20)-(356,21) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (356,21)-(356,23) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (356,23)-(356,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (356,25)-(356,32) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(mm.Name);
                    #line hidden
                    #line (356,33)-(356,47) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(".__CustomImpl.");
                    #line hidden
                    #line (356,48)-(356,77) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(actualProp.DeclaringType.Name);
                    #line hidden
                    #line (356,78)-(356,79) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (356,80)-(356,95) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(actualProp.Name);
                    #line hidden
                    #line (356,96)-(356,103) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("(this);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (357,14)-(357,41) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                else if (prop.IsCollection)
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("        ");
                    #line (358,17)-(358,20) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (358,20)-(358,21) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (358,21)-(358,23) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (358,23)-(358,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (358,24)-(358,39) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("MGetCollection<");
                    #line hidden
                    #line (358,40)-(358,59) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Type));
                    #line hidden
                    #line (358,60)-(358,62) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(">(");
                    #line hidden
                    #line (358,63)-(358,77) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop));
                    #line hidden
                    #line (358,78)-(358,80) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (359,14)-(359,18) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("        ");
                    #line (360,17)-(360,20) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (360,20)-(360,21) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (360,21)-(360,23) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (360,23)-(360,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (360,24)-(360,29) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("MGet<");
                    #line hidden
                    #line (360,30)-(360,68) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (360,69)-(360,71) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(">(");
                    #line hidden
                    #line (360,72)-(360,86) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop));
                    #line hidden
                    #line (360,87)-(360,89) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    var __first54 = true;
                    #line (361,18)-(361,38) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    if (HasSetter(prop))
                    #line hidden
                    
                    {
                        if (__first54)
                        {
                            __first54 = false;
                        }
                        __cb.Push("        ");
                        #line (362,21)-(362,24) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write("set");
                        #line hidden
                        #line (362,24)-(362,25) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (362,25)-(362,27) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (362,27)-(362,28) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (362,28)-(362,33) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write("MSet<");
                        #line hidden
                        #line (362,34)-(362,72) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(ToCSharp(prop.UnderlyingProperty.Type));
                        #line hidden
                        #line (362,73)-(362,75) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(">(");
                        #line hidden
                        #line (362,76)-(362,90) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(ToCSharp(prop));
                        #line hidden
                        #line (362,91)-(362,92) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (362,92)-(362,93) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (362,93)-(362,100) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write("value);");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first54) __cb.AppendLine();
                }
                if (!__first53) __cb.AppendLine();
                __cb.Push("    ");
                #line (365,9)-(365,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first51) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first55 = true;
            #line (369,6)-(369,55) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations)
            #line hidden
            
            {
                if (__first55)
                {
                    __first55 = false;
                }
                #line (370,10)-(370,52) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                var info = metaCls.ModelOperationInfos[op];
                #line hidden
                
                #line (371,10)-(371,73) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                var actualOp = info.OverridingOperations.FirstOrDefault() ?? op;
                #line hidden
                
                __cb.Push("    ");
                #line (372,10)-(372,59) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharpOpType(op.UnderlyingOperation.ReturnType));
                #line hidden
                #line (372,60)-(372,61) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (372,62)-(372,103) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op.DeclaringType.UnderlyingType));
                #line hidden
                #line (372,104)-(372,105) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (372,106)-(372,113) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (372,114)-(372,115) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first56 = true;
                #line (372,116)-(372,173) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                        #line (372,183)-(372,187) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (372,189)-(372,215) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(param.Type));
                    #line hidden
                    #line (372,216)-(372,217) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (372,218)-(372,228) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (372,242)-(372,243) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (372,243)-(372,244) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (372,244)-(372,246) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (372,246)-(372,247) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (372,248)-(372,255) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (372,256)-(372,270) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(".__CustomImpl.");
                #line hidden
                #line (372,271)-(372,298) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(actualOp.DeclaringType.Name);
                #line hidden
                #line (372,299)-(372,300) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (372,301)-(372,314) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(actualOp.Name);
                #line hidden
                #line (372,315)-(372,320) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("(this");
                #line hidden
                var __first57 = true;
                #line (372,321)-(372,383) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var param in actualOp.UnderlyingOperation.Parameters)
                #line hidden
                
                {
                    if (__first57)
                    {
                        __first57 = false;
                    }
                    #line (372,384)-(372,385) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (372,385)-(372,386) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (372,387)-(372,397) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (372,411)-(372,413) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first55) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (375,5)-(375,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (375,13)-(375,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,14)-(375,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (375,19)-(375,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,20)-(375,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Info");
            #line hidden
            #line (375,26)-(375,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,27)-(375,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (375,28)-(375,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,29)-(375,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (376,5)-(376,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (377,9)-(377,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (377,15)-(377,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,16)-(377,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (377,22)-(377,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,23)-(377,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (377,31)-(377,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,32)-(377,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Info");
            #line hidden
            #line (377,38)-(377,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,39)-(377,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (377,47)-(377,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,48)-(377,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (377,49)-(377,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,50)-(377,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (377,53)-(377,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,54)-(377,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Info();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (379,9)-(379,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (379,16)-(379,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,17)-(379,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (379,25)-(379,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,26)-(379,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (379,95)-(379,96) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,96)-(379,107) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_baseTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (380,9)-(380,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (380,16)-(380,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (380,17)-(380,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (380,25)-(380,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (380,26)-(380,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (380,95)-(380,96) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (380,96)-(380,110) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (381,9)-(381,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (381,16)-(381,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (381,17)-(381,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (381,25)-(381,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (381,26)-(381,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (381,94)-(381,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (381,95)-(381,115) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (382,9)-(382,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (382,16)-(382,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,17)-(382,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (382,25)-(382,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,26)-(382,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (382,94)-(382,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,95)-(382,118) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (383,9)-(383,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (383,16)-(383,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,17)-(383,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (383,25)-(383,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,26)-(383,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (383,94)-(383,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,95)-(383,113) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_publicProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (384,9)-(384,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (384,16)-(384,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,17)-(384,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (384,25)-(384,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,26)-(384,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (384,90)-(384,91) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,91)-(384,107) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>");
            #line hidden
            #line (384,107)-(384,108) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,108)-(384,132) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (385,9)-(385,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (385,16)-(385,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,17)-(385,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (385,25)-(385,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,26)-(385,99) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty,");
            #line hidden
            #line (385,99)-(385,100) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,100)-(385,120) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>");
            #line hidden
            #line (385,120)-(385,121) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,121)-(385,141) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (386,9)-(386,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (386,16)-(386,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (386,17)-(386,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (386,25)-(386,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (386,26)-(386,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (386,95)-(386,96) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (386,96)-(386,116) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (387,9)-(387,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (387,16)-(387,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,17)-(387,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (387,25)-(387,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,26)-(387,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (387,95)-(387,96) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,96)-(387,119) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (388,9)-(388,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (388,16)-(388,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,17)-(388,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (388,25)-(388,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,26)-(388,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (388,95)-(388,96) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,96)-(388,114) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_publicOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (389,9)-(389,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (389,16)-(389,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (389,17)-(389,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (389,25)-(389,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (389,26)-(389,100) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation,");
            #line hidden
            #line (389,100)-(389,101) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (389,101)-(389,122) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>");
            #line hidden
            #line (389,122)-(389,123) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (389,123)-(389,144) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (391,9)-(391,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (391,16)-(391,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,17)-(391,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__Info()");
            #line hidden
            #line (391,25)-(391,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (392,9)-(392,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (393,13)-(393,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_baseTypes");
            #line hidden
            #line (393,23)-(393,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (393,24)-(393,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (393,25)-(393,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (393,26)-(393,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first58 = true;
            #line (393,69)-(393,107) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (393,117)-(393,121) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (393,123)-(393,135) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(bt));
                #line hidden
            }
            #line (393,149)-(393,151) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (394,13)-(394,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes");
            #line hidden
            #line (394,26)-(394,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (394,27)-(394,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (394,28)-(394,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (394,29)-(394,71) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first59 = true;
            #line (394,72)-(394,113) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (394,123)-(394,127) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (394,129)-(394,141) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(bt));
                #line hidden
            }
            #line (394,155)-(394,157) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (395,13)-(395,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties");
            #line hidden
            #line (395,32)-(395,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,33)-(395,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (395,34)-(395,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,35)-(395,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first60 = true;
            #line (395,77)-(395,126) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (395,136)-(395,140) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (395,142)-(395,156) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (395,170)-(395,172) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (396,13)-(396,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties");
            #line hidden
            #line (396,35)-(396,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (396,36)-(396,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (396,37)-(396,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (396,38)-(396,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first61 = true;
            #line (396,80)-(396,132) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (396,142)-(396,146) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (396,148)-(396,162) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (396,176)-(396,178) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (397,13)-(397,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_publicProperties");
            #line hidden
            #line (397,30)-(397,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,31)-(397,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (397,32)-(397,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,33)-(397,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first62 = true;
            #line (397,75)-(397,122) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (397,132)-(397,136) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (397,138)-(397,152) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (397,166)-(397,168) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (398,13)-(398,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (398,16)-(398,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (398,17)-(398,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("publicPropertiesByName");
            #line hidden
            #line (398,39)-(398,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (398,40)-(398,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (398,41)-(398,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (398,42)-(398,85) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (398,85)-(398,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (398,86)-(398,105) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first63 = true;
            #line (399,14)-(399,60) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var prop in metaCls.PublicProperties)
            #line hidden
            
            {
                if (__first63)
                {
                    __first63 = false;
                }
                __cb.Push("            ");
                #line (400,17)-(400,45) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("publicPropertiesByName.Add(\"");
                #line hidden
                #line (400,46)-(400,55) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (400,56)-(400,58) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (400,58)-(400,59) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (400,60)-(400,74) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
                #line (400,75)-(400,77) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first63) __cb.AppendLine();
            __cb.Push("            ");
            #line (402,13)-(402,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName");
            #line hidden
            #line (402,36)-(402,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (402,37)-(402,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (402,38)-(402,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (402,39)-(402,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("publicPropertiesByName.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (403,13)-(403,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (403,16)-(403,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (403,17)-(403,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("modelPropertyInfos");
            #line hidden
            #line (403,35)-(403,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (403,36)-(403,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (403,37)-(403,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (403,38)-(403,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__ModelProperty,");
            #line hidden
            #line (403,90)-(403,91) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (403,91)-(403,114) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first64 = true;
            #line (404,14)-(404,65) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties)
            #line hidden
            
            {
                if (__first64)
                {
                    __first64 = false;
                }
                #line (405,18)-(405,61) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                #line (406,18)-(406,38) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                var slot = info.Slot;
                #line hidden
                
                __cb.Push("            ");
                #line (407,17)-(407,40) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("modelPropertyInfos.Add(");
                #line hidden
                #line (407,41)-(407,55) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
                #line (407,56)-(407,57) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (407,57)-(407,58) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,58)-(407,61) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (407,61)-(407,62) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,62)-(407,85) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("__ModelPropertyInfo(new");
                #line hidden
                #line (407,85)-(407,86) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,86)-(407,106) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("__ModelPropertySlot(");
                #line hidden
                #line (407,107)-(407,134) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.SlotProperty));
                #line hidden
                #line (407,135)-(407,136) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (407,136)-(407,137) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,138)-(407,167) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.SlotProperties));
                #line hidden
                #line (407,168)-(407,169) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (407,169)-(407,170) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,170)-(407,175) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("null,");
                #line hidden
                #line (407,175)-(407,176) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,177)-(407,197) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.Flags));
                #line hidden
                #line (407,198)-(407,200) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (407,200)-(407,201) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,202)-(407,235) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OppositeProperties));
                #line hidden
                #line (407,236)-(407,237) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (407,237)-(407,238) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,239)-(407,273) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.SubsettedProperties));
                #line hidden
                #line (407,274)-(407,275) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (407,275)-(407,276) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,277)-(407,312) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.SubsettingProperties));
                #line hidden
                #line (407,313)-(407,314) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (407,314)-(407,315) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,316)-(407,350) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.RedefinedProperties));
                #line hidden
                #line (407,351)-(407,352) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (407,352)-(407,353) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,354)-(407,389) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.RedefiningProperties));
                #line hidden
                #line (407,390)-(407,391) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (407,391)-(407,392) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,393)-(407,424) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.HiddenProperties));
                #line hidden
                #line (407,425)-(407,426) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (407,426)-(407,427) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,428)-(407,459) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.HidingProperties));
                #line hidden
                #line (407,460)-(407,463) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first64) __cb.AppendLine();
            __cb.Push("            ");
            #line (409,13)-(409,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos");
            #line hidden
            #line (409,32)-(409,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (409,33)-(409,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (409,34)-(409,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (409,35)-(409,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("modelPropertyInfos.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (411,13)-(411,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations");
            #line hidden
            #line (411,32)-(411,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,33)-(411,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (411,34)-(411,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,35)-(411,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first65 = true;
            #line (411,78)-(411,125) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (411,135)-(411,139) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (411,141)-(411,153) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (411,167)-(411,169) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (412,13)-(412,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations");
            #line hidden
            #line (412,35)-(412,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (412,36)-(412,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (412,37)-(412,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (412,38)-(412,80) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first66 = true;
            #line (412,81)-(412,131) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (412,141)-(412,145) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (412,147)-(412,159) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (412,173)-(412,175) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (413,13)-(413,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_publicOperations");
            #line hidden
            #line (413,30)-(413,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (413,31)-(413,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (413,32)-(413,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (413,33)-(413,75) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first67 = true;
            #line (413,76)-(413,121) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
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
                    #line (413,131)-(413,135) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (413,137)-(413,149) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (413,163)-(413,165) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (414,13)-(414,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (414,16)-(414,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (414,17)-(414,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("modelOperationInfos");
            #line hidden
            #line (414,36)-(414,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (414,37)-(414,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (414,38)-(414,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (414,39)-(414,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__ModelOperation,");
            #line hidden
            #line (414,92)-(414,93) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (414,93)-(414,117) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first68 = true;
            #line (415,14)-(415,63) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations)
            #line hidden
            
            {
                if (__first68)
                {
                    __first68 = false;
                }
                #line (416,14)-(416,56) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                var info = metaCls.ModelOperationInfos[op];
                #line hidden
                
                __cb.Push("                ");
                #line (417,17)-(417,41) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("modelOperationInfos.Add(");
                #line hidden
                #line (417,42)-(417,54) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
                #line (417,55)-(417,56) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (417,56)-(417,57) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (417,57)-(417,60) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (417,60)-(417,61) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (417,61)-(417,82) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("__ModelOperationInfo(");
                #line hidden
                #line (417,83)-(417,117) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OverridenOperations));
                #line hidden
                #line (417,118)-(417,119) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (417,119)-(417,120) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (417,121)-(417,156) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OverridingOperations));
                #line hidden
                #line (417,157)-(417,160) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first68) __cb.AppendLine();
            __cb.Push("            ");
            #line (419,13)-(419,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos");
            #line hidden
            #line (419,33)-(419,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,34)-(419,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (419,35)-(419,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,36)-(419,70) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("modelOperationInfos.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (420,9)-(420,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (422,9)-(422,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (422,15)-(422,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,16)-(422,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (422,24)-(422,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,25)-(422,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (422,36)-(422,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,37)-(422,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MetaModel");
            #line hidden
            #line (422,46)-(422,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,47)-(422,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (422,49)-(422,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,51)-(422,58) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (422,59)-(422,70) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(".MInstance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (423,9)-(423,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (423,15)-(423,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (423,16)-(423,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (423,24)-(423,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (423,25)-(423,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (423,35)-(423,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (423,36)-(423,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("MetaType");
            #line hidden
            #line (423,44)-(423,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (423,45)-(423,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (423,47)-(423,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (423,48)-(423,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (423,56)-(423,64) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (423,65)-(423,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (425,9)-(425,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (425,15)-(425,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (425,16)-(425,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (425,24)-(425,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (425,25)-(425,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (425,35)-(425,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (425,36)-(425,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("SymbolType");
            #line hidden
            #line (425,46)-(425,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (425,47)-(425,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (425,49)-(425,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first69 = true;
            #line (425,51)-(425,82) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            if (metaCls.SymbolType is null)
            #line hidden
            
            {
                if (__first69)
                {
                    __first69 = false;
                }
                #line (425,83)-(425,90) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("default");
                #line hidden
            }
            #line (425,91)-(425,95) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first69)
                {
                    __first69 = false;
                }
                #line (425,96)-(425,103) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (425,104)-(425,132) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.SymbolType));
                #line hidden
                #line (425,133)-(425,134) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (425,142)-(425,143) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (426,9)-(426,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (426,15)-(426,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,16)-(426,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (426,24)-(426,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,25)-(426,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty?");
            #line hidden
            #line (426,41)-(426,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,42)-(426,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("NameProperty");
            #line hidden
            #line (426,54)-(426,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,55)-(426,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (426,57)-(426,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first70 = true;
            #line (426,59)-(426,92) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            if (metaCls.NameProperty is null)
            #line hidden
            
            {
                if (__first70)
                {
                    __first70 = false;
                }
                #line (426,93)-(426,97) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("null");
                #line hidden
            }
            #line (426,98)-(426,102) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first70)
                {
                    __first70 = false;
                }
                #line (426,104)-(426,134) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.NameProperty));
                #line hidden
            }
            #line (426,143)-(426,144) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (427,9)-(427,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (427,15)-(427,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,16)-(427,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (427,24)-(427,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,25)-(427,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty?");
            #line hidden
            #line (427,41)-(427,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,42)-(427,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("TypeProperty");
            #line hidden
            #line (427,54)-(427,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,55)-(427,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (427,57)-(427,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first71 = true;
            #line (427,59)-(427,92) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            if (metaCls.TypeProperty is null)
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                #line (427,93)-(427,97) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("null");
                #line hidden
            }
            #line (427,98)-(427,102) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                #line (427,104)-(427,134) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.TypeProperty));
                #line hidden
            }
            #line (427,143)-(427,144) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (428,9)-(428,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (428,15)-(428,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,16)-(428,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (428,24)-(428,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,25)-(428,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (428,94)-(428,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,95)-(428,104) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("BaseTypes");
            #line hidden
            #line (428,104)-(428,105) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,105)-(428,107) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (428,107)-(428,108) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,108)-(428,119) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_baseTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (429,9)-(429,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (429,15)-(429,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (429,16)-(429,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (429,24)-(429,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (429,25)-(429,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (429,94)-(429,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (429,95)-(429,107) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("AllBaseTypes");
            #line hidden
            #line (429,107)-(429,108) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (429,108)-(429,110) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (429,110)-(429,111) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (429,111)-(429,125) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (430,9)-(430,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (430,15)-(430,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,16)-(430,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (430,24)-(430,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,25)-(430,93) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (430,93)-(430,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,94)-(430,112) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("DeclaredProperties");
            #line hidden
            #line (430,112)-(430,113) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,113)-(430,115) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (430,115)-(430,116) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,116)-(430,136) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (431,9)-(431,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (431,15)-(431,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (431,16)-(431,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (431,24)-(431,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (431,25)-(431,93) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (431,93)-(431,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (431,94)-(431,115) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("AllDeclaredProperties");
            #line hidden
            #line (431,115)-(431,116) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (431,116)-(431,118) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (431,118)-(431,119) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (431,119)-(431,142) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (432,9)-(432,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (432,15)-(432,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,16)-(432,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (432,24)-(432,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,25)-(432,93) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (432,93)-(432,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,94)-(432,110) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("PublicProperties");
            #line hidden
            #line (432,110)-(432,111) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,111)-(432,113) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (432,113)-(432,114) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,114)-(432,132) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_publicProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (433,9)-(433,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (433,15)-(433,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (433,16)-(433,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (433,24)-(433,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (433,25)-(433,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (433,94)-(433,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (433,95)-(433,113) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("DeclaredOperations");
            #line hidden
            #line (433,113)-(433,114) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (433,114)-(433,116) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (433,116)-(433,117) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (433,117)-(433,137) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (434,9)-(434,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (434,15)-(434,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,16)-(434,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (434,24)-(434,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,25)-(434,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (434,94)-(434,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,95)-(434,116) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("AllDeclaredOperations");
            #line hidden
            #line (434,116)-(434,117) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,117)-(434,119) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (434,119)-(434,120) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,120)-(434,143) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (435,9)-(435,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (435,15)-(435,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,16)-(435,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (435,24)-(435,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,25)-(435,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (435,94)-(435,95) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,95)-(435,111) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("PublicOperations");
            #line hidden
            #line (435,111)-(435,112) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,112)-(435,114) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (435,114)-(435,115) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,115)-(435,133) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_publicOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (437,9)-(437,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (437,18)-(437,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,19)-(437,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (437,27)-(437,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,28)-(437,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (437,92)-(437,93) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,93)-(437,109) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>");
            #line hidden
            #line (437,109)-(437,110) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,110)-(437,132) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("PublicPropertiesByName");
            #line hidden
            #line (437,132)-(437,133) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,133)-(437,135) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (437,135)-(437,136) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,136)-(437,160) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (438,9)-(438,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (438,18)-(438,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,19)-(438,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (438,27)-(438,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,28)-(438,101) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty,");
            #line hidden
            #line (438,101)-(438,102) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,102)-(438,122) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>");
            #line hidden
            #line (438,122)-(438,123) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,123)-(438,141) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("ModelPropertyInfos");
            #line hidden
            #line (438,141)-(438,142) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,142)-(438,144) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (438,144)-(438,145) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,145)-(438,165) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (439,9)-(439,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (439,18)-(439,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,19)-(439,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (439,27)-(439,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,28)-(439,102) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation,");
            #line hidden
            #line (439,102)-(439,103) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,103)-(439,124) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>");
            #line hidden
            #line (439,124)-(439,125) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,125)-(439,144) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("ModelOperationInfos");
            #line hidden
            #line (439,144)-(439,145) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,145)-(439,147) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (439,147)-(439,148) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,148)-(439,169) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (441,9)-(441,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (441,15)-(441,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,16)-(441,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (441,24)-(441,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,25)-(441,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (441,40)-(441,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,41)-(441,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Create(__Model?");
            #line hidden
            #line (441,56)-(441,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,57)-(441,62) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (441,62)-(441,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,63)-(441,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (441,64)-(441,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,65)-(441,70) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (441,70)-(441,71) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,71)-(441,78) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (441,78)-(441,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,79)-(441,81) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("id");
            #line hidden
            #line (441,81)-(441,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,82)-(441,83) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (441,83)-(441,84) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,84)-(441,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (442,9)-(442,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (443,13)-(443,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (443,16)-(443,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,17)-(443,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (443,23)-(443,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,24)-(443,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (443,25)-(443,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,26)-(443,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (443,29)-(443,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,31)-(443,39) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (443,40)-(443,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_Impl(id);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (444,13)-(444,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (444,15)-(444,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,16)-(444,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("(model");
            #line hidden
            #line (444,22)-(444,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,23)-(444,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (444,25)-(444,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,26)-(444,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (444,29)-(444,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,30)-(444,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (444,35)-(444,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,36)-(444,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("model.AttachObject(result);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (445,13)-(445,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (445,19)-(445,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,20)-(445,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (446,9)-(446,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (448,9)-(448,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (448,15)-(448,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,16)-(448,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (448,24)-(448,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,25)-(448,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (448,31)-(448,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,32)-(448,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("ToString()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (449,9)-(449,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (450,13)-(450,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (450,19)-(450,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,20)-(450,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (450,22)-(450,29) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (450,30)-(450,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(".");
            #line hidden
            #line (450,32)-(450,40) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (450,41)-(450,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Info\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (451,9)-(451,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (452,5)-(452,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (453,1)-(453,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (456,9)-(456,47) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
        public string GenerateCustomInterface(MetaModel mm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (457,1)-(457,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (457,9)-(457,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,10)-(457,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (457,19)-(457,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,20)-(457,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("ICustom");
            #line hidden
            #line (457,28)-(457,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (457,36)-(457,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Implementation");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (458,1)-(458,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (459,5)-(459,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (459,8)-(459,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,9)-(459,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (460,5)-(460,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (460,8)-(460,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,9)-(460,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Constructor");
            #line hidden
            #line (460,20)-(460,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,21)-(460,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (460,24)-(460,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,25)-(460,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (460,28)-(460,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,29)-(460,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("meta");
            #line hidden
            #line (460,33)-(460,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,34)-(460,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (460,39)-(460,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,41)-(460,48) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (461,5)-(461,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (461,8)-(461,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (461,9)-(461,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (462,5)-(462,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (462,9)-(462,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,11)-(462,18) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (462,19)-(462,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("(I");
            #line hidden
            #line (462,22)-(462,29) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (462,30)-(462,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,31)-(462,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first72 = true;
            #line (464,6)-(464,34) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first72)
                {
                    __first72 = false;
                }
                __cb.Push("    ");
                #line (465,9)-(465,12) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (465,12)-(465,13) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (465,13)-(465,22) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("<summary>");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (466,9)-(466,12) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (466,12)-(466,13) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (466,13)-(466,24) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("Constructor");
                #line hidden
                #line (466,24)-(466,25) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (466,25)-(466,28) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("for");
                #line hidden
                #line (466,28)-(466,29) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (466,29)-(466,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("the");
                #line hidden
                #line (466,32)-(466,33) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (466,33)-(466,38) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("class");
                #line hidden
                #line (466,38)-(466,39) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (466,40)-(466,48) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (467,9)-(467,12) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (467,12)-(467,13) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (467,13)-(467,23) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("</summary>");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (468,9)-(468,13) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                #line (468,13)-(468,14) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (468,15)-(468,23) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (468,24)-(468,25) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (468,26)-(468,34) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (468,35)-(468,36) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (468,36)-(468,43) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("_this);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first72) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first73 = true;
            #line (472,6)-(472,34) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first73)
                {
                    __first73 = false;
                }
                var __first74 = true;
                #line (473,10)-(473,70) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties.Where(p => p.IsDerived))
                #line hidden
                
                {
                    if (__first74)
                    {
                        __first74 = false;
                    }
                    __cb.Push("    ");
                    #line (474,13)-(474,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (474,16)-(474,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (474,17)-(474,26) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (475,13)-(475,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (475,16)-(475,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (475,17)-(475,28) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("Computation");
                    #line hidden
                    #line (475,28)-(475,29) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (475,29)-(475,31) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (475,31)-(475,32) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (475,32)-(475,35) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (475,35)-(475,36) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (475,36)-(475,43) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("derived");
                    #line hidden
                    #line (475,43)-(475,44) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (475,44)-(475,52) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("property");
                    #line hidden
                    #line (475,52)-(475,53) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (475,54)-(475,62) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (475,63)-(475,64) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (475,65)-(475,74) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (476,13)-(476,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (476,16)-(476,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (476,17)-(476,27) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (477,14)-(477,39) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(prop.Type));
                    #line hidden
                    #line (477,40)-(477,41) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (477,42)-(477,50) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (477,51)-(477,52) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (477,53)-(477,62) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (477,63)-(477,64) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (477,65)-(477,73) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (477,74)-(477,75) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (477,75)-(477,82) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_this);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first74) __cb.AppendLine();
            }
            if (!__first73) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first75 = true;
            #line (482,6)-(482,34) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first75)
                {
                    __first75 = false;
                }
                var __first76 = true;
                #line (483,10)-(483,44) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first76)
                    {
                        __first76 = false;
                    }
                    __cb.Push("    ");
                    #line (484,13)-(484,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (484,16)-(484,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (484,17)-(484,26) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (485,13)-(485,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (485,16)-(485,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (485,17)-(485,31) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("Implementation");
                    #line hidden
                    #line (485,31)-(485,32) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (485,32)-(485,34) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (485,34)-(485,35) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (485,35)-(485,38) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (485,38)-(485,39) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (485,39)-(485,48) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("operation");
                    #line hidden
                    #line (485,48)-(485,49) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (485,50)-(485,58) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (485,59)-(485,60) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (485,61)-(485,68) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (486,13)-(486,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (486,16)-(486,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (486,17)-(486,27) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (487,14)-(487,43) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(op.ReturnType));
                    #line hidden
                    #line (487,44)-(487,45) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (487,46)-(487,54) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (487,55)-(487,56) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (487,57)-(487,64) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (487,65)-(487,66) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (487,67)-(487,75) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (487,76)-(487,77) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (487,77)-(487,82) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_this");
                    #line hidden
                    var __first77 = true;
                    #line (487,83)-(487,119) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    foreach (var param in op.Parameters)
                    #line hidden
                    
                    {
                        if (__first77)
                        {
                            __first77 = false;
                        }
                        #line (487,120)-(487,121) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (487,121)-(487,122) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (487,123)-(487,149) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(ToCSharpOpType(param.Type));
                        #line hidden
                        #line (487,150)-(487,151) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (487,152)-(487,162) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(param.Name);
                        #line hidden
                    }
                    #line (487,176)-(487,178) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first76) __cb.AppendLine();
            }
            if (!__first75) __cb.AppendLine();
            __cb.Push("");
            #line (491,1)-(491,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (494,9)-(494,52) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
        public string GenerateCustomImplementation(MetaModel mm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (495,1)-(495,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (495,9)-(495,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,10)-(495,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (495,18)-(495,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,19)-(495,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (495,24)-(495,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,25)-(495,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Custom");
            #line hidden
            #line (495,32)-(495,39) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (495,40)-(495,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("ImplementationBase");
            #line hidden
            #line (495,58)-(495,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,59)-(495,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (495,60)-(495,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,61)-(495,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("ICustom");
            #line hidden
            #line (495,69)-(495,76) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (495,77)-(495,91) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Implementation");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (496,1)-(496,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (497,5)-(497,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (497,8)-(497,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,9)-(497,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (498,5)-(498,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (498,8)-(498,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,9)-(498,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("Constructor");
            #line hidden
            #line (498,20)-(498,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,21)-(498,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (498,24)-(498,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,25)-(498,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (498,28)-(498,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,29)-(498,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("meta");
            #line hidden
            #line (498,33)-(498,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,34)-(498,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (498,39)-(498,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,41)-(498,48) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (499,5)-(499,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (499,8)-(499,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (499,9)-(499,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (500,5)-(500,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (500,11)-(500,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,12)-(500,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (500,19)-(500,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,20)-(500,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (500,24)-(500,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,26)-(500,33) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (500,34)-(500,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("(I");
            #line hidden
            #line (500,37)-(500,44) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (500,45)-(500,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,46)-(500,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("_this)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (501,5)-(501,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (502,5)-(502,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first78 = true;
            #line (504,6)-(504,34) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                __cb.Push("    ");
                #line (505,9)-(505,12) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (505,12)-(505,13) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (505,13)-(505,22) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("<summary>");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (506,9)-(506,12) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (506,12)-(506,13) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (506,13)-(506,24) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("Constructor");
                #line hidden
                #line (506,24)-(506,25) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (506,25)-(506,28) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("for");
                #line hidden
                #line (506,28)-(506,29) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (506,29)-(506,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("the");
                #line hidden
                #line (506,32)-(506,33) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (506,33)-(506,38) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("class");
                #line hidden
                #line (506,38)-(506,39) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (506,40)-(506,48) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (507,9)-(507,12) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (507,12)-(507,13) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (507,13)-(507,23) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("</summary>");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (508,9)-(508,15) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (508,15)-(508,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (508,16)-(508,23) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("virtual");
                #line hidden
                #line (508,23)-(508,24) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (508,24)-(508,28) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                #line (508,28)-(508,29) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (508,30)-(508,38) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (508,39)-(508,40) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (508,41)-(508,49) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (508,50)-(508,51) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (508,51)-(508,57) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("_this)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (509,9)-(509,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (510,9)-(510,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first78) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first79 = true;
            #line (514,6)-(514,34) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                var __first80 = true;
                #line (515,10)-(515,70) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties.Where(p => p.IsDerived))
                #line hidden
                
                {
                    if (__first80)
                    {
                        __first80 = false;
                    }
                    __cb.Push("    ");
                    #line (516,13)-(516,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (516,16)-(516,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (516,17)-(516,26) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (517,13)-(517,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (517,16)-(517,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (517,17)-(517,28) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("Computation");
                    #line hidden
                    #line (517,28)-(517,29) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (517,29)-(517,31) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (517,31)-(517,32) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (517,32)-(517,35) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (517,35)-(517,36) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (517,36)-(517,43) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("derived");
                    #line hidden
                    #line (517,43)-(517,44) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (517,44)-(517,52) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("property");
                    #line hidden
                    #line (517,52)-(517,53) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (517,54)-(517,62) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (517,63)-(517,64) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (517,65)-(517,74) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (518,13)-(518,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (518,16)-(518,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (518,17)-(518,27) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (519,13)-(519,19) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (519,19)-(519,20) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (519,20)-(519,28) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (519,28)-(519,29) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (519,30)-(519,55) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(prop.Type));
                    #line hidden
                    #line (519,56)-(519,57) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (519,58)-(519,66) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (519,67)-(519,68) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (519,69)-(519,78) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (519,79)-(519,80) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (519,81)-(519,89) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (519,90)-(519,91) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (519,91)-(519,98) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_this);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first80) __cb.AppendLine();
            }
            if (!__first79) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first81 = true;
            #line (524,6)-(524,34) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first81)
                {
                    __first81 = false;
                }
                var __first82 = true;
                #line (525,10)-(525,44) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("    ");
                    #line (526,13)-(526,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (526,16)-(526,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (526,17)-(526,26) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (527,13)-(527,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (527,16)-(527,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (527,17)-(527,31) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("Implementation");
                    #line hidden
                    #line (527,31)-(527,32) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (527,32)-(527,34) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (527,34)-(527,35) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (527,35)-(527,38) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (527,38)-(527,39) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (527,39)-(527,48) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("operation");
                    #line hidden
                    #line (527,48)-(527,49) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (527,50)-(527,58) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (527,59)-(527,60) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (527,61)-(527,68) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (528,13)-(528,16) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (528,16)-(528,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (528,17)-(528,27) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (529,13)-(529,19) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (529,19)-(529,20) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (529,20)-(529,28) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (529,28)-(529,29) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (529,30)-(529,59) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(op.ReturnType));
                    #line hidden
                    #line (529,60)-(529,61) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (529,62)-(529,70) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (529,71)-(529,72) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (529,73)-(529,80) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (529,81)-(529,82) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (529,83)-(529,91) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (529,92)-(529,93) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (529,93)-(529,98) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write("_this");
                    #line hidden
                    var __first83 = true;
                    #line (529,99)-(529,135) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    foreach (var param in op.Parameters)
                    #line hidden
                    
                    {
                        if (__first83)
                        {
                            __first83 = false;
                        }
                        #line (529,136)-(529,137) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (529,137)-(529,138) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (529,139)-(529,165) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(ToCSharpOpType(param.Type));
                        #line hidden
                        #line (529,166)-(529,167) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (529,168)-(529,178) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                        __cb.Write(param.Name);
                        #line hidden
                    }
                    #line (529,192)-(529,194) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first82) __cb.AppendLine();
            }
            if (!__first81) __cb.AppendLine();
            __cb.Push("");
            #line (533,1)-(533,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaModel\Generators\MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}