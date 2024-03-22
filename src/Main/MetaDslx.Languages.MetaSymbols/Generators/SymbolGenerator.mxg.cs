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
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (13,10)-(13,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,12)-(13,28) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.Namespace);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (15,5)-(15,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (15,10)-(15,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,11)-(15,17) 25 "SymbolGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (15,17)-(15,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,18)-(15,19) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (15,19)-(15,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,20)-(15,40) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Type;");
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
            #line (16,11)-(16,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (16,20)-(16,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,21)-(16,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (16,22)-(16,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,23)-(16,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
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
            #line (17,11)-(17,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__SymbolAttribute");
            #line hidden
            #line (17,28)-(17,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,29)-(17,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (17,30)-(17,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,31)-(17,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolAttribute;");
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
            #line (18,11)-(18,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__PhaseAttribute");
            #line hidden
            #line (18,27)-(18,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,28)-(18,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (18,29)-(18,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,30)-(18,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.PhaseAttribute;");
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
            #line (19,11)-(19,29) 25 "SymbolGenerator.mxg"
            __cb.Write("__DerivedAttribute");
            #line hidden
            #line (19,29)-(19,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,30)-(19,31) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (19,31)-(19,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,32)-(19,87) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DerivedAttribute;");
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
            #line (20,11)-(20,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__WeakAttribute");
            #line hidden
            #line (20,26)-(20,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,27)-(20,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (20,28)-(20,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,29)-(20,81) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.WeakAttribute;");
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
            #line (21,11)-(21,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (21,19)-(21,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,20)-(21,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (21,21)-(21,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,22)-(21,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
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
            #line (22,11)-(22,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__AttributeSymbol");
            #line hidden
            #line (22,28)-(22,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,29)-(22,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (22,30)-(22,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,31)-(22,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol;");
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
            #line (23,11)-(23,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__AssemblySymbol");
            #line hidden
            #line (23,27)-(23,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,28)-(23,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (23,29)-(23,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,30)-(23,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AssemblySymbol;");
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
            #line (24,11)-(24,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol");
            #line hidden
            #line (24,25)-(24,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,26)-(24,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (24,27)-(24,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,28)-(24,79) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModuleSymbol;");
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
            #line (25,11)-(25,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol");
            #line hidden
            #line (25,30)-(25,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,31)-(25,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (25,32)-(25,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,33)-(25,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol;");
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
            #line (26,11)-(26,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__NamespaceSymbol");
            #line hidden
            #line (26,28)-(26,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,29)-(26,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (26,30)-(26,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,31)-(26,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol;");
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
            #line (27,11)-(27,23) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol");
            #line hidden
            #line (27,23)-(27,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,24)-(27,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (27,25)-(27,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,26)-(27,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol;");
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
            #line (28,11)-(28,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbolFactory");
            #line hidden
            #line (28,27)-(28,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,28)-(28,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (28,29)-(28,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,30)-(28,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory;");
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
            __cb.Write("__LexicalSortKey");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.LexicalSortKey;");
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
            #line (30,11)-(30,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (30,25)-(30,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,26)-(30,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (30,27)-(30,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,28)-(30,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
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
            #line (31,11)-(31,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (31,18)-(31,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,19)-(31,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (31,20)-(31,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,21)-(31,53) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
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
            #line (32,11)-(32,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (32,28)-(32,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,29)-(32,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (32,30)-(32,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,31)-(32,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
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
            #line (33,11)-(33,35) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelPropertyAttribute");
            #line hidden
            #line (33,35)-(33,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,36)-(33,37) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (33,37)-(33,38) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,38)-(33,99) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
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
            #line (34,11)-(34,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (34,28)-(34,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,29)-(34,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (34,30)-(34,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,31)-(34,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
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
            #line (35,11)-(35,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (35,27)-(35,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,28)-(35,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (35,29)-(35,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,30)-(35,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
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
            #line (36,11)-(36,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (36,30)-(36,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (36,31)-(36,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (36,32)-(36,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (36,33)-(36,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
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
            #line (37,11)-(37,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (37,26)-(37,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,27)-(37,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (37,28)-(37,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,29)-(37,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
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
            #line (38,11)-(38,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (38,24)-(38,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,25)-(38,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (38,26)-(38,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,27)-(38,69) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Compilation;");
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
            #line (39,11)-(39,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (39,27)-(39,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,28)-(39,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (39,29)-(39,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,30)-(39,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
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
            #line (40,11)-(40,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (40,30)-(40,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,31)-(40,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (40,32)-(40,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,33)-(40,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
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
            #line (41,11)-(41,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (41,36)-(41,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,37)-(41,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (41,38)-(41,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,39)-(41,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
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
            #line (42,11)-(42,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__CultureInfo");
            #line hidden
            #line (42,24)-(42,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,25)-(42,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (42,26)-(42,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,27)-(42,68) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Globalization.CultureInfo;");
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
            #line (43,11)-(43,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (43,38)-(43,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,39)-(43,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (43,40)-(43,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,41)-(43,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            #line (45,6)-(45,38) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (46,6)-(46,65) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            #line (47,6)-(47,122) 13 "SymbolGenerator.mxg"
            var baseName = baseSymbol is null ? "global::MetaDslx.CodeAnalysis.Symbols.Symbol" : GetBaseName(symbol, baseSymbol);
            #line hidden
            
            __cb.Push("    ");
            #line (48,6)-(48,9) 24 "SymbolGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (48,10)-(48,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SymbolAttribute");
            #line hidden
            #line (48,28)-(48,31) 24 "SymbolGenerator.mxg"
            __cb.Write("]");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (49,5)-(49,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (49,11)-(49,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,12)-(49,20) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (49,20)-(49,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,21)-(49,28) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (49,28)-(49,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,29)-(49,34) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (49,34)-(49,35) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,36)-(49,63) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (49,64)-(49,65) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (49,65)-(49,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,67)-(49,75) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (50,5)-(50,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (51,9)-(51,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (51,15)-(51,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,16)-(51,19) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (51,19)-(51,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,20)-(51,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (51,25)-(51,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,26)-(51,41) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts");
            #line hidden
            #line (51,41)-(51,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,42)-(51,43) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (51,43)-(51,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,45)-(51,53) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            #line (51,54)-(51,70) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (52,9)-(52,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first1 = true;
            #line (53,14)-(53,54) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                __cb.Push("            ");
                #line (54,17)-(54,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (54,23)-(54,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (54,24)-(54,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (54,30)-(54,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (54,31)-(54,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (54,39)-(54,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (54,40)-(54,56) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart");
                #line hidden
                #line (54,56)-(54,57) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (54,57)-(54,63) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (54,64)-(54,69) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (54,70)-(54,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (54,71)-(54,72) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (54,72)-(54,73) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (54,73)-(54,76) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (54,76)-(54,77) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (54,77)-(54,107) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart(nameof(Start_");
                #line hidden
                #line (54,108)-(54,113) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (54,114)-(54,117) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
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
                #line (55,57)-(55,64) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (55,65)-(55,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (55,71)-(55,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (55,72)-(55,73) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (55,73)-(55,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (55,74)-(55,77) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (55,77)-(55,78) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (55,78)-(55,109) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart(nameof(Finish_");
                #line hidden
                #line (55,110)-(55,115) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (55,116)-(55,119) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first1) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (58,13)-(58,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (58,19)-(58,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,20)-(58,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (58,26)-(58,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,27)-(58,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (58,35)-(58,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,36)-(58,53) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (58,53)-(58,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,54)-(58,69) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (58,69)-(58,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,70)-(58,71) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (58,71)-(58,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (59,17)-(59,51) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph.CreateFromParts(");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (60,22)-(60,30) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            #line (60,31)-(60,63) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts.CompletionGraph");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first2 = true;
            #line (61,22)-(61,62) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first2)
                {
                    __first2 = false;
                }
                __cb.Push("                    ");
                #line (62,25)-(62,26) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (62,26)-(62,27) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (62,27)-(62,33) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (62,34)-(62,39) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (62,40)-(62,41) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (62,41)-(62,42) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (62,42)-(62,49) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (62,50)-(62,55) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            __cb.Push("                ");
            #line (64,17)-(64,19) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (65,9)-(65,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first3 = true;
            #line (67,10)-(67,75) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsAbstract))
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                var __first4 = true;
                #line (68,14)-(68,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first4)
                    {
                        __first4 = false;
                    }
                    __cb.Push("        ");
                    #line (69,17)-(69,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (69,24)-(69,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (69,25)-(69,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (69,31)-(69,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (69,33)-(69,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (69,60)-(69,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (69,62)-(69,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (69,81)-(69,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (69,82)-(69,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (69,83)-(69,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (69,84)-(69,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (69,87)-(69,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (69,89)-(69,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (69,116)-(69,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (70,14)-(70,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first4)
                    {
                        __first4 = false;
                    }
                    __cb.Push("        ");
                    #line (71,17)-(71,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (71,24)-(71,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (71,26)-(71,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (71,53)-(71,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (71,55)-(71,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (71,74)-(71,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first4) __cb.AppendLine();
            }
            if (!__first3) __cb.AppendLine();
            var __first5 = true;
            #line (74,10)-(74,70) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations.Where(o => o.IsCached))
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
                __cb.Push("        ");
                #line (75,13)-(75,20) 29 "SymbolGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (75,20)-(75,21) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (75,21)-(75,27) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (75,27)-(75,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (75,29)-(75,53) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (75,54)-(75,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (75,56)-(75,72) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(op));
                #line hidden
                #line (75,73)-(75,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (75,74)-(75,75) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (75,75)-(75,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (75,76)-(75,79) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (75,79)-(75,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (75,81)-(75,105) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (75,106)-(75,109) 29 "SymbolGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (78,9)-(78,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (78,15)-(78,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,17)-(78,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (78,45)-(78,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol?");
            #line hidden
            #line (78,55)-(78,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,56)-(78,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (78,66)-(78,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,67)-(78,81) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation?");
            #line hidden
            #line (78,81)-(78,82) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,82)-(78,94) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (78,94)-(78,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,95)-(78,115) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration?");
            #line hidden
            #line (78,115)-(78,116) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,116)-(78,128) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (78,128)-(78,129) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,129)-(78,144) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (78,144)-(78,145) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,145)-(78,157) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (78,157)-(78,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,158)-(78,168) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol?");
            #line hidden
            #line (78,168)-(78,169) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,169)-(78,182) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (78,182)-(78,183) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,183)-(78,201) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo?");
            #line hidden
            #line (78,201)-(78,202) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,202)-(78,212) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (78,212)-(78,213) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (79,13)-(79,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (79,14)-(79,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,15)-(79,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (79,30)-(79,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,31)-(79,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (79,43)-(79,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,44)-(79,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (79,56)-(79,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,57)-(79,69) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (79,69)-(79,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,70)-(79,83) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (79,83)-(79,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,84)-(79,94) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (80,9)-(80,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (81,9)-(81,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (83,9)-(83,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (83,15)-(83,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,16)-(83,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (83,24)-(83,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,25)-(83,31) 25 "SymbolGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (83,31)-(83,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,32)-(83,42) 25 "SymbolGenerator.mxg"
            __cb.Write("SymbolType");
            #line hidden
            #line (83,42)-(83,43) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,43)-(83,45) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (83,45)-(83,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,46)-(83,53) 25 "SymbolGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (83,54)-(83,81) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (83,82)-(83,84) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (84,9)-(84,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (84,18)-(84,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,19)-(84,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (84,27)-(84,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,28)-(84,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (84,45)-(84,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,46)-(84,61) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (84,61)-(84,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,62)-(84,64) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (84,64)-(84,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,65)-(84,97) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first6 = true;
            #line (86,10)-(86,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                var __first7 = true;
                #line (87,14)-(87,51) 17 "SymbolGenerator.mxg"
                if (!prop.IsDerived && !prop.IsPlain)
                #line hidden
                
                {
                    if (__first7)
                    {
                        __first7 = false;
                    }
                    __cb.Push("        ");
                    #line (88,18)-(88,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (88,22)-(88,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("__ModelPropertyAttribute");
                    #line hidden
                    #line (88,47)-(88,50) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first7) __cb.AppendLine();
                var __first8 = true;
                #line (90,14)-(90,32) 17 "SymbolGenerator.mxg"
                if (!prop.IsPlain)
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("        ");
                    #line (91,18)-(91,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (91,22)-(91,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("__PhaseAttribute");
                    #line hidden
                    var __first9 = true;
                    #line (91,39)-(91,66) 21 "SymbolGenerator.mxg"
                    if (prop.Phase is not null)
                    #line hidden
                    
                    {
                        if (__first9)
                        {
                            __first9 = false;
                        }
                        #line (91,67)-(91,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(nameof(");
                        #line hidden
                        #line (91,76)-(91,91) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Phase.Name);
                        #line hidden
                        #line (91,92)-(91,94) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                    }
                    #line (91,103)-(91,106) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first8) __cb.AppendLine();
                var __first10 = true;
                #line (93,14)-(93,33) 17 "SymbolGenerator.mxg"
                if (prop.IsDerived)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (94,18)-(94,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (94,22)-(94,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DerivedAttribute");
                    #line hidden
                    var __first11 = true;
                    #line (94,41)-(94,59) 21 "SymbolGenerator.mxg"
                    if (prop.IsCached)
                    #line hidden
                    
                    {
                        if (__first11)
                        {
                            __first11 = false;
                        }
                        #line (94,60)-(94,73) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true)");
                        #line hidden
                    }
                    #line (94,82)-(94,85) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                var __first12 = true;
                #line (96,14)-(96,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("        ");
                    #line (97,18)-(97,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (97,22)-(97,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("__WeakAttribute");
                    #line hidden
                    #line (97,38)-(97,41) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first12) __cb.AppendLine();
                __cb.Push("        ");
                #line (99,13)-(99,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (99,19)-(99,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first13 = true;
                #line (99,21)-(99,41) 17 "SymbolGenerator.mxg"
                if (prop.IsAbstract)
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    #line (99,42)-(99,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (99,50)-(99,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (99,60)-(99,90) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (99,91)-(99,92) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (99,93)-(99,102) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (100,13)-(100,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first14 = true;
                #line (101,18)-(101,35) 17 "SymbolGenerator.mxg"
                if (prop.IsPlain)
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    var __first15 = true;
                    #line (102,22)-(102,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsAbstract)
                    #line hidden
                    
                    {
                        if (__first15)
                        {
                            __first15 = false;
                        }
                        __cb.Push("            ");
                        #line (103,25)-(103,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("get;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (104,22)-(104,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first15)
                        {
                            __first15 = false;
                        }
                        var __first16 = true;
                        #line (105,26)-(105,42) 25 "SymbolGenerator.mxg"
                        if (prop.IsWeak)
                        #line hidden
                        
                        {
                            if (__first16)
                            {
                                __first16 = false;
                            }
                            __cb.Push("            ");
                            #line (106,29)-(106,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (107,29)-(107,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (108,33)-(108,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (108,35)-(108,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (108,36)-(108,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (108,38)-(108,56) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (108,57)-(108,75) 41 "SymbolGenerator.mxg"
                            __cb.Write(".TryGetValue(this,");
                            #line hidden
                            #line (108,75)-(108,76) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (108,76)-(108,79) 41 "SymbolGenerator.mxg"
                            __cb.Write("out");
                            #line hidden
                            #line (108,79)-(108,80) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (108,80)-(108,83) 41 "SymbolGenerator.mxg"
                            __cb.Write("var");
                            #line hidden
                            #line (108,83)-(108,84) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (108,84)-(108,92) 41 "SymbolGenerator.mxg"
                            __cb.Write("result))");
                            #line hidden
                            #line (108,92)-(108,93) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (108,93)-(108,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (108,99)-(108,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (108,100)-(108,101) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (108,102)-(108,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type));
                            #line hidden
                            #line (108,133)-(108,141) 41 "SymbolGenerator.mxg"
                            __cb.Write(")result;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (109,33)-(109,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("else");
                            #line hidden
                            #line (109,37)-(109,38) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (109,38)-(109,44) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (109,44)-(109,45) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (109,46)-(109,75) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (109,76)-(109,77) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (110,29)-(110,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (111,29)-(111,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (111,38)-(111,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (111,39)-(111,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (112,29)-(112,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (113,34)-(113,71) 40 "SymbolGenerator.mxg"
                            __cb.Write(AssignProperty(symbol, prop, "value"));
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (114,29)-(114,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (115,26)-(115,30) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first16)
                            {
                                __first16 = false;
                            }
                            __cb.Push("            ");
                            #line (116,29)-(116,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            #line (116,32)-(116,33) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (116,33)-(116,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (116,35)-(116,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (116,37)-(116,55) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (116,56)-(116,57) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (117,29)-(117,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (117,38)-(117,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (117,39)-(117,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
                            #line hidden
                            #line (117,42)-(117,43) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (117,43)-(117,45) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (117,45)-(117,46) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (117,47)-(117,65) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (117,66)-(117,67) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (117,67)-(117,68) 41 "SymbolGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (117,68)-(117,69) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (117,69)-(117,75) 41 "SymbolGenerator.mxg"
                            __cb.Write("value;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first16) __cb.AppendLine();
                    }
                    if (!__first15) __cb.AppendLine();
                }
                #line (120,18)-(120,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    __cb.Push("            ");
                    #line (121,21)-(121,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (122,21)-(122,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (123,25)-(123,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("this.ForceComplete(CompletionParts.Finish_");
                    #line hidden
                    #line (123,68)-(123,97) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (123,98)-(123,99) 33 "SymbolGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (123,99)-(123,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (123,100)-(123,105) 33 "SymbolGenerator.mxg"
                    __cb.Write("null,");
                    #line hidden
                    #line (123,105)-(123,106) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (123,106)-(123,115) 33 "SymbolGenerator.mxg"
                    __cb.Write("default);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first17 = true;
                    #line (124,26)-(124,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("                ");
                        #line (125,29)-(125,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (125,31)-(125,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,32)-(125,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (125,34)-(125,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (125,53)-(125,71) 37 "SymbolGenerator.mxg"
                        __cb.Write(".TryGetValue(this,");
                        #line hidden
                        #line (125,71)-(125,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,72)-(125,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("out");
                        #line hidden
                        #line (125,75)-(125,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,76)-(125,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (125,79)-(125,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,80)-(125,88) 37 "SymbolGenerator.mxg"
                        __cb.Write("result))");
                        #line hidden
                        #line (125,88)-(125,89) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,89)-(125,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (125,95)-(125,96) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,96)-(125,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (125,98)-(125,128) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (125,129)-(125,137) 37 "SymbolGenerator.mxg"
                        __cb.Write(")result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (126,29)-(126,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("else");
                        #line hidden
                        #line (126,33)-(126,34) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (126,34)-(126,40) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (126,40)-(126,41) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (126,42)-(126,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (126,72)-(126,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (127,26)-(127,30) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("                ");
                        #line (128,29)-(128,35) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (128,35)-(128,36) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (128,37)-(128,55) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (128,56)-(128,57) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first17) __cb.AppendLine();
                    __cb.Push("            ");
                    #line (130,21)-(130,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first14) __cb.AppendLine();
                __cb.Push("        ");
                #line (132,13)-(132,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first6) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first18 = true;
            #line (135,10)-(135,47) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations)
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                #line (136,14)-(136,90) 17 "SymbolGenerator.mxg"
                var arguments = "("+string.Join(", ", op.Parameters.Select(p => p.Name))+")";
                #line hidden
                
                #line (137,14)-(137,42) 17 "SymbolGenerator.mxg"
                var call = op.Name+arguments;
                #line hidden
                
                #line (138,14)-(138,65) 17 "SymbolGenerator.mxg"
                var returnType = GetTypeName(symbol, op.ReturnType);
                #line hidden
                
                __cb.WriteLine();
                __cb.Pop();
                var __first19 = true;
                #line (140,14)-(140,29) 17 "SymbolGenerator.mxg"
                if (op.IsPhase)
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("        ");
                    #line (141,18)-(141,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (141,22)-(141,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("__PhaseAttribute");
                    #line hidden
                    #line (141,39)-(141,42) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (142,17)-(142,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (142,26)-(142,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,27)-(142,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (142,35)-(142,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,36)-(142,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (142,40)-(142,41) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,42)-(142,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (142,50)-(142,66) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (142,66)-(142,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,67)-(142,79) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (142,79)-(142,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,80)-(142,99) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (142,99)-(142,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,100)-(142,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (143,14)-(143,35) 17 "SymbolGenerator.mxg"
                else if (op.IsCached)
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("        ");
                    #line (144,18)-(144,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (144,22)-(144,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DerivedAttribute");
                    #line hidden
                    var __first20 = true;
                    #line (144,41)-(144,57) 21 "SymbolGenerator.mxg"
                    if (op.IsCached)
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        #line (144,58)-(144,70) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true");
                        #line hidden
                        var __first21 = true;
                        #line (144,71)-(144,116) 25 "SymbolGenerator.mxg"
                        if (!string.IsNullOrEmpty(op.CacheCondition))
                        #line hidden
                        
                        {
                            if (__first21)
                            {
                                __first21 = false;
                            }
                            #line (144,117)-(144,118) 41 "SymbolGenerator.mxg"
                            __cb.Write(",");
                            #line hidden
                            #line (144,118)-(144,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (144,119)-(144,129) 41 "SymbolGenerator.mxg"
                            __cb.Write("Condition=");
                            #line hidden
                            #line (144,130)-(144,162) 40 "SymbolGenerator.mxg"
                            __cb.Write(op.CacheCondition.EncodeString());
                            #line hidden
                        }
                        #line (144,171)-(144,172) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                    }
                    #line (144,181)-(144,184) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (145,17)-(145,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (145,23)-(145,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (145,25)-(145,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (145,36)-(145,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (145,38)-(145,45) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (145,46)-(145,47) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first22 = true;
                    foreach (var __item23 in 
                    #line (145,48)-(145,118) 21 "SymbolGenerator.mxg"
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
                            #line (145,128)-(145,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item23);
                    }
                    #line (145,133)-(145,134) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (146,17)-(146,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first24 = true;
                    #line (147,22)-(147,67) 21 "SymbolGenerator.mxg"
                    if (!string.IsNullOrEmpty(op.CacheCondition))
                    #line hidden
                    
                    {
                        if (__first24)
                        {
                            __first24 = false;
                        }
                        __cb.Push("            ");
                        #line (148,25)-(148,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (148,27)-(148,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (148,28)-(148,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!(");
                        #line hidden
                        #line (148,32)-(148,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.CacheCondition);
                        #line hidden
                        #line (148,50)-(148,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                        #line (148,52)-(148,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (148,53)-(148,59) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (148,59)-(148,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (148,61)-(148,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, op.ReturnType));
                        #line hidden
                        #line (148,100)-(148,101) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first24) __cb.AppendLine();
                    #line (150,22)-(150,54) 21 "SymbolGenerator.mxg"
                    var fieldName = GetFieldName(op);
                    #line hidden
                    
                    var __first25 = true;
                    #line (151,22)-(151,51) 21 "SymbolGenerator.mxg"
                    if (op.Parameters.Count == 0)
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("            ");
                        #line (152,25)-(152,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (152,31)-(152,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,32)-(152,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (152,34)-(152,44) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (152,45)-(152,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (152,47)-(152,56) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (152,57)-(152,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (152,72)-(152,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,73)-(152,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (152,79)-(152,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,80)-(152,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (152,82)-(152,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,83)-(152,91) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (152,92)-(152,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.Name);
                        #line hidden
                        #line (152,101)-(152,110) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (152,111)-(152,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (153,22)-(153,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("            ");
                        #line (154,25)-(154,28) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (154,28)-(154,29) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,29)-(154,47) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary");
                        #line hidden
                        #line (154,47)-(154,48) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,48)-(154,49) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (154,49)-(154,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,51)-(154,60) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (154,61)-(154,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (154,76)-(154,77) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,77)-(154,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (154,83)-(154,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,84)-(154,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (154,86)-(154,87) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,87)-(154,90) 37 "SymbolGenerator.mxg"
                        __cb.Write("new");
                        #line hidden
                        #line (154,90)-(154,91) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,91)-(154,150) 37 "SymbolGenerator.mxg"
                        __cb.Write("global::System.Collections.Concurrent.ConcurrentDictionary<");
                        #line hidden
                        #line (154,151)-(154,178) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetCacheKeyType(symbol, op));
                        #line hidden
                        #line (154,179)-(154,180) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (154,180)-(154,181) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,182)-(154,192) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (154,193)-(154,198) 37 "SymbolGenerator.mxg"
                        __cb.Write(">());");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (155,25)-(155,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (155,31)-(155,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (155,32)-(155,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary.GetOrAdd(");
                        #line hidden
                        #line (155,61)-(155,70) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (155,71)-(155,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (155,72)-(155,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (155,73)-(155,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__args");
                        #line hidden
                        #line (155,79)-(155,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (155,80)-(155,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (155,82)-(155,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (155,83)-(155,91) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (155,92)-(155,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.Name);
                        #line hidden
                        #line (155,101)-(155,110) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (155,111)-(155,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first25) __cb.AppendLine();
                    __cb.Push("        ");
                    #line (157,17)-(157,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (159,17)-(159,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (159,26)-(159,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (159,27)-(159,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (159,35)-(159,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (159,37)-(159,47) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (159,48)-(159,49) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (159,49)-(159,57) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (159,58)-(159,65) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (159,66)-(159,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first26 = true;
                    foreach (var __item27 in 
                    #line (159,68)-(159,138) 21 "SymbolGenerator.mxg"
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
                            #line (159,148)-(159,152) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item27);
                    }
                    #line (159,153)-(159,155) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (160,14)-(160,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("        ");
                    #line (161,17)-(161,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (161,23)-(161,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,24)-(161,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (161,32)-(161,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,34)-(161,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (161,45)-(161,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,47)-(161,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (161,55)-(161,56) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first28 = true;
                    foreach (var __item29 in 
                    #line (161,57)-(161,127) 21 "SymbolGenerator.mxg"
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
                            #line (161,137)-(161,141) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item29);
                    }
                    #line (161,142)-(161,144) 33 "SymbolGenerator.mxg"
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
            #line (165,10)-(165,40) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            __cb.Push("        ");
            #line (166,9)-(166,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (166,18)-(166,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,19)-(166,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (166,27)-(166,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,28)-(166,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (166,32)-(166,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,33)-(166,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (166,54)-(166,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,55)-(166,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (166,71)-(166,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,72)-(166,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (166,87)-(166,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,88)-(166,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (166,105)-(166,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,106)-(166,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (166,118)-(166,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,119)-(166,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (166,138)-(166,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,139)-(166,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (167,9)-(167,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (168,14)-(168,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            var __first30 = true;
            #line (169,14)-(169,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                #line (170,18)-(170,36) 17 "SymbolGenerator.mxg"
                hasNewPhase = true;
                #line hidden
                
                #line (171,18)-(171,63) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                __cb.Push("            ");
                #line (172,17)-(172,19) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (172,19)-(172,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (172,20)-(172,35) 29 "SymbolGenerator.mxg"
                __cb.Write("(incompletePart");
                #line hidden
                #line (172,35)-(172,36) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (172,36)-(172,38) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (172,38)-(172,39) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (172,39)-(172,61) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Start_");
                #line hidden
                #line (172,62)-(172,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (172,68)-(172,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (172,69)-(172,71) 29 "SymbolGenerator.mxg"
                __cb.Write("||");
                #line hidden
                #line (172,71)-(172,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (172,72)-(172,86) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart");
                #line hidden
                #line (172,86)-(172,87) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (172,87)-(172,89) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (172,89)-(172,90) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (172,90)-(172,113) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Finish_");
                #line hidden
                #line (172,114)-(172,119) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (172,120)-(172,121) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (173,17)-(173,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (174,21)-(174,23) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (174,23)-(174,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,24)-(174,64) 29 "SymbolGenerator.mxg"
                __cb.Write("(NotePartComplete(CompletionParts.Start_");
                #line hidden
                #line (174,65)-(174,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (174,71)-(174,73) 29 "SymbolGenerator.mxg"
                __cb.Write("))");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (175,21)-(175,22) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (176,25)-(176,28) 29 "SymbolGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (176,28)-(176,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (176,29)-(176,40) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics");
                #line hidden
                #line (176,40)-(176,41) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (176,41)-(176,42) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (176,42)-(176,43) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (176,43)-(176,73) 29 "SymbolGenerator.mxg"
                __cb.Write("__DiagnosticBag.GetInstance();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first31 = true;
                #line (177,26)-(177,48) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("                    ");
                    #line (178,29)-(178,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (178,32)-(178,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (178,33)-(178,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (178,39)-(178,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (178,40)-(178,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (178,41)-(178,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (178,42)-(178,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (178,51)-(178,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (178,57)-(178,70) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (178,70)-(178,71) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (178,71)-(178,90) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first32 = true;
                    #line (179,30)-(179,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        __cb.Push("                    ");
                        #line (180,34)-(180,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first32) __cb.AppendLine();
                }
                #line (182,26)-(182,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    #line (183,30)-(183,49) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    __cb.Push("                    ");
                    #line (184,29)-(184,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (184,32)-(184,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (184,33)-(184,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (184,39)-(184,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (184,40)-(184,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (184,41)-(184,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (184,42)-(184,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (184,51)-(184,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (184,57)-(184,70) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (184,70)-(184,71) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (184,71)-(184,90) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (185,30)-(185,68) 32 "SymbolGenerator.mxg"
                    __cb.Write(AssignProperty(symbol, prop, "result"));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (186,26)-(186,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("                    ");
                    #line (187,30)-(187,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (187,36)-(187,49) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (187,49)-(187,50) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (187,50)-(187,69) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first31) __cb.AppendLine();
                __cb.Push("                    ");
                #line (189,25)-(189,59) 29 "SymbolGenerator.mxg"
                __cb.Write("AddSymbolDiagnostics(diagnostics);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (190,25)-(190,44) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics.Free();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (191,25)-(191,65) 29 "SymbolGenerator.mxg"
                __cb.Write("NotePartComplete(CompletionParts.Finish_");
                #line hidden
                #line (191,66)-(191,71) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (191,72)-(191,74) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (192,21)-(192,22) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (193,21)-(193,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (193,27)-(193,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (193,28)-(193,33) 29 "SymbolGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (194,17)-(194,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (195,17)-(195,21) 29 "SymbolGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (195,21)-(195,22) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first30) __cb.AppendLine();
            var __first33 = true;
            #line (197,14)-(197,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("            ");
                #line (198,17)-(198,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (199,21)-(199,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (199,27)-(199,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (199,28)-(199,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (199,54)-(199,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (199,55)-(199,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (199,70)-(199,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (199,71)-(199,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (199,83)-(199,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (199,84)-(199,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (200,17)-(200,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (201,14)-(201,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("            ");
                #line (202,17)-(202,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (202,23)-(202,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,24)-(202,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (202,50)-(202,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,51)-(202,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (202,66)-(202,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,67)-(202,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (202,79)-(202,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,80)-(202,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first33) __cb.AppendLine();
            __cb.Push("        ");
            #line (204,9)-(204,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first34 = true;
            #line (206,10)-(206,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (208,14)-(208,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first35 = true;
                #line (209,14)-(209,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    #line (210,18)-(210,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    var __first36 = true;
                    #line (211,18)-(211,58) 21 "SymbolGenerator.mxg"
                    if (props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first36)
                        {
                            __first36 = false;
                        }
                        __cb.Push("        ");
                        #line (212,21)-(212,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (212,30)-(212,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,31)-(212,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (212,39)-(212,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,41)-(212,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (212,52)-(212,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,53)-(212,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (212,62)-(212,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (212,68)-(212,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (212,84)-(212,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,85)-(212,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (212,97)-(212,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,98)-(212,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (212,117)-(212,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,118)-(212,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (213,18)-(213,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first36)
                        {
                            __first36 = false;
                        }
                        __cb.Push("        ");
                        #line (214,21)-(214,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (214,30)-(214,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (214,31)-(214,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (214,38)-(214,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (214,40)-(214,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (214,51)-(214,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (214,52)-(214,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (214,61)-(214,66) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (214,67)-(214,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (214,83)-(214,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (214,84)-(214,96) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (214,96)-(214,97) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (214,97)-(214,116) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (214,116)-(214,117) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (214,117)-(214,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (215,21)-(215,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = true;
                        __cb.Push("            ");
                        #line (217,25)-(217,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (217,31)-(217,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (217,32)-(217,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first37 = true;
                        #line (218,30)-(218,58) 25 "SymbolGenerator.mxg"
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
                                #line (218,68)-(218,72) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Push("                ");
                            #line (219,33)-(219,69) 41 "SymbolGenerator.mxg"
                            __cb.Write("SymbolFactory.GetSymbolPropertyValue");
                            #line hidden
                            var __first38 = true;
                            #line (219,70)-(219,99) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first38)
                                {
                                    __first38 = false;
                                }
                                #line (219,100)-(219,101) 45 "SymbolGenerator.mxg"
                                __cb.Write("s");
                                #line hidden
                            }
                            #line (219,109)-(219,110) 41 "SymbolGenerator.mxg"
                            __cb.Write("<");
                            #line hidden
                            #line (219,111)-(219,146) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type.Type));
                            #line hidden
                            #line (219,147)-(219,154) 41 "SymbolGenerator.mxg"
                            __cb.Write(">(this,");
                            #line hidden
                            #line (219,154)-(219,155) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (219,155)-(219,162) 41 "SymbolGenerator.mxg"
                            __cb.Write("nameof(");
                            #line hidden
                            #line (219,163)-(219,172) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (219,173)-(219,175) 41 "SymbolGenerator.mxg"
                            __cb.Write("),");
                            #line hidden
                            #line (219,175)-(219,176) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (219,176)-(219,188) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (219,188)-(219,189) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (219,189)-(219,208) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first37) __cb.AppendLine();
                        __cb.Push("            ");
                        #line (221,25)-(221,27) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = false;
                        __cb.AppendLine();
                        __cb.Push("        ");
                        #line (223,21)-(223,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first36) __cb.AppendLine();
                }
                #line (225,14)-(225,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    #line (226,18)-(226,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (227,18)-(227,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    var __first39 = true;
                    #line (228,18)-(228,37) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first39)
                        {
                            __first39 = false;
                        }
                        __cb.Push("        ");
                        #line (229,21)-(229,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (229,30)-(229,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,31)-(229,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (229,39)-(229,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,41)-(229,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (229,52)-(229,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,53)-(229,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (229,62)-(229,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (229,68)-(229,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (229,84)-(229,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,85)-(229,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (229,97)-(229,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,98)-(229,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (229,117)-(229,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,118)-(229,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (230,18)-(230,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first39)
                        {
                            __first39 = false;
                        }
                        __cb.Push("        ");
                        #line (231,21)-(231,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (231,30)-(231,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,31)-(231,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (231,38)-(231,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,40)-(231,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (231,51)-(231,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,52)-(231,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (231,61)-(231,66) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (231,67)-(231,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (231,83)-(231,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,84)-(231,96) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (231,96)-(231,97) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,97)-(231,116) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (231,116)-(231,117) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,117)-(231,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (232,21)-(232,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (233,25)-(233,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (233,31)-(233,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (233,32)-(233,68) 37 "SymbolGenerator.mxg"
                        __cb.Write("SymbolFactory.GetSymbolPropertyValue");
                        #line hidden
                        var __first40 = true;
                        #line (233,69)-(233,98) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first40)
                            {
                                __first40 = false;
                            }
                            #line (233,99)-(233,100) 41 "SymbolGenerator.mxg"
                            __cb.Write("s");
                            #line hidden
                        }
                        #line (233,108)-(233,109) 37 "SymbolGenerator.mxg"
                        __cb.Write("<");
                        #line hidden
                        #line (233,110)-(233,145) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type.Type));
                        #line hidden
                        #line (233,146)-(233,153) 37 "SymbolGenerator.mxg"
                        __cb.Write(">(this,");
                        #line hidden
                        #line (233,153)-(233,154) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (233,154)-(233,161) 37 "SymbolGenerator.mxg"
                        __cb.Write("nameof(");
                        #line hidden
                        #line (233,162)-(233,171) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Name);
                        #line hidden
                        #line (233,172)-(233,174) 37 "SymbolGenerator.mxg"
                        __cb.Write("),");
                        #line hidden
                        #line (233,174)-(233,175) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (233,175)-(233,187) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (233,187)-(233,188) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (233,188)-(233,207) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (234,21)-(234,22) 37 "SymbolGenerator.mxg"
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
            #line (238,5)-(238,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (239,1)-(239,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (242,9)-(242,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (243,2)-(243,34) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (244,2)-(244,61) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            __cb.Push("");
            #line (245,1)-(245,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (245,6)-(245,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (245,7)-(245,14) 25 "SymbolGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (246,1)-(246,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (246,6)-(246,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (246,7)-(246,34) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Generic;");
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
            #line (247,7)-(247,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
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
            #line (248,7)-(248,19) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Linq;");
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
            #line (249,7)-(249,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
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
            #line (250,7)-(250,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
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
            #line (251,7)-(251,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
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
            #line (252,7)-(252,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (254,1)-(254,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (254,10)-(254,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (254,12)-(254,28) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.Namespace);
            #line hidden
            #line (254,29)-(254,44) 25 "SymbolGenerator.mxg"
            __cb.Write(".Implementation");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (255,1)-(255,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (256,5)-(256,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (256,10)-(256,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,11)-(256,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (256,18)-(256,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,19)-(256,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (256,20)-(256,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,21)-(256,45) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.Model;");
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
            #line (257,11)-(257,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (257,25)-(257,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,26)-(257,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (257,27)-(257,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,28)-(257,59) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.IModelObject;");
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
            #line (258,11)-(258,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (258,20)-(258,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,21)-(258,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,22)-(258,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,23)-(258,54) 25 "SymbolGenerator.mxg"
            __cb.Write("Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (260,5)-(260,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (260,11)-(260,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,12)-(260,17) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (260,17)-(260,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,19)-(260,46) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (260,47)-(260,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,48)-(260,49) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (260,49)-(260,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,51)-(260,78) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (261,5)-(261,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (262,9)-(262,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (262,15)-(262,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,17)-(262,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (262,45)-(262,53) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol?");
            #line hidden
            #line (262,53)-(262,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,54)-(262,64) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (262,64)-(262,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,65)-(262,77) 25 "SymbolGenerator.mxg"
            __cb.Write("Compilation?");
            #line hidden
            #line (262,77)-(262,78) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,78)-(262,90) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (262,90)-(262,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,91)-(262,109) 25 "SymbolGenerator.mxg"
            __cb.Write("MergedDeclaration?");
            #line hidden
            #line (262,109)-(262,110) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,110)-(262,122) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (262,122)-(262,123) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,123)-(262,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (262,138)-(262,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,139)-(262,151) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (262,151)-(262,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,152)-(262,162) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol?");
            #line hidden
            #line (262,162)-(262,163) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,163)-(262,176) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (262,176)-(262,177) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,177)-(262,193) 25 "SymbolGenerator.mxg"
            __cb.Write("ErrorSymbolInfo?");
            #line hidden
            #line (262,193)-(262,194) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,194)-(262,204) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (262,204)-(262,205) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (263,13)-(263,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (263,14)-(263,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,15)-(263,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (263,30)-(263,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,31)-(263,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (263,43)-(263,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,44)-(263,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (263,56)-(263,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,57)-(263,63) 25 "SymbolGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (263,63)-(263,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,64)-(263,76) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (263,76)-(263,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,77)-(263,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (263,90)-(263,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,91)-(263,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (264,9)-(264,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (265,9)-(265,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (267,5)-(267,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (268,1)-(268,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (271,9)-(271,71) 22 "SymbolGenerator.mxg"
        public string AssignProperty(Symbol symbol, Property prop, string variable)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first41 = true;
            #line (272,6)-(272,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                var __first42 = true;
                #line (273,10)-(273,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.Push("");
                    #line (274,13)-(274,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (274,15)-(274,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (274,16)-(274,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("(!");
                    #line hidden
                    #line (274,19)-(274,27) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (274,28)-(274,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(".IsDefaultOrEmpty)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (275,13)-(275,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (276,18)-(276,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (276,37)-(276,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (276,47)-(276,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (276,49)-(276,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (276,58)-(276,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (277,13)-(277,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (278,10)-(278,14) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.Push("");
                    #line (279,13)-(279,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (279,15)-(279,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (279,16)-(279,17) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (279,18)-(279,26) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (279,27)-(279,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (279,28)-(279,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (279,30)-(279,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (279,32)-(279,61) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (279,62)-(279,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (280,13)-(280,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (281,18)-(281,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (281,37)-(281,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (281,47)-(281,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (281,49)-(281,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (281,58)-(281,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (282,13)-(282,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first42) __cb.AppendLine();
            }
            #line (284,6)-(284,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                __cb.Push("");
                #line (285,10)-(285,28) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (285,29)-(285,30) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (285,30)-(285,31) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (285,31)-(285,32) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (285,33)-(285,41) 28 "SymbolGenerator.mxg"
                __cb.Write(variable);
                #line hidden
                #line (285,42)-(285,43) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first41) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}