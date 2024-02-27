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
            #line (11,1)-(11,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (11,10)-(11,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,12)-(11,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (12,1)-(12,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (13,5)-(13,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (13,10)-(13,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,11)-(13,17) 25 "SymbolGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (13,17)-(13,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,18)-(13,19) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (13,19)-(13,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,20)-(13,40) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Type;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (14,5)-(14,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (14,10)-(14,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,11)-(14,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (14,20)-(14,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,21)-(14,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (14,22)-(14,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,23)-(14,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
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
            #line (15,11)-(15,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__SymbolAttribute");
            #line hidden
            #line (15,28)-(15,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,29)-(15,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (15,30)-(15,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,31)-(15,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolAttribute;");
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
            #line (16,11)-(16,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__PhaseAttribute");
            #line hidden
            #line (16,27)-(16,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,28)-(16,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (16,29)-(16,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,30)-(16,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.PhaseAttribute;");
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
            #line (17,11)-(17,29) 25 "SymbolGenerator.mxg"
            __cb.Write("__DerivedAttribute");
            #line hidden
            #line (17,29)-(17,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,30)-(17,31) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (17,31)-(17,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,32)-(17,87) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DerivedAttribute;");
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
            #line (18,11)-(18,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__WeakAttribute");
            #line hidden
            #line (18,26)-(18,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,27)-(18,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (18,28)-(18,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,29)-(18,81) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.WeakAttribute;");
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
            #line (19,11)-(19,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (19,19)-(19,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,20)-(19,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (19,21)-(19,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,22)-(19,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
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
            #line (20,11)-(20,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__AttributeSymbol");
            #line hidden
            #line (20,28)-(20,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,29)-(20,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (20,30)-(20,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,31)-(20,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol;");
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
            #line (21,11)-(21,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__AssemblySymbol");
            #line hidden
            #line (21,27)-(21,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,28)-(21,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (21,29)-(21,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,30)-(21,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AssemblySymbol;");
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
            #line (22,11)-(22,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol");
            #line hidden
            #line (22,25)-(22,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,26)-(22,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (22,27)-(22,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,28)-(22,79) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModuleSymbol;");
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
            #line (23,11)-(23,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol");
            #line hidden
            #line (23,30)-(23,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,31)-(23,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (23,32)-(23,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,33)-(23,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol;");
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
            #line (24,11)-(24,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__NamespaceSymbol");
            #line hidden
            #line (24,28)-(24,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,29)-(24,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (24,30)-(24,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,31)-(24,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol;");
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
            #line (25,11)-(25,23) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol");
            #line hidden
            #line (25,23)-(25,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,24)-(25,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (25,25)-(25,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,26)-(25,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol;");
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
            #line (26,11)-(26,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbolFactory");
            #line hidden
            #line (26,27)-(26,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,28)-(26,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (26,29)-(26,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,30)-(26,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory;");
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
            #line (27,11)-(27,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__LexicalSortKey");
            #line hidden
            #line (27,27)-(27,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,28)-(27,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (27,29)-(27,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,30)-(27,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.LexicalSortKey;");
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
            #line (28,11)-(28,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (28,25)-(28,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,26)-(28,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (28,27)-(28,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,28)-(28,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
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
            #line (29,11)-(29,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (29,18)-(29,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,19)-(29,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (29,20)-(29,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,21)-(29,53) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
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
            #line (30,11)-(30,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (30,28)-(30,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,29)-(30,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (30,30)-(30,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,31)-(30,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
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
            #line (31,11)-(31,35) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelPropertyAttribute");
            #line hidden
            #line (31,35)-(31,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,36)-(31,37) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (31,37)-(31,38) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,38)-(31,99) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
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
            __cb.Write("__CompletionGraph");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
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
            #line (33,11)-(33,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (33,27)-(33,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,28)-(33,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (33,29)-(33,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,30)-(33,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
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
            #line (34,11)-(34,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (34,30)-(34,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,31)-(34,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (34,32)-(34,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,33)-(34,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
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
            #line (35,11)-(35,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (35,26)-(35,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,27)-(35,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (35,28)-(35,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,29)-(35,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
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
            #line (36,11)-(36,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (36,24)-(36,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (36,25)-(36,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (36,26)-(36,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (36,27)-(36,69) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Compilation;");
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
            #line (37,11)-(37,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (37,27)-(37,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,28)-(37,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (37,29)-(37,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,30)-(37,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
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
            #line (38,11)-(38,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (38,30)-(38,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,31)-(38,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (38,32)-(38,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,33)-(38,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
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
            #line (39,11)-(39,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (39,36)-(39,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,37)-(39,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (39,38)-(39,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,39)-(39,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
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
            #line (40,11)-(40,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__CultureInfo");
            #line hidden
            #line (40,24)-(40,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,25)-(40,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (40,26)-(40,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,27)-(40,68) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Globalization.CultureInfo;");
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
            #line (41,11)-(41,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (41,38)-(41,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,39)-(41,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (41,40)-(41,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,41)-(41,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            #line (43,6)-(43,38) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (44,6)-(44,65) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            #line (45,6)-(45,122) 13 "SymbolGenerator.mxg"
            var baseName = baseSymbol is null ? "global::MetaDslx.CodeAnalysis.Symbols.Symbol" : GetBaseName(symbol, baseSymbol);
            #line hidden
            
            __cb.Push("    ");
            #line (46,6)-(46,9) 24 "SymbolGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (46,10)-(46,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SymbolAttribute");
            #line hidden
            #line (46,28)-(46,31) 24 "SymbolGenerator.mxg"
            __cb.Write("]");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (47,5)-(47,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (47,11)-(47,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,12)-(47,20) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (47,20)-(47,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,21)-(47,28) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (47,28)-(47,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,29)-(47,34) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (47,34)-(47,35) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,36)-(47,63) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (47,64)-(47,65) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (47,65)-(47,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,67)-(47,75) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (48,5)-(48,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (49,9)-(49,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (49,15)-(49,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,16)-(49,19) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (49,19)-(49,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,20)-(49,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (49,25)-(49,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,26)-(49,41) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts");
            #line hidden
            #line (49,41)-(49,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,42)-(49,43) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (49,43)-(49,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,45)-(49,53) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            #line (49,54)-(49,70) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (50,9)-(50,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first1 = true;
            #line (51,14)-(51,54) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                __cb.Push("            ");
                #line (52,17)-(52,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (52,23)-(52,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (52,24)-(52,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (52,30)-(52,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (52,31)-(52,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (52,39)-(52,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (52,40)-(52,56) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart");
                #line hidden
                #line (52,56)-(52,57) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (52,57)-(52,63) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (52,64)-(52,69) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (52,70)-(52,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (52,71)-(52,72) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (52,72)-(52,73) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (52,73)-(52,76) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (52,76)-(52,77) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (52,77)-(52,107) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart(nameof(Start_");
                #line hidden
                #line (52,108)-(52,113) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (52,114)-(52,117) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (53,17)-(53,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (53,23)-(53,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (53,24)-(53,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (53,30)-(53,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (53,31)-(53,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (53,39)-(53,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (53,40)-(53,56) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart");
                #line hidden
                #line (53,56)-(53,57) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (53,57)-(53,64) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (53,65)-(53,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (53,71)-(53,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (53,72)-(53,73) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (53,73)-(53,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (53,74)-(53,77) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (53,77)-(53,78) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (53,78)-(53,109) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart(nameof(Finish_");
                #line hidden
                #line (53,110)-(53,115) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (53,116)-(53,119) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first1) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (56,13)-(56,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (56,19)-(56,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,20)-(56,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (56,26)-(56,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,27)-(56,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (56,35)-(56,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,36)-(56,53) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (56,53)-(56,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,54)-(56,69) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (56,69)-(56,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,70)-(56,71) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (56,71)-(56,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (57,17)-(57,51) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph.CreateFromParts(");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (58,22)-(58,30) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            #line (58,31)-(58,63) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts.CompletionGraph");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first2 = true;
            #line (59,22)-(59,62) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first2)
                {
                    __first2 = false;
                }
                __cb.Push("                    ");
                #line (60,25)-(60,26) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (60,26)-(60,27) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,27)-(60,33) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (60,34)-(60,39) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (60,40)-(60,41) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (60,41)-(60,42) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,42)-(60,49) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (60,50)-(60,55) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            __cb.Push("                ");
            #line (62,17)-(62,19) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (63,9)-(63,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first3 = true;
            #line (65,10)-(65,75) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsAbstract))
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                var __first4 = true;
                #line (66,14)-(66,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first4)
                    {
                        __first4 = false;
                    }
                    __cb.Push("        ");
                    #line (67,17)-(67,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (67,24)-(67,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (67,25)-(67,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (67,31)-(67,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (67,33)-(67,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (67,60)-(67,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (67,62)-(67,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (67,81)-(67,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (67,82)-(67,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (67,83)-(67,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (67,84)-(67,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (67,87)-(67,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (67,89)-(67,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (67,116)-(67,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (68,14)-(68,18) 17 "SymbolGenerator.mxg"
                else
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
                    #line (69,26)-(69,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (69,53)-(69,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (69,55)-(69,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (69,74)-(69,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first4) __cb.AppendLine();
            }
            if (!__first3) __cb.AppendLine();
            var __first5 = true;
            #line (72,10)-(72,70) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations.Where(o => o.IsCached))
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
                __cb.Push("        ");
                #line (73,13)-(73,20) 29 "SymbolGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (73,20)-(73,21) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (73,21)-(73,27) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (73,27)-(73,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (73,29)-(73,53) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (73,54)-(73,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (73,56)-(73,72) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(op));
                #line hidden
                #line (73,73)-(73,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (73,74)-(73,75) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (73,75)-(73,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (73,76)-(73,79) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (73,79)-(73,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (73,81)-(73,105) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (73,106)-(73,109) 29 "SymbolGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (76,9)-(76,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (76,15)-(76,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,17)-(76,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (76,45)-(76,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol?");
            #line hidden
            #line (76,55)-(76,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,56)-(76,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (76,66)-(76,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,67)-(76,81) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation?");
            #line hidden
            #line (76,81)-(76,82) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,82)-(76,93) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation");
            #line hidden
            #line (76,93)-(76,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,94)-(76,95) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,95)-(76,96) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,96)-(76,101) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (76,101)-(76,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,102)-(76,122) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration?");
            #line hidden
            #line (76,122)-(76,123) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,123)-(76,134) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration");
            #line hidden
            #line (76,134)-(76,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,135)-(76,136) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,136)-(76,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,137)-(76,142) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (76,142)-(76,143) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,143)-(76,151) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model?");
            #line hidden
            #line (76,151)-(76,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,152)-(76,157) 25 "SymbolGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (76,157)-(76,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,158)-(76,159) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,159)-(76,160) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,160)-(76,165) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (76,165)-(76,166) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,166)-(76,181) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (76,181)-(76,182) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,182)-(76,193) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (76,193)-(76,194) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,194)-(76,195) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,195)-(76,196) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,196)-(76,201) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (76,201)-(76,202) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,202)-(76,211) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (76,211)-(76,212) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,212)-(76,224) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol");
            #line hidden
            #line (76,224)-(76,225) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,225)-(76,226) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,226)-(76,227) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,227)-(76,232) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (76,232)-(76,233) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,233)-(76,251) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo?");
            #line hidden
            #line (76,251)-(76,252) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,252)-(76,261) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo");
            #line hidden
            #line (76,261)-(76,262) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,262)-(76,263) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,263)-(76,264) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,264)-(76,269) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (76,269)-(76,270) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,270)-(76,274) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (76,274)-(76,275) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,275)-(76,286) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol");
            #line hidden
            #line (76,286)-(76,287) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,287)-(76,288) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,288)-(76,289) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,289)-(76,295) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (76,295)-(76,296) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,296)-(76,303) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (76,303)-(76,304) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,304)-(76,308) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (76,308)-(76,309) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,309)-(76,310) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,310)-(76,311) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,311)-(76,319) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (76,319)-(76,320) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,320)-(76,327) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (76,327)-(76,328) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,328)-(76,340) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (76,340)-(76,341) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,341)-(76,342) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,342)-(76,343) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,343)-(76,351) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (76,351)-(76,352) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,352)-(76,422) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>");
            #line hidden
            #line (76,422)-(76,423) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,423)-(76,433) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (76,433)-(76,434) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,434)-(76,435) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,435)-(76,436) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,436)-(76,443) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first6 = true;
            #line (76,444)-(76,529) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsAbstract && !p.IsDerived))
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                #line (76,530)-(76,531) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (76,531)-(76,532) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,533)-(76,563) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (76,564)-(76,565) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,566)-(76,584) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (76,585)-(76,586) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,586)-(76,587) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (76,587)-(76,588) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,589)-(76,623) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (76,637)-(76,638) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (76,638)-(76,639) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (77,13)-(77,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (77,14)-(77,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,15)-(77,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (77,30)-(77,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,31)-(77,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (77,43)-(77,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,44)-(77,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (77,56)-(77,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,57)-(77,63) 25 "SymbolGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (77,63)-(77,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,64)-(77,76) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (77,76)-(77,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,77)-(77,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (77,90)-(77,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,91)-(77,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (77,101)-(77,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,102)-(77,114) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol,");
            #line hidden
            #line (77,114)-(77,115) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,115)-(77,120) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (77,120)-(77,121) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,121)-(77,134) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (77,134)-(77,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,135)-(77,145) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first7 = true;
            #line (77,146)-(77,235) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsAbstract && !p.IsDerived))
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (77,236)-(77,237) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (77,237)-(77,238) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (77,239)-(77,257) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (77,258)-(77,259) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (77,259)-(77,260) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (77,261)-(77,279) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (77,293)-(77,294) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (78,9)-(78,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (79,13)-(79,15) 25 "SymbolGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (79,15)-(79,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,16)-(79,29) 25 "SymbolGenerator.mxg"
            __cb.Write("(fixedSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (80,13)-(80,14) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first8 = true;
            #line (81,18)-(81,99) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsAbstract && !p.IsDerived))
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                __cb.Push("                ");
                #line (82,22)-(82,70) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first8) __cb.AppendLine();
            __cb.Push("            ");
            #line (84,13)-(84,14) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (85,9)-(85,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (87,9)-(87,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (87,15)-(87,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,16)-(87,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (87,24)-(87,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,25)-(87,31) 25 "SymbolGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (87,31)-(87,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,32)-(87,42) 25 "SymbolGenerator.mxg"
            __cb.Write("SymbolType");
            #line hidden
            #line (87,42)-(87,43) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,43)-(87,45) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (87,45)-(87,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,46)-(87,53) 25 "SymbolGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (87,54)-(87,81) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (87,82)-(87,84) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (88,9)-(88,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (88,18)-(88,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,19)-(88,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (88,27)-(88,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,28)-(88,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (88,45)-(88,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,46)-(88,61) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (88,61)-(88,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,62)-(88,64) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (88,64)-(88,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,65)-(88,97) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first9 = true;
            #line (90,10)-(90,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                var __first10 = true;
                #line (91,14)-(91,51) 17 "SymbolGenerator.mxg"
                if (!prop.IsDerived && !prop.IsPlain)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (92,18)-(92,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (92,22)-(92,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("__ModelPropertyAttribute");
                    #line hidden
                    #line (92,47)-(92,50) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                var __first11 = true;
                #line (94,14)-(94,32) 17 "SymbolGenerator.mxg"
                if (!prop.IsPlain)
                #line hidden
                
                {
                    if (__first11)
                    {
                        __first11 = false;
                    }
                    __cb.Push("        ");
                    #line (95,18)-(95,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (95,22)-(95,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("__PhaseAttribute");
                    #line hidden
                    var __first12 = true;
                    #line (95,39)-(95,66) 21 "SymbolGenerator.mxg"
                    if (prop.Phase is not null)
                    #line hidden
                    
                    {
                        if (__first12)
                        {
                            __first12 = false;
                        }
                        #line (95,67)-(95,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(nameof(");
                        #line hidden
                        #line (95,76)-(95,91) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Phase.Name);
                        #line hidden
                        #line (95,92)-(95,94) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                    }
                    #line (95,103)-(95,106) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first11) __cb.AppendLine();
                var __first13 = true;
                #line (97,14)-(97,33) 17 "SymbolGenerator.mxg"
                if (prop.IsDerived)
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    __cb.Push("        ");
                    #line (98,18)-(98,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (98,22)-(98,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DerivedAttribute");
                    #line hidden
                    var __first14 = true;
                    #line (98,41)-(98,59) 21 "SymbolGenerator.mxg"
                    if (prop.IsCached)
                    #line hidden
                    
                    {
                        if (__first14)
                        {
                            __first14 = false;
                        }
                        #line (98,60)-(98,73) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true)");
                        #line hidden
                    }
                    #line (98,82)-(98,85) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first13) __cb.AppendLine();
                var __first15 = true;
                #line (100,14)-(100,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first15)
                    {
                        __first15 = false;
                    }
                    __cb.Push("        ");
                    #line (101,18)-(101,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (101,22)-(101,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("__WeakAttribute");
                    #line hidden
                    #line (101,38)-(101,41) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first15) __cb.AppendLine();
                __cb.Push("        ");
                #line (103,13)-(103,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (103,19)-(103,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first16 = true;
                #line (103,21)-(103,41) 17 "SymbolGenerator.mxg"
                if (prop.IsAbstract)
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    #line (103,42)-(103,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (103,50)-(103,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (103,60)-(103,90) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (103,91)-(103,92) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (103,93)-(103,102) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (104,13)-(104,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first17 = true;
                #line (105,18)-(105,35) 17 "SymbolGenerator.mxg"
                if (prop.IsPlain)
                #line hidden
                
                {
                    if (__first17)
                    {
                        __first17 = false;
                    }
                    var __first18 = true;
                    #line (106,22)-(106,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsAbstract)
                    #line hidden
                    
                    {
                        if (__first18)
                        {
                            __first18 = false;
                        }
                        __cb.Push("            ");
                        #line (107,25)-(107,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("get;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (108,22)-(108,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first18)
                        {
                            __first18 = false;
                        }
                        var __first19 = true;
                        #line (109,26)-(109,42) 25 "SymbolGenerator.mxg"
                        if (prop.IsWeak)
                        #line hidden
                        
                        {
                            if (__first19)
                            {
                                __first19 = false;
                            }
                            __cb.Push("            ");
                            #line (110,29)-(110,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (111,29)-(111,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (112,33)-(112,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (112,35)-(112,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (112,36)-(112,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (112,38)-(112,56) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (112,57)-(112,75) 41 "SymbolGenerator.mxg"
                            __cb.Write(".TryGetValue(this,");
                            #line hidden
                            #line (112,75)-(112,76) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (112,76)-(112,79) 41 "SymbolGenerator.mxg"
                            __cb.Write("out");
                            #line hidden
                            #line (112,79)-(112,80) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (112,80)-(112,83) 41 "SymbolGenerator.mxg"
                            __cb.Write("var");
                            #line hidden
                            #line (112,83)-(112,84) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (112,84)-(112,92) 41 "SymbolGenerator.mxg"
                            __cb.Write("result))");
                            #line hidden
                            #line (112,92)-(112,93) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (112,93)-(112,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (112,99)-(112,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (112,100)-(112,101) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (112,102)-(112,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type));
                            #line hidden
                            #line (112,133)-(112,141) 41 "SymbolGenerator.mxg"
                            __cb.Write(")result;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (113,33)-(113,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("else");
                            #line hidden
                            #line (113,37)-(113,38) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (113,38)-(113,44) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (113,44)-(113,45) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (113,46)-(113,75) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (113,76)-(113,77) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (114,29)-(114,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (115,29)-(115,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (115,38)-(115,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (115,39)-(115,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (116,29)-(116,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (117,34)-(117,71) 40 "SymbolGenerator.mxg"
                            __cb.Write(AssignProperty(symbol, prop, "value"));
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (118,29)-(118,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (119,26)-(119,30) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first19)
                            {
                                __first19 = false;
                            }
                            __cb.Push("            ");
                            #line (120,29)-(120,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            #line (120,32)-(120,33) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (120,33)-(120,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (120,35)-(120,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (120,37)-(120,55) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (120,56)-(120,57) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (121,29)-(121,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (121,38)-(121,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (121,39)-(121,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
                            #line hidden
                            #line (121,42)-(121,43) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (121,43)-(121,45) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (121,45)-(121,46) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (121,47)-(121,65) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (121,66)-(121,67) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (121,67)-(121,68) 41 "SymbolGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (121,68)-(121,69) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (121,69)-(121,75) 41 "SymbolGenerator.mxg"
                            __cb.Write("value;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first19) __cb.AppendLine();
                    }
                    if (!__first18) __cb.AppendLine();
                }
                #line (124,18)-(124,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first17)
                    {
                        __first17 = false;
                    }
                    __cb.Push("            ");
                    #line (125,21)-(125,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (126,21)-(126,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (127,25)-(127,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("this.ForceComplete(CompletionParts.Finish_");
                    #line hidden
                    #line (127,68)-(127,97) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (127,98)-(127,99) 33 "SymbolGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (127,99)-(127,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (127,100)-(127,105) 33 "SymbolGenerator.mxg"
                    __cb.Write("null,");
                    #line hidden
                    #line (127,105)-(127,106) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (127,106)-(127,115) 33 "SymbolGenerator.mxg"
                    __cb.Write("default);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first20 = true;
                    #line (128,26)-(128,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        __cb.Push("                ");
                        #line (129,29)-(129,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (129,31)-(129,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (129,32)-(129,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (129,34)-(129,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (129,53)-(129,71) 37 "SymbolGenerator.mxg"
                        __cb.Write(".TryGetValue(this,");
                        #line hidden
                        #line (129,71)-(129,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (129,72)-(129,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("out");
                        #line hidden
                        #line (129,75)-(129,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (129,76)-(129,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (129,79)-(129,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (129,80)-(129,88) 37 "SymbolGenerator.mxg"
                        __cb.Write("result))");
                        #line hidden
                        #line (129,88)-(129,89) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (129,89)-(129,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (129,95)-(129,96) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (129,96)-(129,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (129,98)-(129,128) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (129,129)-(129,137) 37 "SymbolGenerator.mxg"
                        __cb.Write(")result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (130,29)-(130,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("else");
                        #line hidden
                        #line (130,33)-(130,34) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (130,34)-(130,40) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (130,40)-(130,41) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (130,42)-(130,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (130,72)-(130,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (131,26)-(131,30) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        __cb.Push("                ");
                        #line (132,29)-(132,35) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (132,35)-(132,36) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (132,37)-(132,55) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (132,56)-(132,57) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first20) __cb.AppendLine();
                    __cb.Push("            ");
                    #line (134,21)-(134,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first17) __cb.AppendLine();
                __cb.Push("        ");
                #line (136,13)-(136,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first21 = true;
            #line (139,10)-(139,47) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations)
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                #line (140,14)-(140,90) 17 "SymbolGenerator.mxg"
                var arguments = "("+string.Join(", ", op.Parameters.Select(p => p.Name))+")";
                #line hidden
                
                #line (141,14)-(141,42) 17 "SymbolGenerator.mxg"
                var call = op.Name+arguments;
                #line hidden
                
                #line (142,14)-(142,65) 17 "SymbolGenerator.mxg"
                var returnType = GetTypeName(symbol, op.ReturnType);
                #line hidden
                
                __cb.WriteLine();
                __cb.Pop();
                var __first22 = true;
                #line (144,14)-(144,29) 17 "SymbolGenerator.mxg"
                if (op.IsPhase)
                #line hidden
                
                {
                    if (__first22)
                    {
                        __first22 = false;
                    }
                    __cb.Push("        ");
                    #line (145,18)-(145,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (145,22)-(145,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("__PhaseAttribute");
                    #line hidden
                    #line (145,39)-(145,42) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (146,17)-(146,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (146,26)-(146,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,27)-(146,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (146,35)-(146,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,36)-(146,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (146,40)-(146,41) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,42)-(146,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (146,50)-(146,66) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (146,66)-(146,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,67)-(146,79) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (146,79)-(146,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,80)-(146,99) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (146,99)-(146,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,100)-(146,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (147,14)-(147,35) 17 "SymbolGenerator.mxg"
                else if (op.IsCached)
                #line hidden
                
                {
                    if (__first22)
                    {
                        __first22 = false;
                    }
                    __cb.Push("        ");
                    #line (148,18)-(148,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (148,22)-(148,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DerivedAttribute");
                    #line hidden
                    var __first23 = true;
                    #line (148,41)-(148,57) 21 "SymbolGenerator.mxg"
                    if (op.IsCached)
                    #line hidden
                    
                    {
                        if (__first23)
                        {
                            __first23 = false;
                        }
                        #line (148,58)-(148,70) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true");
                        #line hidden
                        var __first24 = true;
                        #line (148,71)-(148,116) 25 "SymbolGenerator.mxg"
                        if (!string.IsNullOrEmpty(op.CacheCondition))
                        #line hidden
                        
                        {
                            if (__first24)
                            {
                                __first24 = false;
                            }
                            #line (148,117)-(148,118) 41 "SymbolGenerator.mxg"
                            __cb.Write(",");
                            #line hidden
                            #line (148,118)-(148,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (148,119)-(148,129) 41 "SymbolGenerator.mxg"
                            __cb.Write("Condition=");
                            #line hidden
                            #line (148,130)-(148,162) 40 "SymbolGenerator.mxg"
                            __cb.Write(op.CacheCondition.EncodeString());
                            #line hidden
                        }
                        #line (148,171)-(148,172) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                    }
                    #line (148,181)-(148,184) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (149,17)-(149,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (149,23)-(149,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (149,25)-(149,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (149,36)-(149,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (149,38)-(149,45) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (149,46)-(149,47) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first25 = true;
                    foreach (var __item26 in 
                    #line (149,48)-(149,118) 21 "SymbolGenerator.mxg"
                    from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                    #line hidden
                    )
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        else
                        {
                            __cb.Push("        ");
                            __cb.DontIgnoreLastLineEnd = true;
                            #line (149,128)-(149,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item26);
                    }
                    #line (149,133)-(149,134) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (150,17)-(150,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first27 = true;
                    #line (151,22)-(151,67) 21 "SymbolGenerator.mxg"
                    if (!string.IsNullOrEmpty(op.CacheCondition))
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
                        }
                        __cb.Push("            ");
                        #line (152,25)-(152,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (152,27)-(152,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,28)-(152,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!(");
                        #line hidden
                        #line (152,32)-(152,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.CacheCondition);
                        #line hidden
                        #line (152,50)-(152,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                        #line (152,52)-(152,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,53)-(152,59) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (152,59)-(152,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,61)-(152,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, op.ReturnType));
                        #line hidden
                        #line (152,100)-(152,101) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first27) __cb.AppendLine();
                    #line (154,22)-(154,54) 21 "SymbolGenerator.mxg"
                    var fieldName = GetFieldName(op);
                    #line hidden
                    
                    var __first28 = true;
                    #line (155,22)-(155,51) 21 "SymbolGenerator.mxg"
                    if (op.Parameters.Count == 0)
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        __cb.Push("            ");
                        #line (156,25)-(156,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (156,31)-(156,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,32)-(156,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (156,34)-(156,44) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (156,45)-(156,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (156,47)-(156,56) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (156,57)-(156,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (156,72)-(156,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,73)-(156,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
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
                    #line (157,22)-(157,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        __cb.Push("            ");
                        #line (158,25)-(158,28) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (158,28)-(158,29) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (158,29)-(158,47) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary");
                        #line hidden
                        #line (158,47)-(158,48) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (158,48)-(158,49) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (158,49)-(158,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (158,51)-(158,60) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (158,61)-(158,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (158,76)-(158,77) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (158,77)-(158,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (158,83)-(158,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (158,84)-(158,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (158,86)-(158,87) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (158,87)-(158,90) 37 "SymbolGenerator.mxg"
                        __cb.Write("new");
                        #line hidden
                        #line (158,90)-(158,91) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (158,91)-(158,150) 37 "SymbolGenerator.mxg"
                        __cb.Write("global::System.Collections.Concurrent.ConcurrentDictionary<");
                        #line hidden
                        #line (158,151)-(158,178) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetCacheKeyType(symbol, op));
                        #line hidden
                        #line (158,179)-(158,180) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (158,180)-(158,181) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (158,182)-(158,192) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (158,193)-(158,198) 37 "SymbolGenerator.mxg"
                        __cb.Write(">());");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (159,25)-(159,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (159,31)-(159,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (159,32)-(159,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary.GetOrAdd(");
                        #line hidden
                        #line (159,61)-(159,70) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (159,71)-(159,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (159,72)-(159,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (159,73)-(159,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__args");
                        #line hidden
                        #line (159,79)-(159,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (159,80)-(159,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (159,82)-(159,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (159,83)-(159,91) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (159,92)-(159,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.Name);
                        #line hidden
                        #line (159,101)-(159,110) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (159,111)-(159,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first28) __cb.AppendLine();
                    __cb.Push("        ");
                    #line (161,17)-(161,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (163,17)-(163,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (163,26)-(163,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (163,27)-(163,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (163,35)-(163,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (163,37)-(163,47) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (163,48)-(163,49) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (163,49)-(163,57) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (163,58)-(163,65) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (163,66)-(163,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first29 = true;
                    foreach (var __item30 in 
                    #line (163,68)-(163,138) 21 "SymbolGenerator.mxg"
                    from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                    #line hidden
                    )
                    {
                        if (__first29)
                        {
                            __first29 = false;
                        }
                        else
                        {
                            __cb.Push("        ");
                            __cb.DontIgnoreLastLineEnd = true;
                            #line (163,148)-(163,152) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item30);
                    }
                    #line (163,153)-(163,155) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (164,14)-(164,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first22)
                    {
                        __first22 = false;
                    }
                    __cb.Push("        ");
                    #line (165,17)-(165,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (165,23)-(165,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (165,24)-(165,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (165,32)-(165,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (165,34)-(165,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (165,45)-(165,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (165,47)-(165,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (165,55)-(165,56) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first31 = true;
                    foreach (var __item32 in 
                    #line (165,57)-(165,127) 21 "SymbolGenerator.mxg"
                    from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                    #line hidden
                    )
                    {
                        if (__first31)
                        {
                            __first31 = false;
                        }
                        else
                        {
                            __cb.Push("        ");
                            __cb.DontIgnoreLastLineEnd = true;
                            #line (165,137)-(165,141) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item32);
                    }
                    #line (165,142)-(165,144) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first22) __cb.AppendLine();
            }
            if (!__first21) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            #line (169,10)-(169,40) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            __cb.Push("        ");
            #line (170,9)-(170,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (170,18)-(170,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,19)-(170,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (170,27)-(170,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,28)-(170,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (170,32)-(170,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,33)-(170,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (170,54)-(170,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,55)-(170,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (170,71)-(170,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,72)-(170,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (170,87)-(170,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,88)-(170,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (170,105)-(170,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,106)-(170,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (170,118)-(170,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,119)-(170,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (170,138)-(170,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,139)-(170,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (171,9)-(171,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (172,14)-(172,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            var __first33 = true;
            #line (173,14)-(173,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                #line (174,18)-(174,36) 17 "SymbolGenerator.mxg"
                hasNewPhase = true;
                #line hidden
                
                #line (175,18)-(175,63) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                __cb.Push("            ");
                #line (176,17)-(176,19) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (176,19)-(176,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (176,20)-(176,35) 29 "SymbolGenerator.mxg"
                __cb.Write("(incompletePart");
                #line hidden
                #line (176,35)-(176,36) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (176,36)-(176,38) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (176,38)-(176,39) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (176,39)-(176,61) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Start_");
                #line hidden
                #line (176,62)-(176,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (176,68)-(176,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (176,69)-(176,71) 29 "SymbolGenerator.mxg"
                __cb.Write("||");
                #line hidden
                #line (176,71)-(176,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (176,72)-(176,86) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart");
                #line hidden
                #line (176,86)-(176,87) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (176,87)-(176,89) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (176,89)-(176,90) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (176,90)-(176,113) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Finish_");
                #line hidden
                #line (176,114)-(176,119) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (176,120)-(176,121) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (177,17)-(177,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (178,21)-(178,23) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (178,23)-(178,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,24)-(178,64) 29 "SymbolGenerator.mxg"
                __cb.Write("(NotePartComplete(CompletionParts.Start_");
                #line hidden
                #line (178,65)-(178,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (178,71)-(178,73) 29 "SymbolGenerator.mxg"
                __cb.Write("))");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (179,21)-(179,22) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (180,25)-(180,28) 29 "SymbolGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (180,28)-(180,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (180,29)-(180,40) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics");
                #line hidden
                #line (180,40)-(180,41) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (180,41)-(180,42) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (180,42)-(180,43) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (180,43)-(180,73) 29 "SymbolGenerator.mxg"
                __cb.Write("__DiagnosticBag.GetInstance();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first34 = true;
                #line (181,26)-(181,48) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
                    }
                    __cb.Push("                    ");
                    #line (182,29)-(182,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (182,32)-(182,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (182,33)-(182,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (182,39)-(182,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (182,40)-(182,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (182,41)-(182,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (182,42)-(182,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (182,51)-(182,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (182,57)-(182,70) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (182,70)-(182,71) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (182,71)-(182,90) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first35 = true;
                    #line (183,30)-(183,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first35)
                        {
                            __first35 = false;
                        }
                        __cb.Push("                    ");
                        #line (184,34)-(184,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first35) __cb.AppendLine();
                }
                #line (186,26)-(186,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
                    }
                    __cb.Push("                    ");
                    #line (187,29)-(187,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (187,32)-(187,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (187,33)-(187,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (187,39)-(187,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (187,40)-(187,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (187,41)-(187,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (187,42)-(187,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (187,51)-(187,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (187,57)-(187,70) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (187,70)-(187,71) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (187,71)-(187,90) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (188,30)-(188,72) 32 "SymbolGenerator.mxg"
                    __cb.Write(AssignProperty(symbol, props[0], "result"));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (189,26)-(189,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
                    }
                    __cb.Push("                    ");
                    #line (190,30)-(190,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (190,36)-(190,49) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (190,49)-(190,50) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (190,50)-(190,69) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first34) __cb.AppendLine();
                __cb.Push("                    ");
                #line (192,25)-(192,59) 29 "SymbolGenerator.mxg"
                __cb.Write("AddSymbolDiagnostics(diagnostics);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (193,25)-(193,44) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics.Free();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (194,25)-(194,65) 29 "SymbolGenerator.mxg"
                __cb.Write("NotePartComplete(CompletionParts.Finish_");
                #line hidden
                #line (194,66)-(194,71) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (194,72)-(194,74) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (195,21)-(195,22) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (196,21)-(196,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (196,27)-(196,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (196,28)-(196,33) 29 "SymbolGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (197,17)-(197,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (198,17)-(198,21) 29 "SymbolGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (198,21)-(198,22) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first33) __cb.AppendLine();
            var __first36 = true;
            #line (200,14)-(200,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("            ");
                #line (201,17)-(201,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (202,21)-(202,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (202,27)-(202,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,28)-(202,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (202,54)-(202,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,55)-(202,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (202,70)-(202,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,71)-(202,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (202,83)-(202,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,84)-(202,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (203,17)-(203,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (204,14)-(204,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("            ");
                #line (205,17)-(205,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (205,23)-(205,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,24)-(205,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (205,50)-(205,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,51)-(205,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (205,66)-(205,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,67)-(205,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (205,79)-(205,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,80)-(205,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first36) __cb.AppendLine();
            __cb.Push("        ");
            #line (207,9)-(207,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first37 = true;
            #line (209,10)-(209,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (211,14)-(211,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first38 = true;
                #line (212,14)-(212,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first38)
                    {
                        __first38 = false;
                    }
                    #line (213,18)-(213,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    var __first39 = true;
                    #line (214,18)-(214,58) 21 "SymbolGenerator.mxg"
                    if (props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first39)
                        {
                            __first39 = false;
                        }
                        __cb.Push("        ");
                        #line (215,21)-(215,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (215,30)-(215,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,31)-(215,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (215,39)-(215,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,41)-(215,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (215,52)-(215,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,53)-(215,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (215,62)-(215,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (215,68)-(215,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (215,84)-(215,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,85)-(215,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (215,97)-(215,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,98)-(215,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (215,117)-(215,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,118)-(215,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (216,18)-(216,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first39)
                        {
                            __first39 = false;
                        }
                        __cb.Push("        ");
                        #line (217,21)-(217,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (217,30)-(217,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (217,31)-(217,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (217,38)-(217,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (217,40)-(217,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (217,51)-(217,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (217,52)-(217,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (217,61)-(217,66) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (217,67)-(217,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (217,83)-(217,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (217,84)-(217,96) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (217,96)-(217,97) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (217,97)-(217,116) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (217,116)-(217,117) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (217,117)-(217,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (218,21)-(218,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = true;
                        __cb.Push("            ");
                        #line (220,25)-(220,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (220,31)-(220,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (220,32)-(220,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first40 = true;
                        #line (221,30)-(221,58) 25 "SymbolGenerator.mxg"
                        foreach (var prop in props) 
                        #line hidden
                        
                        {
                            if (__first40)
                            {
                                __first40 = false;
                            }
                            else
                            {
                                __cb.Push("                ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (221,68)-(221,72) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Push("                ");
                            #line (222,33)-(222,69) 41 "SymbolGenerator.mxg"
                            __cb.Write("SymbolFactory.GetSymbolPropertyValue");
                            #line hidden
                            var __first41 = true;
                            #line (222,70)-(222,99) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first41)
                                {
                                    __first41 = false;
                                }
                                #line (222,100)-(222,101) 45 "SymbolGenerator.mxg"
                                __cb.Write("s");
                                #line hidden
                            }
                            #line (222,109)-(222,110) 41 "SymbolGenerator.mxg"
                            __cb.Write("<");
                            #line hidden
                            #line (222,111)-(222,146) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type.Type));
                            #line hidden
                            #line (222,147)-(222,154) 41 "SymbolGenerator.mxg"
                            __cb.Write(">(this,");
                            #line hidden
                            #line (222,154)-(222,155) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (222,155)-(222,162) 41 "SymbolGenerator.mxg"
                            __cb.Write("nameof(");
                            #line hidden
                            #line (222,163)-(222,172) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (222,173)-(222,175) 41 "SymbolGenerator.mxg"
                            __cb.Write("),");
                            #line hidden
                            #line (222,175)-(222,176) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (222,176)-(222,188) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (222,188)-(222,189) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (222,189)-(222,208) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first40) __cb.AppendLine();
                        __cb.Push("            ");
                        #line (224,25)-(224,27) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = false;
                        __cb.AppendLine();
                        __cb.Push("        ");
                        #line (226,21)-(226,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first39) __cb.AppendLine();
                }
                #line (228,14)-(228,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first38)
                    {
                        __first38 = false;
                    }
                    #line (229,18)-(229,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (230,18)-(230,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    var __first42 = true;
                    #line (231,18)-(231,37) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first42)
                        {
                            __first42 = false;
                        }
                        __cb.Push("        ");
                        #line (232,21)-(232,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (232,30)-(232,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (232,31)-(232,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (232,39)-(232,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (232,41)-(232,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (232,52)-(232,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (232,53)-(232,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (232,62)-(232,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (232,68)-(232,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (232,84)-(232,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (232,85)-(232,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (232,97)-(232,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (232,98)-(232,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (232,117)-(232,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (232,118)-(232,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (233,18)-(233,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first42)
                        {
                            __first42 = false;
                        }
                        __cb.Push("        ");
                        #line (234,21)-(234,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (234,30)-(234,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,31)-(234,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (234,38)-(234,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,40)-(234,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (234,51)-(234,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,52)-(234,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (234,61)-(234,66) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (234,67)-(234,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (234,83)-(234,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,84)-(234,96) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (234,96)-(234,97) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,97)-(234,116) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (234,116)-(234,117) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,117)-(234,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (235,21)-(235,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (236,25)-(236,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (236,31)-(236,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (236,32)-(236,68) 37 "SymbolGenerator.mxg"
                        __cb.Write("SymbolFactory.GetSymbolPropertyValue");
                        #line hidden
                        var __first43 = true;
                        #line (236,69)-(236,98) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first43)
                            {
                                __first43 = false;
                            }
                            #line (236,99)-(236,100) 41 "SymbolGenerator.mxg"
                            __cb.Write("s");
                            #line hidden
                        }
                        #line (236,108)-(236,109) 37 "SymbolGenerator.mxg"
                        __cb.Write("<");
                        #line hidden
                        #line (236,110)-(236,145) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type.Type));
                        #line hidden
                        #line (236,146)-(236,153) 37 "SymbolGenerator.mxg"
                        __cb.Write(">(this,");
                        #line hidden
                        #line (236,153)-(236,154) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (236,154)-(236,161) 37 "SymbolGenerator.mxg"
                        __cb.Write("nameof(");
                        #line hidden
                        #line (236,162)-(236,171) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Name);
                        #line hidden
                        #line (236,172)-(236,174) 37 "SymbolGenerator.mxg"
                        __cb.Write("),");
                        #line hidden
                        #line (236,174)-(236,175) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (236,175)-(236,187) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (236,187)-(236,188) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (236,188)-(236,207) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (237,21)-(237,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first42) __cb.AppendLine();
                }
                if (!__first38) __cb.AppendLine();
            }
            if (!__first37) __cb.AppendLine();
            __cb.Push("    ");
            #line (241,5)-(241,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (242,1)-(242,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (245,9)-(245,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (246,2)-(246,34) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (247,2)-(247,61) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            __cb.Push("");
            #line (248,1)-(248,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (248,6)-(248,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (248,7)-(248,14) 25 "SymbolGenerator.mxg"
            __cb.Write("System;");
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
            #line (249,7)-(249,34) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Generic;");
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
            #line (250,7)-(250,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
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
            #line (251,7)-(251,19) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Linq;");
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
            #line (252,7)-(252,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
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
            #line (253,7)-(253,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (254,1)-(254,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (254,6)-(254,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (254,7)-(254,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (255,1)-(255,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (255,6)-(255,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (255,7)-(255,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (257,1)-(257,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (257,10)-(257,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,12)-(257,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (257,33)-(257,38) 25 "SymbolGenerator.mxg"
            __cb.Write(".Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (258,1)-(258,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
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
            #line (259,11)-(259,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (259,18)-(259,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,19)-(259,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (259,20)-(259,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,21)-(259,45) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.Model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (260,5)-(260,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (260,10)-(260,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,11)-(260,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (260,25)-(260,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,26)-(260,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (260,27)-(260,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,28)-(260,59) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (261,5)-(261,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (261,10)-(261,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,11)-(261,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (261,20)-(261,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,21)-(261,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (261,22)-(261,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,23)-(261,54) 25 "SymbolGenerator.mxg"
            __cb.Write("Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (263,5)-(263,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (263,11)-(263,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,12)-(263,17) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (263,17)-(263,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,19)-(263,46) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (263,47)-(263,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,48)-(263,49) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (263,49)-(263,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,51)-(263,78) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (264,5)-(264,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (265,9)-(265,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (265,15)-(265,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,17)-(265,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (265,45)-(265,53) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol?");
            #line hidden
            #line (265,53)-(265,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,54)-(265,64) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (265,64)-(265,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,65)-(265,77) 25 "SymbolGenerator.mxg"
            __cb.Write("Compilation?");
            #line hidden
            #line (265,77)-(265,78) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,78)-(265,89) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation");
            #line hidden
            #line (265,89)-(265,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,90)-(265,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (265,91)-(265,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,92)-(265,97) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (265,97)-(265,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,98)-(265,116) 25 "SymbolGenerator.mxg"
            __cb.Write("MergedDeclaration?");
            #line hidden
            #line (265,116)-(265,117) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,117)-(265,128) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration");
            #line hidden
            #line (265,128)-(265,129) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,129)-(265,130) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (265,130)-(265,131) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,131)-(265,136) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (265,136)-(265,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,137)-(265,145) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model?");
            #line hidden
            #line (265,145)-(265,146) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,146)-(265,151) 25 "SymbolGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (265,151)-(265,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,152)-(265,153) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (265,153)-(265,154) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,154)-(265,159) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (265,159)-(265,160) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,160)-(265,175) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (265,175)-(265,176) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,176)-(265,187) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (265,187)-(265,188) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,188)-(265,189) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (265,189)-(265,190) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,190)-(265,195) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (265,195)-(265,196) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,196)-(265,205) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (265,205)-(265,206) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,206)-(265,218) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol");
            #line hidden
            #line (265,218)-(265,219) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,219)-(265,220) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (265,220)-(265,221) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,221)-(265,226) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (265,226)-(265,227) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,227)-(265,243) 25 "SymbolGenerator.mxg"
            __cb.Write("ErrorSymbolInfo?");
            #line hidden
            #line (265,243)-(265,244) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,244)-(265,253) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo");
            #line hidden
            #line (265,253)-(265,254) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,254)-(265,255) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (265,255)-(265,256) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,256)-(265,261) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (265,261)-(265,262) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,262)-(265,266) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (265,266)-(265,267) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,267)-(265,278) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol");
            #line hidden
            #line (265,278)-(265,279) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,279)-(265,280) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (265,280)-(265,281) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,281)-(265,287) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (265,287)-(265,288) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,288)-(265,295) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (265,295)-(265,296) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,296)-(265,300) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (265,300)-(265,301) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,301)-(265,302) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (265,302)-(265,303) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,303)-(265,311) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (265,311)-(265,312) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,312)-(265,319) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (265,319)-(265,320) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,320)-(265,332) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (265,332)-(265,333) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,333)-(265,334) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (265,334)-(265,335) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,335)-(265,343) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (265,343)-(265,344) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,344)-(265,412) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>");
            #line hidden
            #line (265,412)-(265,413) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,413)-(265,423) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (265,423)-(265,424) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,424)-(265,425) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (265,425)-(265,426) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,426)-(265,433) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first44 = true;
            #line (265,434)-(265,502) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                #line (265,503)-(265,504) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (265,504)-(265,505) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (265,506)-(265,536) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (265,537)-(265,538) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (265,539)-(265,557) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (265,558)-(265,559) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (265,559)-(265,560) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (265,560)-(265,561) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (265,562)-(265,596) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (265,610)-(265,611) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (265,611)-(265,612) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (266,13)-(266,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (266,14)-(266,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,15)-(266,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (266,30)-(266,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,31)-(266,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (266,43)-(266,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,44)-(266,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (266,56)-(266,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,57)-(266,63) 25 "SymbolGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (266,63)-(266,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,64)-(266,76) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (266,76)-(266,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,77)-(266,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (266,90)-(266,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,91)-(266,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (266,101)-(266,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,102)-(266,114) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol,");
            #line hidden
            #line (266,114)-(266,115) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,115)-(266,120) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (266,120)-(266,121) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,121)-(266,134) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (266,134)-(266,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,135)-(266,145) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first45 = true;
            #line (266,146)-(266,218) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                #line (266,219)-(266,220) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (266,220)-(266,221) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (266,222)-(266,240) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (266,241)-(266,242) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (266,242)-(266,243) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (266,244)-(266,262) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (266,276)-(266,277) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (267,9)-(267,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (268,9)-(268,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (270,5)-(270,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (271,1)-(271,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (274,9)-(274,71) 22 "SymbolGenerator.mxg"
        public string AssignProperty(Symbol symbol, Property prop, string variable)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first46 = true;
            #line (275,6)-(275,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                var __first47 = true;
                #line (276,10)-(276,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first47)
                    {
                        __first47 = false;
                    }
                    __cb.Push("");
                    #line (277,13)-(277,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (277,15)-(277,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (277,16)-(277,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("(!");
                    #line hidden
                    #line (277,19)-(277,27) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (277,28)-(277,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(".IsDefaultOrEmpty)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (278,13)-(278,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (279,18)-(279,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (279,37)-(279,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (279,47)-(279,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (279,49)-(279,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (279,58)-(279,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (280,13)-(280,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (281,10)-(281,14) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first47)
                    {
                        __first47 = false;
                    }
                    __cb.Push("");
                    #line (282,13)-(282,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (282,15)-(282,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (282,16)-(282,17) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (282,18)-(282,26) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (282,27)-(282,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (282,28)-(282,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (282,30)-(282,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (282,32)-(282,61) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (282,62)-(282,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (283,13)-(283,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (284,18)-(284,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (284,37)-(284,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (284,47)-(284,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (284,49)-(284,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (284,58)-(284,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (285,13)-(285,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first47) __cb.AppendLine();
            }
            #line (287,6)-(287,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                __cb.Push("");
                #line (288,10)-(288,28) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (288,29)-(288,30) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (288,30)-(288,31) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (288,31)-(288,32) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (288,33)-(288,41) 28 "SymbolGenerator.mxg"
                __cb.Write(variable);
                #line hidden
                #line (288,42)-(288,43) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first46) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}