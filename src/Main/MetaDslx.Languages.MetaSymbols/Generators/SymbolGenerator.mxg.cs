#pragma warning disable CS8669
#line (1,10)-(1,52) 10 "SymbolGenerator.mxg"
namespace MetaDslx.Languages.MetaSymbols.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "SymbolGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,18) 13 "SymbolGenerator.mxg"
    System.Linq;
    #line hidden
    #line (4,1)-(4,6) 5 "SymbolGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,23) 13 "SymbolGenerator.mxg"
    Roslyn.Utilities;
    #line hidden
    #line (5,1)-(5,6) 5 "SymbolGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,28) 13 "SymbolGenerator.mxg"
    MetaDslx.CodeAnalysis;
    #line hidden
    #line (6,1)-(6,6) 5 "SymbolGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,43) 13 "SymbolGenerator.mxg"
    MetaDslx.Languages.MetaSymbols.Model;
    #line hidden
    
    #line (8,10)-(8,26) 25 "SymbolGenerator.mxg"
    public partial class SymbolGenerator
    #line hidden
    {
        #line (10,9)-(10,39) 22 "SymbolGenerator.mxg"
        public string GenerateSymbol(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (11,1)-(11,8) 25 "SymbolGenerator.mxg"
            __cb.Write("#pragma");
            #line hidden
            #line (11,8)-(11,9) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,9)-(11,16) 25 "SymbolGenerator.mxg"
            __cb.Write("warning");
            #line hidden
            #line (11,16)-(11,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,17)-(11,24) 25 "SymbolGenerator.mxg"
            __cb.Write("disable");
            #line hidden
            #line (11,24)-(11,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,25)-(11,31) 25 "SymbolGenerator.mxg"
            __cb.Write("CS8669");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (12,1)-(12,8) 25 "SymbolGenerator.mxg"
            __cb.Write("#pragma");
            #line hidden
            #line (12,8)-(12,9) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,9)-(12,16) 25 "SymbolGenerator.mxg"
            __cb.Write("warning");
            #line hidden
            #line (12,16)-(12,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,17)-(12,24) 25 "SymbolGenerator.mxg"
            __cb.Write("disable");
            #line hidden
            #line (12,24)-(12,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,25)-(12,31) 25 "SymbolGenerator.mxg"
            __cb.Write("CS0108");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (14,10)-(14,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,12)-(14,28) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.Namespace);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (15,1)-(15,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (16,5)-(16,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (16,10)-(16,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,11)-(16,17) 25 "SymbolGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (16,17)-(16,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,18)-(16,19) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (16,19)-(16,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,20)-(16,40) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Type;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (17,5)-(17,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (17,10)-(17,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,11)-(17,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (17,20)-(17,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,21)-(17,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (17,22)-(17,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,23)-(17,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (18,5)-(18,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (18,10)-(18,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,11)-(18,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__SymbolAttribute");
            #line hidden
            #line (18,28)-(18,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,29)-(18,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (18,30)-(18,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,31)-(18,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (19,5)-(19,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (19,10)-(19,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,11)-(19,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__PhaseAttribute");
            #line hidden
            #line (19,27)-(19,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,28)-(19,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (19,29)-(19,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,30)-(19,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.PhaseAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (20,5)-(20,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (20,10)-(20,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,11)-(20,29) 25 "SymbolGenerator.mxg"
            __cb.Write("__DerivedAttribute");
            #line hidden
            #line (20,29)-(20,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,30)-(20,31) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (20,31)-(20,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,32)-(20,87) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DerivedAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (21,5)-(21,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (21,10)-(21,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,11)-(21,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__WeakAttribute");
            #line hidden
            #line (21,26)-(21,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,27)-(21,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (21,28)-(21,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,29)-(21,81) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.WeakAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,5)-(22,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (22,10)-(22,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,11)-(22,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (22,19)-(22,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,20)-(22,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (22,21)-(22,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,22)-(22,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (23,5)-(23,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (23,10)-(23,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,11)-(23,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__AttributeSymbol");
            #line hidden
            #line (23,28)-(23,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,29)-(23,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (23,30)-(23,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,31)-(23,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (24,5)-(24,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (24,10)-(24,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,11)-(24,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__AssemblySymbol");
            #line hidden
            #line (24,27)-(24,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,28)-(24,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (24,29)-(24,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,30)-(24,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AssemblySymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (25,5)-(25,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (25,10)-(25,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,11)-(25,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol");
            #line hidden
            #line (25,25)-(25,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,26)-(25,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (25,27)-(25,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,28)-(25,79) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModuleSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (26,5)-(26,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (26,10)-(26,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,11)-(26,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol");
            #line hidden
            #line (26,30)-(26,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,31)-(26,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (26,32)-(26,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,33)-(26,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (27,5)-(27,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (27,10)-(27,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,11)-(27,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__NamespaceSymbol");
            #line hidden
            #line (27,28)-(27,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,29)-(27,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (27,30)-(27,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,31)-(27,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (28,5)-(28,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (28,10)-(28,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,11)-(28,23) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol");
            #line hidden
            #line (28,23)-(28,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,24)-(28,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (28,25)-(28,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,26)-(28,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (29,5)-(29,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (29,10)-(29,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,11)-(29,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbolFactory");
            #line hidden
            #line (29,27)-(29,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,28)-(29,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (29,29)-(29,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,30)-(29,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (30,5)-(30,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (30,10)-(30,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,11)-(30,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__LexicalSortKey");
            #line hidden
            #line (30,27)-(30,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,28)-(30,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (30,29)-(30,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,30)-(30,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.LexicalSortKey;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (31,5)-(31,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (31,10)-(31,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,11)-(31,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (31,25)-(31,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,26)-(31,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (31,27)-(31,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,28)-(31,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (32,5)-(32,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (32,10)-(32,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,11)-(32,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (32,18)-(32,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,19)-(32,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (32,20)-(32,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,21)-(32,53) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (33,5)-(33,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (33,10)-(33,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,11)-(33,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (33,28)-(33,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,29)-(33,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (33,30)-(33,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,31)-(33,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (34,5)-(34,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (34,10)-(34,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,11)-(34,35) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelPropertyAttribute");
            #line hidden
            #line (34,35)-(34,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,36)-(34,37) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (34,37)-(34,38) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,38)-(34,99) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (35,5)-(35,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (35,10)-(35,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,11)-(35,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (35,28)-(35,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,29)-(35,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (35,30)-(35,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,31)-(35,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (36,5)-(36,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (36,10)-(36,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (36,11)-(36,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (36,27)-(36,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (36,28)-(36,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (36,29)-(36,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (36,30)-(36,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (37,5)-(37,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (37,10)-(37,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,11)-(37,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (37,30)-(37,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,31)-(37,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (37,32)-(37,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,33)-(37,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (38,5)-(38,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (38,10)-(38,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,11)-(38,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (38,26)-(38,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,27)-(38,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (38,28)-(38,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,29)-(38,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (39,5)-(39,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (39,10)-(39,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,11)-(39,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (39,24)-(39,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,25)-(39,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (39,26)-(39,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,27)-(39,69) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Compilation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (40,5)-(40,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (40,10)-(40,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,11)-(40,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (40,27)-(40,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,28)-(40,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (40,29)-(40,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,30)-(40,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (41,5)-(41,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (41,10)-(41,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,11)-(41,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (41,30)-(41,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,31)-(41,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (41,32)-(41,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,33)-(41,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (42,5)-(42,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (42,10)-(42,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,11)-(42,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (42,36)-(42,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,37)-(42,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (42,38)-(42,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,39)-(42,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (43,5)-(43,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (43,10)-(43,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,11)-(43,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__CultureInfo");
            #line hidden
            #line (43,24)-(43,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,25)-(43,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (43,26)-(43,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,27)-(43,68) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Globalization.CultureInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (44,5)-(44,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (44,10)-(44,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,11)-(44,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (44,38)-(44,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,39)-(44,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (44,40)-(44,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,41)-(44,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            #line (46,6)-(46,38) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (47,6)-(47,65) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            #line (48,6)-(48,122) 13 "SymbolGenerator.mxg"
            var baseName = baseSymbol is null ? "global::MetaDslx.CodeAnalysis.Symbols.Symbol" : GetBaseName(symbol, baseSymbol);
            #line hidden
            
            __cb.Push("    ");
            #line (49,6)-(49,9) 24 "SymbolGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (49,10)-(49,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SymbolAttribute");
            #line hidden
            #line (49,28)-(49,31) 24 "SymbolGenerator.mxg"
            __cb.Write("]");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (50,5)-(50,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (50,11)-(50,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,12)-(50,20) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (50,20)-(50,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,21)-(50,28) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (50,28)-(50,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,29)-(50,34) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (50,34)-(50,35) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,36)-(50,63) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (50,64)-(50,65) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (50,65)-(50,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,67)-(50,75) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (51,5)-(51,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (52,9)-(52,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (52,15)-(52,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,16)-(52,19) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (52,19)-(52,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,20)-(52,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (52,25)-(52,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,26)-(52,41) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts");
            #line hidden
            #line (52,41)-(52,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,42)-(52,43) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (52,43)-(52,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,45)-(52,53) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            #line (52,54)-(52,70) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (53,9)-(53,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first1 = true;
            #line (54,14)-(54,54) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                __cb.Push("            ");
                #line (55,17)-(55,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (55,23)-(55,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (55,24)-(55,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (55,30)-(55,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (55,31)-(55,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (55,39)-(55,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (55,40)-(55,56) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart");
                #line hidden
                #line (55,56)-(55,57) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (55,57)-(55,63) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (55,64)-(55,69) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (55,70)-(55,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (55,71)-(55,72) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (55,72)-(55,73) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (55,73)-(55,76) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (55,76)-(55,77) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (55,77)-(55,107) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart(nameof(Start_");
                #line hidden
                #line (55,108)-(55,113) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (55,114)-(55,117) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (56,17)-(56,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (56,23)-(56,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (56,24)-(56,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (56,30)-(56,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (56,31)-(56,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (56,39)-(56,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (56,40)-(56,56) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart");
                #line hidden
                #line (56,56)-(56,57) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (56,57)-(56,64) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (56,65)-(56,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (56,71)-(56,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (56,72)-(56,73) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (56,73)-(56,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (56,74)-(56,77) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (56,77)-(56,78) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (56,78)-(56,109) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart(nameof(Finish_");
                #line hidden
                #line (56,110)-(56,115) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (56,116)-(56,119) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first1) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (59,13)-(59,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (59,19)-(59,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,20)-(59,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (59,26)-(59,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,27)-(59,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (59,35)-(59,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,36)-(59,53) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (59,53)-(59,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,54)-(59,69) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (59,69)-(59,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,70)-(59,71) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (59,71)-(59,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (60,17)-(60,51) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph.CreateFromParts(");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (61,22)-(61,30) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            #line (61,31)-(61,63) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts.CompletionGraph");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first2 = true;
            #line (62,22)-(62,62) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first2)
                {
                    __first2 = false;
                }
                __cb.Push("                    ");
                #line (63,25)-(63,26) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (63,26)-(63,27) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (63,27)-(63,33) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (63,34)-(63,39) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (63,40)-(63,41) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (63,41)-(63,42) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (63,42)-(63,49) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (63,50)-(63,55) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            __cb.Push("                ");
            #line (65,17)-(65,19) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (66,9)-(66,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first3 = true;
            #line (68,10)-(68,75) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsAbstract))
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                var __first4 = true;
                #line (69,14)-(69,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first4)
                    {
                        __first4 = false;
                    }
                    __cb.Push("        ");
                    #line (70,17)-(70,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (70,24)-(70,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (70,25)-(70,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (70,31)-(70,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (70,33)-(70,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (70,60)-(70,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (70,62)-(70,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (70,81)-(70,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (70,82)-(70,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (70,83)-(70,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (70,84)-(70,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (70,87)-(70,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (70,89)-(70,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (70,116)-(70,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (71,14)-(71,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first4)
                    {
                        __first4 = false;
                    }
                    __cb.Push("        ");
                    #line (72,17)-(72,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (72,24)-(72,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (72,26)-(72,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (72,53)-(72,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (72,55)-(72,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (72,74)-(72,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first4) __cb.AppendLine();
            }
            if (!__first3) __cb.AppendLine();
            var __first5 = true;
            #line (75,10)-(75,70) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations.Where(o => o.IsCached))
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
                __cb.Push("        ");
                #line (76,13)-(76,20) 29 "SymbolGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (76,20)-(76,21) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,21)-(76,27) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (76,27)-(76,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,29)-(76,53) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (76,54)-(76,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,56)-(76,72) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(op));
                #line hidden
                #line (76,73)-(76,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,74)-(76,75) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (76,75)-(76,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,76)-(76,79) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (76,79)-(76,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,81)-(76,105) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (76,106)-(76,109) 29 "SymbolGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (79,9)-(79,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (79,15)-(79,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,17)-(79,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (79,45)-(79,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol?");
            #line hidden
            #line (79,55)-(79,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,56)-(79,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (79,66)-(79,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,67)-(79,81) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation?");
            #line hidden
            #line (79,81)-(79,82) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,82)-(79,94) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (79,94)-(79,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,95)-(79,115) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration?");
            #line hidden
            #line (79,115)-(79,116) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,116)-(79,128) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (79,128)-(79,129) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,129)-(79,144) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (79,144)-(79,145) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,145)-(79,157) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (79,157)-(79,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,158)-(79,168) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol?");
            #line hidden
            #line (79,168)-(79,169) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,169)-(79,182) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (79,182)-(79,183) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,183)-(79,201) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo?");
            #line hidden
            #line (79,201)-(79,202) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,202)-(79,212) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (79,212)-(79,213) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (80,13)-(80,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (80,14)-(80,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,15)-(80,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (80,30)-(80,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,31)-(80,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (80,43)-(80,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,44)-(80,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (80,56)-(80,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,57)-(80,69) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (80,69)-(80,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,70)-(80,83) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (80,83)-(80,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,84)-(80,94) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (81,9)-(81,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (82,9)-(82,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (84,9)-(84,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (84,15)-(84,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,16)-(84,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (84,24)-(84,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,25)-(84,31) 25 "SymbolGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (84,31)-(84,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,32)-(84,42) 25 "SymbolGenerator.mxg"
            __cb.Write("SymbolType");
            #line hidden
            #line (84,42)-(84,43) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,43)-(84,45) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (84,45)-(84,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,46)-(84,53) 25 "SymbolGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (84,54)-(84,81) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (84,82)-(84,84) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (85,9)-(85,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (85,18)-(85,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,19)-(85,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (85,27)-(85,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,28)-(85,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (85,45)-(85,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,46)-(85,61) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (85,61)-(85,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,62)-(85,64) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (85,64)-(85,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,65)-(85,97) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first6 = true;
            #line (87,10)-(87,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                var __first7 = true;
                #line (88,14)-(88,51) 17 "SymbolGenerator.mxg"
                if (!prop.IsDerived && !prop.IsPlain)
                #line hidden
                
                {
                    if (__first7)
                    {
                        __first7 = false;
                    }
                    __cb.Push("        ");
                    #line (89,18)-(89,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (89,22)-(89,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("__ModelPropertyAttribute");
                    #line hidden
                    #line (89,47)-(89,50) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first7) __cb.AppendLine();
                var __first8 = true;
                #line (91,14)-(91,32) 17 "SymbolGenerator.mxg"
                if (!prop.IsPlain)
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("        ");
                    #line (92,18)-(92,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (92,22)-(92,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("__PhaseAttribute");
                    #line hidden
                    var __first9 = true;
                    #line (92,39)-(92,66) 21 "SymbolGenerator.mxg"
                    if (prop.Phase is not null)
                    #line hidden
                    
                    {
                        if (__first9)
                        {
                            __first9 = false;
                        }
                        #line (92,67)-(92,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(nameof(");
                        #line hidden
                        #line (92,76)-(92,91) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Phase.Name);
                        #line hidden
                        #line (92,92)-(92,94) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                    }
                    #line (92,103)-(92,106) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first8) __cb.AppendLine();
                var __first10 = true;
                #line (94,14)-(94,33) 17 "SymbolGenerator.mxg"
                if (prop.IsDerived)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (95,18)-(95,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (95,22)-(95,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DerivedAttribute");
                    #line hidden
                    var __first11 = true;
                    #line (95,41)-(95,59) 21 "SymbolGenerator.mxg"
                    if (prop.IsCached)
                    #line hidden
                    
                    {
                        if (__first11)
                        {
                            __first11 = false;
                        }
                        #line (95,60)-(95,73) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true)");
                        #line hidden
                    }
                    #line (95,82)-(95,85) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                var __first12 = true;
                #line (97,14)-(97,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("        ");
                    #line (98,18)-(98,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (98,22)-(98,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("__WeakAttribute");
                    #line hidden
                    #line (98,38)-(98,41) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first12) __cb.AppendLine();
                __cb.Push("        ");
                #line (100,13)-(100,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (100,19)-(100,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first13 = true;
                #line (100,21)-(100,41) 17 "SymbolGenerator.mxg"
                if (prop.IsAbstract)
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    #line (100,42)-(100,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (100,50)-(100,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (100,60)-(100,90) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (100,91)-(100,92) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (100,93)-(100,102) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (101,13)-(101,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first14 = true;
                #line (102,18)-(102,35) 17 "SymbolGenerator.mxg"
                if (prop.IsPlain)
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    var __first15 = true;
                    #line (103,22)-(103,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsAbstract)
                    #line hidden
                    
                    {
                        if (__first15)
                        {
                            __first15 = false;
                        }
                        __cb.Push("            ");
                        #line (104,25)-(104,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("get;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (105,22)-(105,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first15)
                        {
                            __first15 = false;
                        }
                        var __first16 = true;
                        #line (106,26)-(106,42) 25 "SymbolGenerator.mxg"
                        if (prop.IsWeak)
                        #line hidden
                        
                        {
                            if (__first16)
                            {
                                __first16 = false;
                            }
                            __cb.Push("            ");
                            #line (107,29)-(107,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (108,29)-(108,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (109,33)-(109,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (109,35)-(109,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (109,36)-(109,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (109,38)-(109,56) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (109,57)-(109,75) 41 "SymbolGenerator.mxg"
                            __cb.Write(".TryGetValue(this,");
                            #line hidden
                            #line (109,75)-(109,76) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (109,76)-(109,79) 41 "SymbolGenerator.mxg"
                            __cb.Write("out");
                            #line hidden
                            #line (109,79)-(109,80) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (109,80)-(109,83) 41 "SymbolGenerator.mxg"
                            __cb.Write("var");
                            #line hidden
                            #line (109,83)-(109,84) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (109,84)-(109,92) 41 "SymbolGenerator.mxg"
                            __cb.Write("result))");
                            #line hidden
                            #line (109,92)-(109,93) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (109,93)-(109,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (109,99)-(109,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (109,100)-(109,101) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (109,102)-(109,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type));
                            #line hidden
                            #line (109,133)-(109,141) 41 "SymbolGenerator.mxg"
                            __cb.Write(")result;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (110,33)-(110,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("else");
                            #line hidden
                            #line (110,37)-(110,38) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (110,38)-(110,44) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (110,44)-(110,45) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (110,46)-(110,75) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (110,76)-(110,77) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (111,29)-(111,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (112,29)-(112,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (112,38)-(112,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (112,39)-(112,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (113,29)-(113,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (114,34)-(114,71) 40 "SymbolGenerator.mxg"
                            __cb.Write(AssignProperty(symbol, prop, "value"));
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (115,29)-(115,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (116,26)-(116,30) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first16)
                            {
                                __first16 = false;
                            }
                            __cb.Push("            ");
                            #line (117,29)-(117,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            #line (117,32)-(117,33) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (117,33)-(117,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (117,35)-(117,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (117,37)-(117,55) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (117,56)-(117,57) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (118,29)-(118,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (118,38)-(118,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (118,39)-(118,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
                            #line hidden
                            #line (118,42)-(118,43) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (118,43)-(118,45) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (118,45)-(118,46) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (118,47)-(118,65) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (118,66)-(118,67) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (118,67)-(118,68) 41 "SymbolGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (118,68)-(118,69) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (118,69)-(118,75) 41 "SymbolGenerator.mxg"
                            __cb.Write("value;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first16) __cb.AppendLine();
                    }
                    if (!__first15) __cb.AppendLine();
                }
                #line (121,18)-(121,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    __cb.Push("            ");
                    #line (122,21)-(122,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (123,21)-(123,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (124,25)-(124,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("this.ForceComplete(CompletionParts.Finish_");
                    #line hidden
                    #line (124,68)-(124,97) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (124,98)-(124,99) 33 "SymbolGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (124,99)-(124,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (124,100)-(124,105) 33 "SymbolGenerator.mxg"
                    __cb.Write("null,");
                    #line hidden
                    #line (124,105)-(124,106) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (124,106)-(124,115) 33 "SymbolGenerator.mxg"
                    __cb.Write("default);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first17 = true;
                    #line (125,26)-(125,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("                ");
                        #line (126,29)-(126,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (126,31)-(126,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (126,32)-(126,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (126,34)-(126,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (126,53)-(126,71) 37 "SymbolGenerator.mxg"
                        __cb.Write(".TryGetValue(this,");
                        #line hidden
                        #line (126,71)-(126,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (126,72)-(126,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("out");
                        #line hidden
                        #line (126,75)-(126,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (126,76)-(126,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (126,79)-(126,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (126,80)-(126,88) 37 "SymbolGenerator.mxg"
                        __cb.Write("result))");
                        #line hidden
                        #line (126,88)-(126,89) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (126,89)-(126,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (126,95)-(126,96) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (126,96)-(126,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (126,98)-(126,128) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (126,129)-(126,137) 37 "SymbolGenerator.mxg"
                        __cb.Write(")result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (127,29)-(127,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("else");
                        #line hidden
                        #line (127,33)-(127,34) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (127,34)-(127,40) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (127,40)-(127,41) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (127,42)-(127,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (127,72)-(127,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (128,26)-(128,30) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("                ");
                        #line (129,29)-(129,35) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (129,35)-(129,36) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (129,37)-(129,55) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (129,56)-(129,57) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first17) __cb.AppendLine();
                    __cb.Push("            ");
                    #line (131,21)-(131,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first14) __cb.AppendLine();
                __cb.Push("        ");
                #line (133,13)-(133,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first6) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first18 = true;
            #line (136,10)-(136,47) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations)
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                #line (137,14)-(137,90) 17 "SymbolGenerator.mxg"
                var arguments = "("+string.Join(", ", op.Parameters.Select(p => p.Name))+")";
                #line hidden
                
                #line (138,14)-(138,42) 17 "SymbolGenerator.mxg"
                var call = op.Name+arguments;
                #line hidden
                
                #line (139,14)-(139,65) 17 "SymbolGenerator.mxg"
                var returnType = GetTypeName(symbol, op.ReturnType);
                #line hidden
                
                __cb.WriteLine();
                __cb.Pop();
                var __first19 = true;
                #line (141,14)-(141,29) 17 "SymbolGenerator.mxg"
                if (op.IsPhase)
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("        ");
                    #line (142,18)-(142,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (142,22)-(142,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("__PhaseAttribute");
                    #line hidden
                    #line (142,39)-(142,42) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (143,17)-(143,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (143,26)-(143,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (143,27)-(143,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (143,35)-(143,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (143,36)-(143,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (143,40)-(143,41) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (143,42)-(143,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (143,50)-(143,66) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (143,66)-(143,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (143,67)-(143,79) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (143,79)-(143,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (143,80)-(143,99) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (143,99)-(143,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (143,100)-(143,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (144,14)-(144,35) 17 "SymbolGenerator.mxg"
                else if (op.IsCached)
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("        ");
                    #line (145,18)-(145,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (145,22)-(145,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DerivedAttribute");
                    #line hidden
                    var __first20 = true;
                    #line (145,41)-(145,57) 21 "SymbolGenerator.mxg"
                    if (op.IsCached)
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        #line (145,58)-(145,70) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true");
                        #line hidden
                        var __first21 = true;
                        #line (145,71)-(145,116) 25 "SymbolGenerator.mxg"
                        if (!string.IsNullOrEmpty(op.CacheCondition))
                        #line hidden
                        
                        {
                            if (__first21)
                            {
                                __first21 = false;
                            }
                            #line (145,117)-(145,118) 41 "SymbolGenerator.mxg"
                            __cb.Write(",");
                            #line hidden
                            #line (145,118)-(145,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (145,119)-(145,129) 41 "SymbolGenerator.mxg"
                            __cb.Write("Condition=");
                            #line hidden
                            #line (145,130)-(145,162) 40 "SymbolGenerator.mxg"
                            __cb.Write(op.CacheCondition.EncodeString());
                            #line hidden
                        }
                        #line (145,171)-(145,172) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                    }
                    #line (145,181)-(145,184) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (146,17)-(146,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (146,23)-(146,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,25)-(146,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (146,36)-(146,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,38)-(146,45) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (146,46)-(146,47) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first22 = true;
                    foreach (var __item23 in 
                    #line (146,48)-(146,118) 21 "SymbolGenerator.mxg"
                    from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                    #line hidden
                    )
                    {
                        if (__first22)
                        {
                            __first22 = false;
                        }
                        else
                        {
                            __cb.Push("        ");
                            __cb.DontIgnoreLastLineEnd = true;
                            #line (146,128)-(146,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item23);
                    }
                    #line (146,133)-(146,134) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (147,17)-(147,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first24 = true;
                    #line (148,22)-(148,67) 21 "SymbolGenerator.mxg"
                    if (!string.IsNullOrEmpty(op.CacheCondition))
                    #line hidden
                    
                    {
                        if (__first24)
                        {
                            __first24 = false;
                        }
                        __cb.Push("            ");
                        #line (149,25)-(149,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (149,27)-(149,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (149,28)-(149,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!(");
                        #line hidden
                        #line (149,32)-(149,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.CacheCondition);
                        #line hidden
                        #line (149,50)-(149,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                        #line (149,52)-(149,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (149,53)-(149,59) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (149,59)-(149,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (149,61)-(149,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, op.ReturnType));
                        #line hidden
                        #line (149,100)-(149,101) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first24) __cb.AppendLine();
                    #line (151,22)-(151,54) 21 "SymbolGenerator.mxg"
                    var fieldName = GetFieldName(op);
                    #line hidden
                    
                    var __first25 = true;
                    #line (152,22)-(152,51) 21 "SymbolGenerator.mxg"
                    if (op.Parameters.Count == 0)
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("            ");
                        #line (153,25)-(153,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (153,31)-(153,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,32)-(153,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (153,34)-(153,44) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (153,45)-(153,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (153,47)-(153,56) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (153,57)-(153,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (153,72)-(153,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,73)-(153,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (153,79)-(153,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,80)-(153,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (153,82)-(153,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,83)-(153,91) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (153,92)-(153,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.Name);
                        #line hidden
                        #line (153,101)-(153,110) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (153,111)-(153,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (154,22)-(154,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("            ");
                        #line (155,25)-(155,28) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (155,28)-(155,29) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (155,29)-(155,47) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary");
                        #line hidden
                        #line (155,47)-(155,48) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (155,48)-(155,49) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (155,49)-(155,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (155,51)-(155,60) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (155,61)-(155,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (155,76)-(155,77) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (155,77)-(155,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (155,83)-(155,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (155,84)-(155,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (155,86)-(155,87) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (155,87)-(155,90) 37 "SymbolGenerator.mxg"
                        __cb.Write("new");
                        #line hidden
                        #line (155,90)-(155,91) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (155,91)-(155,150) 37 "SymbolGenerator.mxg"
                        __cb.Write("global::System.Collections.Concurrent.ConcurrentDictionary<");
                        #line hidden
                        #line (155,151)-(155,178) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetCacheKeyType(symbol, op));
                        #line hidden
                        #line (155,179)-(155,180) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (155,180)-(155,181) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (155,182)-(155,192) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (155,193)-(155,198) 37 "SymbolGenerator.mxg"
                        __cb.Write(">());");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (156,25)-(156,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (156,31)-(156,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,32)-(156,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary.GetOrAdd(");
                        #line hidden
                        #line (156,61)-(156,70) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (156,71)-(156,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (156,72)-(156,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,73)-(156,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__args");
                        #line hidden
                        #line (156,79)-(156,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,80)-(156,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (156,82)-(156,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,83)-(156,91) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (156,92)-(156,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.Name);
                        #line hidden
                        #line (156,101)-(156,110) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (156,111)-(156,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first25) __cb.AppendLine();
                    __cb.Push("        ");
                    #line (158,17)-(158,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (160,17)-(160,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (160,26)-(160,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (160,27)-(160,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (160,35)-(160,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (160,37)-(160,47) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (160,48)-(160,49) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (160,49)-(160,57) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (160,58)-(160,65) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (160,66)-(160,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first26 = true;
                    foreach (var __item27 in 
                    #line (160,68)-(160,138) 21 "SymbolGenerator.mxg"
                    from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                    #line hidden
                    )
                    {
                        if (__first26)
                        {
                            __first26 = false;
                        }
                        else
                        {
                            __cb.Push("        ");
                            __cb.DontIgnoreLastLineEnd = true;
                            #line (160,148)-(160,152) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item27);
                    }
                    #line (160,153)-(160,155) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (161,14)-(161,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("        ");
                    #line (162,17)-(162,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (162,23)-(162,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (162,24)-(162,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (162,32)-(162,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (162,34)-(162,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (162,45)-(162,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (162,47)-(162,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (162,55)-(162,56) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first28 = true;
                    foreach (var __item29 in 
                    #line (162,57)-(162,127) 21 "SymbolGenerator.mxg"
                    from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                    #line hidden
                    )
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        else
                        {
                            __cb.Push("        ");
                            __cb.DontIgnoreLastLineEnd = true;
                            #line (162,137)-(162,141) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item29);
                    }
                    #line (162,142)-(162,144) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first19) __cb.AppendLine();
            }
            if (!__first18) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            #line (166,10)-(166,40) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            __cb.Push("        ");
            #line (167,9)-(167,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (167,18)-(167,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,19)-(167,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (167,27)-(167,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,28)-(167,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (167,32)-(167,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,33)-(167,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (167,54)-(167,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,55)-(167,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (167,71)-(167,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,72)-(167,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (167,87)-(167,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,88)-(167,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (167,105)-(167,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,106)-(167,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (167,118)-(167,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,119)-(167,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (167,138)-(167,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,139)-(167,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (168,9)-(168,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (169,14)-(169,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            var __first30 = true;
            #line (170,14)-(170,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                #line (171,18)-(171,36) 17 "SymbolGenerator.mxg"
                hasNewPhase = true;
                #line hidden
                
                #line (172,18)-(172,63) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                __cb.Push("            ");
                #line (173,17)-(173,19) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (173,19)-(173,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (173,20)-(173,35) 29 "SymbolGenerator.mxg"
                __cb.Write("(incompletePart");
                #line hidden
                #line (173,35)-(173,36) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (173,36)-(173,38) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (173,38)-(173,39) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (173,39)-(173,61) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Start_");
                #line hidden
                #line (173,62)-(173,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (173,68)-(173,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (173,69)-(173,71) 29 "SymbolGenerator.mxg"
                __cb.Write("||");
                #line hidden
                #line (173,71)-(173,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (173,72)-(173,86) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart");
                #line hidden
                #line (173,86)-(173,87) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (173,87)-(173,89) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (173,89)-(173,90) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (173,90)-(173,113) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Finish_");
                #line hidden
                #line (173,114)-(173,119) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (173,120)-(173,121) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (174,17)-(174,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (175,21)-(175,23) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (175,23)-(175,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (175,24)-(175,64) 29 "SymbolGenerator.mxg"
                __cb.Write("(NotePartComplete(CompletionParts.Start_");
                #line hidden
                #line (175,65)-(175,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (175,71)-(175,73) 29 "SymbolGenerator.mxg"
                __cb.Write("))");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (176,21)-(176,22) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (177,25)-(177,28) 29 "SymbolGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (177,28)-(177,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,29)-(177,40) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics");
                #line hidden
                #line (177,40)-(177,41) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,41)-(177,42) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (177,42)-(177,43) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,43)-(177,73) 29 "SymbolGenerator.mxg"
                __cb.Write("__DiagnosticBag.GetInstance();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first31 = true;
                #line (178,26)-(178,48) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("                    ");
                    #line (179,29)-(179,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (179,32)-(179,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,33)-(179,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (179,39)-(179,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,40)-(179,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (179,41)-(179,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,42)-(179,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (179,51)-(179,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (179,57)-(179,70) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (179,70)-(179,71) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,71)-(179,90) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first32 = true;
                    #line (180,30)-(180,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        __cb.Push("                    ");
                        #line (181,34)-(181,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first32) __cb.AppendLine();
                }
                #line (183,26)-(183,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    #line (184,30)-(184,49) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    __cb.Push("                    ");
                    #line (185,29)-(185,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (185,32)-(185,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (185,33)-(185,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (185,39)-(185,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (185,40)-(185,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (185,41)-(185,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (185,42)-(185,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (185,51)-(185,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (185,57)-(185,70) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (185,70)-(185,71) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (185,71)-(185,90) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (186,30)-(186,68) 32 "SymbolGenerator.mxg"
                    __cb.Write(AssignProperty(symbol, prop, "result"));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (187,26)-(187,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("                    ");
                    #line (188,30)-(188,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (188,36)-(188,49) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (188,49)-(188,50) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (188,50)-(188,69) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first31) __cb.AppendLine();
                __cb.Push("                    ");
                #line (190,25)-(190,59) 29 "SymbolGenerator.mxg"
                __cb.Write("AddSymbolDiagnostics(diagnostics);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (191,25)-(191,44) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics.Free();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (192,25)-(192,65) 29 "SymbolGenerator.mxg"
                __cb.Write("NotePartComplete(CompletionParts.Finish_");
                #line hidden
                #line (192,66)-(192,71) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (192,72)-(192,74) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (193,21)-(193,22) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (194,21)-(194,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (194,27)-(194,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (194,28)-(194,33) 29 "SymbolGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (195,17)-(195,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (196,17)-(196,21) 29 "SymbolGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (196,21)-(196,22) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first30) __cb.AppendLine();
            var __first33 = true;
            #line (198,14)-(198,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("            ");
                #line (199,17)-(199,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (200,21)-(200,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (200,27)-(200,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,28)-(200,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (200,54)-(200,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,55)-(200,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (200,70)-(200,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,71)-(200,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (200,83)-(200,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,84)-(200,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (201,17)-(201,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (202,14)-(202,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("            ");
                #line (203,17)-(203,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (203,23)-(203,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (203,24)-(203,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (203,50)-(203,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (203,51)-(203,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (203,66)-(203,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (203,67)-(203,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (203,79)-(203,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (203,80)-(203,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first33) __cb.AppendLine();
            __cb.Push("        ");
            #line (205,9)-(205,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first34 = true;
            #line (207,10)-(207,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (209,14)-(209,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first35 = true;
                #line (210,14)-(210,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    #line (211,18)-(211,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    var __first36 = true;
                    #line (212,18)-(212,58) 21 "SymbolGenerator.mxg"
                    if (props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first36)
                        {
                            __first36 = false;
                        }
                        __cb.Push("        ");
                        #line (213,21)-(213,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (213,30)-(213,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (213,31)-(213,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (213,39)-(213,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (213,41)-(213,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (213,52)-(213,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (213,53)-(213,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (213,62)-(213,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (213,68)-(213,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (213,84)-(213,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (213,85)-(213,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (213,97)-(213,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (213,98)-(213,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (213,117)-(213,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (213,118)-(213,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (214,18)-(214,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first36)
                        {
                            __first36 = false;
                        }
                        __cb.Push("        ");
                        #line (215,21)-(215,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (215,30)-(215,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,31)-(215,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (215,38)-(215,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,40)-(215,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (215,51)-(215,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,52)-(215,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (215,61)-(215,66) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (215,67)-(215,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (215,83)-(215,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,84)-(215,96) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (215,96)-(215,97) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,97)-(215,116) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (215,116)-(215,117) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,117)-(215,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (216,21)-(216,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = true;
                        __cb.Push("            ");
                        #line (218,25)-(218,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (218,31)-(218,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (218,32)-(218,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first37 = true;
                        #line (219,30)-(219,58) 25 "SymbolGenerator.mxg"
                        foreach (var prop in props) 
                        #line hidden
                        
                        {
                            if (__first37)
                            {
                                __first37 = false;
                            }
                            else
                            {
                                __cb.Push("                ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (219,68)-(219,72) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Push("                ");
                            #line (220,33)-(220,69) 41 "SymbolGenerator.mxg"
                            __cb.Write("SymbolFactory.GetSymbolPropertyValue");
                            #line hidden
                            var __first38 = true;
                            #line (220,70)-(220,99) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first38)
                                {
                                    __first38 = false;
                                }
                                #line (220,100)-(220,101) 45 "SymbolGenerator.mxg"
                                __cb.Write("s");
                                #line hidden
                            }
                            #line (220,109)-(220,110) 41 "SymbolGenerator.mxg"
                            __cb.Write("<");
                            #line hidden
                            #line (220,111)-(220,146) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type.Type));
                            #line hidden
                            #line (220,147)-(220,154) 41 "SymbolGenerator.mxg"
                            __cb.Write(">(this,");
                            #line hidden
                            #line (220,154)-(220,155) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (220,155)-(220,162) 41 "SymbolGenerator.mxg"
                            __cb.Write("nameof(");
                            #line hidden
                            #line (220,163)-(220,172) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (220,173)-(220,175) 41 "SymbolGenerator.mxg"
                            __cb.Write("),");
                            #line hidden
                            #line (220,175)-(220,176) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (220,176)-(220,188) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (220,188)-(220,189) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (220,189)-(220,208) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first37) __cb.AppendLine();
                        __cb.Push("            ");
                        #line (222,25)-(222,27) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = false;
                        __cb.AppendLine();
                        __cb.Push("        ");
                        #line (224,21)-(224,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first36) __cb.AppendLine();
                }
                #line (226,14)-(226,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    #line (227,18)-(227,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (228,18)-(228,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    var __first39 = true;
                    #line (229,18)-(229,37) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first39)
                        {
                            __first39 = false;
                        }
                        __cb.Push("        ");
                        #line (230,21)-(230,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (230,30)-(230,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (230,31)-(230,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (230,39)-(230,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (230,41)-(230,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (230,52)-(230,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (230,53)-(230,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (230,62)-(230,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (230,68)-(230,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (230,84)-(230,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (230,85)-(230,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (230,97)-(230,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (230,98)-(230,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (230,117)-(230,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (230,118)-(230,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (231,18)-(231,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first39)
                        {
                            __first39 = false;
                        }
                        __cb.Push("        ");
                        #line (232,21)-(232,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (232,30)-(232,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (232,31)-(232,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (232,38)-(232,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (232,40)-(232,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (232,51)-(232,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (232,52)-(232,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (232,61)-(232,66) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (232,67)-(232,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (232,83)-(232,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (232,84)-(232,96) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (232,96)-(232,97) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (232,97)-(232,116) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (232,116)-(232,117) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (232,117)-(232,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (233,21)-(233,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (234,25)-(234,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (234,31)-(234,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,32)-(234,68) 37 "SymbolGenerator.mxg"
                        __cb.Write("SymbolFactory.GetSymbolPropertyValue");
                        #line hidden
                        var __first40 = true;
                        #line (234,69)-(234,98) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first40)
                            {
                                __first40 = false;
                            }
                            #line (234,99)-(234,100) 41 "SymbolGenerator.mxg"
                            __cb.Write("s");
                            #line hidden
                        }
                        #line (234,108)-(234,109) 37 "SymbolGenerator.mxg"
                        __cb.Write("<");
                        #line hidden
                        #line (234,110)-(234,145) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type.Type));
                        #line hidden
                        #line (234,146)-(234,153) 37 "SymbolGenerator.mxg"
                        __cb.Write(">(this,");
                        #line hidden
                        #line (234,153)-(234,154) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,154)-(234,161) 37 "SymbolGenerator.mxg"
                        __cb.Write("nameof(");
                        #line hidden
                        #line (234,162)-(234,171) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Name);
                        #line hidden
                        #line (234,172)-(234,174) 37 "SymbolGenerator.mxg"
                        __cb.Write("),");
                        #line hidden
                        #line (234,174)-(234,175) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,175)-(234,187) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (234,187)-(234,188) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,188)-(234,207) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (235,21)-(235,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first39) __cb.AppendLine();
                }
                if (!__first35) __cb.AppendLine();
            }
            if (!__first34) __cb.AppendLine();
            __cb.Push("    ");
            #line (239,5)-(239,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (240,1)-(240,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (243,9)-(243,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (244,2)-(244,34) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (245,2)-(245,61) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            __cb.Push("");
            #line (246,1)-(246,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (246,6)-(246,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (246,7)-(246,14) 25 "SymbolGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (247,1)-(247,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (247,6)-(247,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,7)-(247,34) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Generic;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (248,1)-(248,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (248,6)-(248,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (248,7)-(248,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (249,1)-(249,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (249,6)-(249,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (249,7)-(249,19) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Linq;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (250,1)-(250,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (250,6)-(250,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (250,7)-(250,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (251,1)-(251,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (251,6)-(251,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (251,7)-(251,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (252,1)-(252,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (252,6)-(252,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (252,7)-(252,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (253,1)-(253,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (253,6)-(253,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,7)-(253,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (255,1)-(255,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (255,10)-(255,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (255,12)-(255,28) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.Namespace);
            #line hidden
            #line (255,29)-(255,44) 25 "SymbolGenerator.mxg"
            __cb.Write(".Implementation");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (256,1)-(256,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (257,5)-(257,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (257,10)-(257,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,11)-(257,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (257,18)-(257,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,19)-(257,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (257,20)-(257,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,21)-(257,45) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.Model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (258,5)-(258,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (258,10)-(258,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,11)-(258,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (258,25)-(258,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,26)-(258,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,27)-(258,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,28)-(258,59) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (259,5)-(259,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (259,10)-(259,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,11)-(259,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (259,20)-(259,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,21)-(259,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (259,22)-(259,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,23)-(259,54) 25 "SymbolGenerator.mxg"
            __cb.Write("Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (261,5)-(261,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (261,11)-(261,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,12)-(261,17) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (261,17)-(261,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,19)-(261,46) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (261,47)-(261,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,48)-(261,49) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (261,49)-(261,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,51)-(261,78) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (262,5)-(262,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (263,9)-(263,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (263,15)-(263,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,17)-(263,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (263,45)-(263,53) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol?");
            #line hidden
            #line (263,53)-(263,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,54)-(263,64) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (263,64)-(263,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,65)-(263,77) 25 "SymbolGenerator.mxg"
            __cb.Write("Compilation?");
            #line hidden
            #line (263,77)-(263,78) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,78)-(263,90) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (263,90)-(263,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,91)-(263,109) 25 "SymbolGenerator.mxg"
            __cb.Write("MergedDeclaration?");
            #line hidden
            #line (263,109)-(263,110) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,110)-(263,122) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (263,122)-(263,123) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,123)-(263,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (263,138)-(263,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,139)-(263,151) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (263,151)-(263,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,152)-(263,162) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol?");
            #line hidden
            #line (263,162)-(263,163) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,163)-(263,176) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (263,176)-(263,177) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,177)-(263,193) 25 "SymbolGenerator.mxg"
            __cb.Write("ErrorSymbolInfo?");
            #line hidden
            #line (263,193)-(263,194) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,194)-(263,204) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (263,204)-(263,205) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (264,13)-(264,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (264,14)-(264,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,15)-(264,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (264,30)-(264,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,31)-(264,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (264,43)-(264,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,44)-(264,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (264,56)-(264,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,57)-(264,63) 25 "SymbolGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (264,63)-(264,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,64)-(264,76) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (264,76)-(264,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,77)-(264,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (264,90)-(264,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,91)-(264,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (265,9)-(265,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (266,9)-(266,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (268,5)-(268,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (269,1)-(269,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (272,9)-(272,71) 22 "SymbolGenerator.mxg"
        public string AssignProperty(Symbol symbol, Property prop, string variable)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first41 = true;
            #line (273,6)-(273,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                var __first42 = true;
                #line (274,10)-(274,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.Push("");
                    #line (275,13)-(275,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (275,15)-(275,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (275,16)-(275,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("(!");
                    #line hidden
                    #line (275,19)-(275,27) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (275,28)-(275,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(".IsDefaultOrEmpty)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (276,13)-(276,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (277,18)-(277,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (277,37)-(277,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (277,47)-(277,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (277,49)-(277,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (277,58)-(277,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (278,13)-(278,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (279,10)-(279,14) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.Push("");
                    #line (280,13)-(280,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (280,15)-(280,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (280,16)-(280,17) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (280,18)-(280,26) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (280,27)-(280,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (280,28)-(280,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (280,30)-(280,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (280,32)-(280,61) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (280,62)-(280,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (281,13)-(281,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (282,18)-(282,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (282,37)-(282,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (282,47)-(282,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (282,49)-(282,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (282,58)-(282,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (283,13)-(283,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first42) __cb.AppendLine();
            }
            #line (285,6)-(285,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                __cb.Push("");
                #line (286,10)-(286,28) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (286,29)-(286,30) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (286,30)-(286,31) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (286,31)-(286,32) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (286,33)-(286,41) 28 "SymbolGenerator.mxg"
                __cb.Write(variable);
                #line hidden
                #line (286,42)-(286,43) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first41) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}