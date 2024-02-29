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
            __cb.Write("null)");
            #line hidden
            #line (76,269)-(76,270) 25 "SymbolGenerator.mxg"
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
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (78,9)-(78,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (79,9)-(79,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (81,9)-(81,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (81,15)-(81,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,16)-(81,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (81,24)-(81,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,25)-(81,31) 25 "SymbolGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (81,31)-(81,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,32)-(81,42) 25 "SymbolGenerator.mxg"
            __cb.Write("SymbolType");
            #line hidden
            #line (81,42)-(81,43) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,43)-(81,45) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (81,45)-(81,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,46)-(81,53) 25 "SymbolGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (81,54)-(81,81) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (81,82)-(81,84) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (82,9)-(82,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (82,18)-(82,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,19)-(82,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (82,27)-(82,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,28)-(82,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (82,45)-(82,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,46)-(82,61) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (82,61)-(82,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,62)-(82,64) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (82,64)-(82,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,65)-(82,97) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first6 = true;
            #line (84,10)-(84,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                var __first7 = true;
                #line (85,14)-(85,51) 17 "SymbolGenerator.mxg"
                if (!prop.IsDerived && !prop.IsPlain)
                #line hidden
                
                {
                    if (__first7)
                    {
                        __first7 = false;
                    }
                    __cb.Push("        ");
                    #line (86,18)-(86,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (86,22)-(86,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("__ModelPropertyAttribute");
                    #line hidden
                    #line (86,47)-(86,50) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first7) __cb.AppendLine();
                var __first8 = true;
                #line (88,14)-(88,32) 17 "SymbolGenerator.mxg"
                if (!prop.IsPlain)
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("        ");
                    #line (89,18)-(89,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (89,22)-(89,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("__PhaseAttribute");
                    #line hidden
                    var __first9 = true;
                    #line (89,39)-(89,66) 21 "SymbolGenerator.mxg"
                    if (prop.Phase is not null)
                    #line hidden
                    
                    {
                        if (__first9)
                        {
                            __first9 = false;
                        }
                        #line (89,67)-(89,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(nameof(");
                        #line hidden
                        #line (89,76)-(89,91) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Phase.Name);
                        #line hidden
                        #line (89,92)-(89,94) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                    }
                    #line (89,103)-(89,106) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first8) __cb.AppendLine();
                var __first10 = true;
                #line (91,14)-(91,33) 17 "SymbolGenerator.mxg"
                if (prop.IsDerived)
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
                    #line (92,22)-(92,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DerivedAttribute");
                    #line hidden
                    var __first11 = true;
                    #line (92,41)-(92,59) 21 "SymbolGenerator.mxg"
                    if (prop.IsCached)
                    #line hidden
                    
                    {
                        if (__first11)
                        {
                            __first11 = false;
                        }
                        #line (92,60)-(92,73) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true)");
                        #line hidden
                    }
                    #line (92,82)-(92,85) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                var __first12 = true;
                #line (94,14)-(94,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("        ");
                    #line (95,18)-(95,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (95,22)-(95,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("__WeakAttribute");
                    #line hidden
                    #line (95,38)-(95,41) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first12) __cb.AppendLine();
                __cb.Push("        ");
                #line (97,13)-(97,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (97,19)-(97,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first13 = true;
                #line (97,21)-(97,41) 17 "SymbolGenerator.mxg"
                if (prop.IsAbstract)
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    #line (97,42)-(97,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (97,50)-(97,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (97,60)-(97,90) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (97,91)-(97,92) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (97,93)-(97,102) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (98,13)-(98,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first14 = true;
                #line (99,18)-(99,35) 17 "SymbolGenerator.mxg"
                if (prop.IsPlain)
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    var __first15 = true;
                    #line (100,22)-(100,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsAbstract)
                    #line hidden
                    
                    {
                        if (__first15)
                        {
                            __first15 = false;
                        }
                        __cb.Push("            ");
                        #line (101,25)-(101,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("get;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (102,22)-(102,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first15)
                        {
                            __first15 = false;
                        }
                        var __first16 = true;
                        #line (103,26)-(103,42) 25 "SymbolGenerator.mxg"
                        if (prop.IsWeak)
                        #line hidden
                        
                        {
                            if (__first16)
                            {
                                __first16 = false;
                            }
                            __cb.Push("            ");
                            #line (104,29)-(104,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (105,29)-(105,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (106,33)-(106,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (106,35)-(106,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (106,36)-(106,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (106,38)-(106,56) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (106,57)-(106,75) 41 "SymbolGenerator.mxg"
                            __cb.Write(".TryGetValue(this,");
                            #line hidden
                            #line (106,75)-(106,76) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (106,76)-(106,79) 41 "SymbolGenerator.mxg"
                            __cb.Write("out");
                            #line hidden
                            #line (106,79)-(106,80) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (106,80)-(106,83) 41 "SymbolGenerator.mxg"
                            __cb.Write("var");
                            #line hidden
                            #line (106,83)-(106,84) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (106,84)-(106,92) 41 "SymbolGenerator.mxg"
                            __cb.Write("result))");
                            #line hidden
                            #line (106,92)-(106,93) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (106,93)-(106,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (106,99)-(106,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (106,100)-(106,101) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (106,102)-(106,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type));
                            #line hidden
                            #line (106,133)-(106,141) 41 "SymbolGenerator.mxg"
                            __cb.Write(")result;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (107,33)-(107,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("else");
                            #line hidden
                            #line (107,37)-(107,38) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (107,38)-(107,44) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (107,44)-(107,45) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (107,46)-(107,75) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (107,76)-(107,77) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (108,29)-(108,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (109,29)-(109,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (109,38)-(109,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (109,39)-(109,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (110,29)-(110,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (111,34)-(111,71) 40 "SymbolGenerator.mxg"
                            __cb.Write(AssignProperty(symbol, prop, "value"));
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (112,29)-(112,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (113,26)-(113,30) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first16)
                            {
                                __first16 = false;
                            }
                            __cb.Push("            ");
                            #line (114,29)-(114,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            #line (114,32)-(114,33) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (114,33)-(114,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (114,35)-(114,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (114,37)-(114,55) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (114,56)-(114,57) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
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
                            #line (115,42)-(115,43) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (115,43)-(115,45) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (115,45)-(115,46) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (115,47)-(115,65) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (115,66)-(115,67) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (115,67)-(115,68) 41 "SymbolGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (115,68)-(115,69) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (115,69)-(115,75) 41 "SymbolGenerator.mxg"
                            __cb.Write("value;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first16) __cb.AppendLine();
                    }
                    if (!__first15) __cb.AppendLine();
                }
                #line (118,18)-(118,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    __cb.Push("            ");
                    #line (119,21)-(119,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (120,21)-(120,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (121,25)-(121,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("this.ForceComplete(CompletionParts.Finish_");
                    #line hidden
                    #line (121,68)-(121,97) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (121,98)-(121,99) 33 "SymbolGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (121,99)-(121,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (121,100)-(121,105) 33 "SymbolGenerator.mxg"
                    __cb.Write("null,");
                    #line hidden
                    #line (121,105)-(121,106) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (121,106)-(121,115) 33 "SymbolGenerator.mxg"
                    __cb.Write("default);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first17 = true;
                    #line (122,26)-(122,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("                ");
                        #line (123,29)-(123,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (123,31)-(123,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (123,32)-(123,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (123,34)-(123,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (123,53)-(123,71) 37 "SymbolGenerator.mxg"
                        __cb.Write(".TryGetValue(this,");
                        #line hidden
                        #line (123,71)-(123,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (123,72)-(123,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("out");
                        #line hidden
                        #line (123,75)-(123,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (123,76)-(123,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (123,79)-(123,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (123,80)-(123,88) 37 "SymbolGenerator.mxg"
                        __cb.Write("result))");
                        #line hidden
                        #line (123,88)-(123,89) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (123,89)-(123,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (123,95)-(123,96) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (123,96)-(123,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (123,98)-(123,128) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (123,129)-(123,137) 37 "SymbolGenerator.mxg"
                        __cb.Write(")result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (124,29)-(124,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("else");
                        #line hidden
                        #line (124,33)-(124,34) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (124,34)-(124,40) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (124,40)-(124,41) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (124,42)-(124,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (124,72)-(124,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (125,26)-(125,30) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("                ");
                        #line (126,29)-(126,35) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (126,35)-(126,36) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (126,37)-(126,55) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (126,56)-(126,57) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first17) __cb.AppendLine();
                    __cb.Push("            ");
                    #line (128,21)-(128,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (129,21)-(129,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (129,30)-(129,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (129,31)-(129,34) 33 "SymbolGenerator.mxg"
                    __cb.Write("set");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (130,21)-(130,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (131,26)-(131,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(AssignProperty(symbol, prop, "value"));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (132,21)-(132,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first14) __cb.AppendLine();
                __cb.Push("        ");
                #line (134,13)-(134,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first6) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first18 = true;
            #line (137,10)-(137,47) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations)
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                #line (138,14)-(138,90) 17 "SymbolGenerator.mxg"
                var arguments = "("+string.Join(", ", op.Parameters.Select(p => p.Name))+")";
                #line hidden
                
                #line (139,14)-(139,42) 17 "SymbolGenerator.mxg"
                var call = op.Name+arguments;
                #line hidden
                
                #line (140,14)-(140,65) 17 "SymbolGenerator.mxg"
                var returnType = GetTypeName(symbol, op.ReturnType);
                #line hidden
                
                __cb.WriteLine();
                __cb.Pop();
                var __first19 = true;
                #line (142,14)-(142,29) 17 "SymbolGenerator.mxg"
                if (op.IsPhase)
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("        ");
                    #line (143,18)-(143,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (143,22)-(143,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("__PhaseAttribute");
                    #line hidden
                    #line (143,39)-(143,42) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (144,17)-(144,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (144,26)-(144,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (144,27)-(144,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (144,35)-(144,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (144,36)-(144,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (144,40)-(144,41) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (144,42)-(144,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (144,50)-(144,66) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (144,66)-(144,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (144,67)-(144,79) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (144,79)-(144,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (144,80)-(144,99) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (144,99)-(144,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (144,100)-(144,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (145,14)-(145,35) 17 "SymbolGenerator.mxg"
                else if (op.IsCached)
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("        ");
                    #line (146,18)-(146,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (146,22)-(146,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DerivedAttribute");
                    #line hidden
                    var __first20 = true;
                    #line (146,41)-(146,57) 21 "SymbolGenerator.mxg"
                    if (op.IsCached)
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        #line (146,58)-(146,70) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true");
                        #line hidden
                        var __first21 = true;
                        #line (146,71)-(146,116) 25 "SymbolGenerator.mxg"
                        if (!string.IsNullOrEmpty(op.CacheCondition))
                        #line hidden
                        
                        {
                            if (__first21)
                            {
                                __first21 = false;
                            }
                            #line (146,117)-(146,118) 41 "SymbolGenerator.mxg"
                            __cb.Write(",");
                            #line hidden
                            #line (146,118)-(146,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (146,119)-(146,129) 41 "SymbolGenerator.mxg"
                            __cb.Write("Condition=");
                            #line hidden
                            #line (146,130)-(146,162) 40 "SymbolGenerator.mxg"
                            __cb.Write(op.CacheCondition.EncodeString());
                            #line hidden
                        }
                        #line (146,171)-(146,172) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                    }
                    #line (146,181)-(146,184) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (147,17)-(147,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (147,23)-(147,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (147,25)-(147,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (147,36)-(147,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (147,38)-(147,45) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (147,46)-(147,47) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first22 = true;
                    foreach (var __item23 in 
                    #line (147,48)-(147,118) 21 "SymbolGenerator.mxg"
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
                            #line (147,128)-(147,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item23);
                    }
                    #line (147,133)-(147,134) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (148,17)-(148,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first24 = true;
                    #line (149,22)-(149,67) 21 "SymbolGenerator.mxg"
                    if (!string.IsNullOrEmpty(op.CacheCondition))
                    #line hidden
                    
                    {
                        if (__first24)
                        {
                            __first24 = false;
                        }
                        __cb.Push("            ");
                        #line (150,25)-(150,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (150,27)-(150,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (150,28)-(150,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!(");
                        #line hidden
                        #line (150,32)-(150,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.CacheCondition);
                        #line hidden
                        #line (150,50)-(150,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                        #line (150,52)-(150,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (150,53)-(150,59) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (150,59)-(150,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (150,61)-(150,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, op.ReturnType));
                        #line hidden
                        #line (150,100)-(150,101) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first24) __cb.AppendLine();
                    #line (152,22)-(152,54) 21 "SymbolGenerator.mxg"
                    var fieldName = GetFieldName(op);
                    #line hidden
                    
                    var __first25 = true;
                    #line (153,22)-(153,51) 21 "SymbolGenerator.mxg"
                    if (op.Parameters.Count == 0)
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("            ");
                        #line (154,25)-(154,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (154,31)-(154,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,32)-(154,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (154,34)-(154,44) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (154,45)-(154,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (154,47)-(154,56) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (154,57)-(154,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (154,72)-(154,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,73)-(154,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (154,79)-(154,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,80)-(154,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (154,82)-(154,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,83)-(154,91) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (154,92)-(154,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.Name);
                        #line hidden
                        #line (154,101)-(154,110) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (154,111)-(154,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (155,22)-(155,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("            ");
                        #line (156,25)-(156,28) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (156,28)-(156,29) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,29)-(156,47) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary");
                        #line hidden
                        #line (156,47)-(156,48) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,48)-(156,49) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (156,49)-(156,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,51)-(156,60) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (156,61)-(156,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (156,76)-(156,77) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,77)-(156,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (156,83)-(156,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,84)-(156,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (156,86)-(156,87) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,87)-(156,90) 37 "SymbolGenerator.mxg"
                        __cb.Write("new");
                        #line hidden
                        #line (156,90)-(156,91) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,91)-(156,150) 37 "SymbolGenerator.mxg"
                        __cb.Write("global::System.Collections.Concurrent.ConcurrentDictionary<");
                        #line hidden
                        #line (156,151)-(156,178) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetCacheKeyType(symbol, op));
                        #line hidden
                        #line (156,179)-(156,180) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (156,180)-(156,181) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (156,182)-(156,192) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (156,193)-(156,198) 37 "SymbolGenerator.mxg"
                        __cb.Write(">());");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (157,25)-(157,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (157,31)-(157,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (157,32)-(157,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary.GetOrAdd(");
                        #line hidden
                        #line (157,61)-(157,70) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (157,71)-(157,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (157,72)-(157,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (157,73)-(157,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__args");
                        #line hidden
                        #line (157,79)-(157,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (157,80)-(157,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (157,82)-(157,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (157,83)-(157,91) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (157,92)-(157,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.Name);
                        #line hidden
                        #line (157,101)-(157,110) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (157,111)-(157,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first25) __cb.AppendLine();
                    __cb.Push("        ");
                    #line (159,17)-(159,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (161,17)-(161,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (161,26)-(161,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,27)-(161,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (161,35)-(161,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,37)-(161,47) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (161,48)-(161,49) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,49)-(161,57) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (161,58)-(161,65) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (161,66)-(161,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first26 = true;
                    foreach (var __item27 in 
                    #line (161,68)-(161,138) 21 "SymbolGenerator.mxg"
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
                            #line (161,148)-(161,152) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item27);
                    }
                    #line (161,153)-(161,155) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (162,14)-(162,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("        ");
                    #line (163,17)-(163,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (163,23)-(163,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (163,24)-(163,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (163,32)-(163,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (163,34)-(163,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (163,45)-(163,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (163,47)-(163,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (163,55)-(163,56) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first28 = true;
                    foreach (var __item29 in 
                    #line (163,57)-(163,127) 21 "SymbolGenerator.mxg"
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
                            #line (163,137)-(163,141) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item29);
                    }
                    #line (163,142)-(163,144) 33 "SymbolGenerator.mxg"
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
            #line (167,10)-(167,40) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            __cb.Push("        ");
            #line (168,9)-(168,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (168,18)-(168,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,19)-(168,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (168,27)-(168,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,28)-(168,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (168,32)-(168,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,33)-(168,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (168,54)-(168,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,55)-(168,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (168,71)-(168,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,72)-(168,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (168,87)-(168,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,88)-(168,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (168,105)-(168,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,106)-(168,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (168,118)-(168,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,119)-(168,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (168,138)-(168,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,139)-(168,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (169,9)-(169,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (170,14)-(170,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            var __first30 = true;
            #line (171,14)-(171,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                #line (172,18)-(172,36) 17 "SymbolGenerator.mxg"
                hasNewPhase = true;
                #line hidden
                
                #line (173,18)-(173,63) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                __cb.Push("            ");
                #line (174,17)-(174,19) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (174,19)-(174,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,20)-(174,35) 29 "SymbolGenerator.mxg"
                __cb.Write("(incompletePart");
                #line hidden
                #line (174,35)-(174,36) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,36)-(174,38) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (174,38)-(174,39) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,39)-(174,61) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Start_");
                #line hidden
                #line (174,62)-(174,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (174,68)-(174,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,69)-(174,71) 29 "SymbolGenerator.mxg"
                __cb.Write("||");
                #line hidden
                #line (174,71)-(174,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,72)-(174,86) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart");
                #line hidden
                #line (174,86)-(174,87) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,87)-(174,89) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (174,89)-(174,90) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,90)-(174,113) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Finish_");
                #line hidden
                #line (174,114)-(174,119) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (174,120)-(174,121) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (175,17)-(175,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (176,21)-(176,23) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (176,23)-(176,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (176,24)-(176,64) 29 "SymbolGenerator.mxg"
                __cb.Write("(NotePartComplete(CompletionParts.Start_");
                #line hidden
                #line (176,65)-(176,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (176,71)-(176,73) 29 "SymbolGenerator.mxg"
                __cb.Write("))");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (177,21)-(177,22) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
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
                    #line (179,33)-(179,44) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics");
                    #line hidden
                    #line (179,44)-(179,45) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,45)-(179,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (179,46)-(179,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,47)-(179,77) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DiagnosticBag.GetInstance();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (180,29)-(180,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (180,32)-(180,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,33)-(180,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (180,39)-(180,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,40)-(180,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (180,41)-(180,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,42)-(180,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (180,51)-(180,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (180,57)-(180,70) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (180,70)-(180,71) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,71)-(180,90) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first32 = true;
                    #line (181,30)-(181,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        __cb.Push("                    ");
                        #line (182,33)-(182,35) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (182,35)-(182,36) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (182,36)-(182,37) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first33 = true;
                        #line (182,38)-(182,54) 25 "SymbolGenerator.mxg"
                        if (prop.IsWeak)
                        #line hidden
                        
                        {
                            if (__first33)
                            {
                                __first33 = false;
                            }
                            #line (182,55)-(182,56) 41 "SymbolGenerator.mxg"
                            __cb.Write("!");
                            #line hidden
                            #line (182,57)-(182,75) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (182,76)-(182,94) 41 "SymbolGenerator.mxg"
                            __cb.Write(".TryGetValue(this,");
                            #line hidden
                            #line (182,94)-(182,95) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (182,95)-(182,98) 41 "SymbolGenerator.mxg"
                            __cb.Write("out");
                            #line hidden
                            #line (182,98)-(182,99) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (182,99)-(182,102) 41 "SymbolGenerator.mxg"
                            __cb.Write("var");
                            #line hidden
                            #line (182,102)-(182,103) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (182,103)-(182,105) 41 "SymbolGenerator.mxg"
                            __cb.Write("_)");
                            #line hidden
                        }
                        #line (182,106)-(182,110) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first33)
                            {
                                __first33 = false;
                            }
                            #line (182,112)-(182,130) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (182,131)-(182,132) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (182,132)-(182,134) 41 "SymbolGenerator.mxg"
                            __cb.Write("==");
                            #line hidden
                            #line (182,134)-(182,135) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (182,135)-(182,142) 41 "SymbolGenerator.mxg"
                            __cb.Write("default");
                            #line hidden
                        }
                        #line (182,150)-(182,151) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                    ");
                        #line (183,33)-(183,34) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                        ");
                        #line (184,38)-(184,87) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                    ");
                        #line (185,33)-(185,34) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first32) __cb.AppendLine();
                    __cb.Push("                    ");
                    #line (187,29)-(187,63) 33 "SymbolGenerator.mxg"
                    __cb.Write("AddSymbolDiagnostics(diagnostics);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (188,29)-(188,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (189,26)-(189,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    #line (190,30)-(190,49) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    __cb.Push("                    ");
                    #line (191,29)-(191,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (191,31)-(191,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (191,32)-(191,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first34 = true;
                    #line (191,34)-(191,50) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first34)
                        {
                            __first34 = false;
                        }
                        #line (191,51)-(191,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("!");
                        #line hidden
                        #line (191,53)-(191,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (191,72)-(191,90) 37 "SymbolGenerator.mxg"
                        __cb.Write(".TryGetValue(this,");
                        #line hidden
                        #line (191,90)-(191,91) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (191,91)-(191,94) 37 "SymbolGenerator.mxg"
                        __cb.Write("out");
                        #line hidden
                        #line (191,94)-(191,95) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (191,95)-(191,98) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (191,98)-(191,99) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (191,99)-(191,101) 37 "SymbolGenerator.mxg"
                        __cb.Write("_)");
                        #line hidden
                    }
                    #line (191,102)-(191,106) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first34)
                        {
                            __first34 = false;
                        }
                        #line (191,108)-(191,126) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (191,127)-(191,128) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (191,128)-(191,130) 37 "SymbolGenerator.mxg"
                        __cb.Write("==");
                        #line hidden
                        #line (191,130)-(191,131) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (191,131)-(191,138) 37 "SymbolGenerator.mxg"
                        __cb.Write("default");
                        #line hidden
                    }
                    #line (191,146)-(191,147) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (192,29)-(192,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                        ");
                    #line (193,33)-(193,36) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (193,36)-(193,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (193,37)-(193,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics");
                    #line hidden
                    #line (193,48)-(193,49) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (193,49)-(193,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (193,50)-(193,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (193,51)-(193,81) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DiagnosticBag.GetInstance();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                        ");
                    #line (194,33)-(194,36) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (194,36)-(194,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (194,37)-(194,43) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (194,43)-(194,44) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (194,44)-(194,45) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (194,45)-(194,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (194,46)-(194,54) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (194,55)-(194,60) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (194,61)-(194,74) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (194,74)-(194,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (194,75)-(194,94) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                        ");
                    #line (195,34)-(195,72) 32 "SymbolGenerator.mxg"
                    __cb.Write(AssignProperty(symbol, prop, "result"));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                        ");
                    #line (196,33)-(196,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("AddSymbolDiagnostics(diagnostics);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                        ");
                    #line (197,33)-(197,52) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (198,29)-(198,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (199,26)-(199,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("                    ");
                    #line (200,29)-(200,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (200,32)-(200,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (200,33)-(200,44) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics");
                    #line hidden
                    #line (200,44)-(200,45) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (200,45)-(200,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (200,46)-(200,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (200,47)-(200,77) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DiagnosticBag.GetInstance();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (201,30)-(201,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (201,36)-(201,49) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (201,49)-(201,50) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (201,50)-(201,69) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (202,29)-(202,63) 33 "SymbolGenerator.mxg"
                    __cb.Write("AddSymbolDiagnostics(diagnostics);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (203,29)-(203,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first31) __cb.AppendLine();
                __cb.Push("                    ");
                #line (205,25)-(205,65) 29 "SymbolGenerator.mxg"
                __cb.Write("NotePartComplete(CompletionParts.Finish_");
                #line hidden
                #line (205,66)-(205,71) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (205,72)-(205,74) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (206,21)-(206,22) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (207,21)-(207,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (207,27)-(207,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (207,28)-(207,33) 29 "SymbolGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (208,17)-(208,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (209,17)-(209,21) 29 "SymbolGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (209,21)-(209,22) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first30) __cb.AppendLine();
            var __first35 = true;
            #line (211,14)-(211,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first35)
                {
                    __first35 = false;
                }
                __cb.Push("            ");
                #line (212,17)-(212,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (213,21)-(213,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (213,27)-(213,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (213,28)-(213,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (213,54)-(213,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (213,55)-(213,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (213,70)-(213,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (213,71)-(213,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (213,83)-(213,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (213,84)-(213,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (214,17)-(214,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (215,14)-(215,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first35)
                {
                    __first35 = false;
                }
                __cb.Push("            ");
                #line (216,17)-(216,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (216,23)-(216,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (216,24)-(216,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (216,50)-(216,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (216,51)-(216,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (216,66)-(216,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (216,67)-(216,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (216,79)-(216,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (216,80)-(216,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first35) __cb.AppendLine();
            __cb.Push("        ");
            #line (218,9)-(218,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first36 = true;
            #line (220,10)-(220,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (222,14)-(222,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first37 = true;
                #line (223,14)-(223,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first37)
                    {
                        __first37 = false;
                    }
                    #line (224,18)-(224,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    var __first38 = true;
                    #line (225,18)-(225,58) 21 "SymbolGenerator.mxg"
                    if (props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first38)
                        {
                            __first38 = false;
                        }
                        __cb.Push("        ");
                        #line (226,21)-(226,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (226,30)-(226,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (226,31)-(226,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (226,39)-(226,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (226,41)-(226,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (226,52)-(226,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (226,53)-(226,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (226,62)-(226,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (226,68)-(226,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (226,84)-(226,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (226,85)-(226,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (226,97)-(226,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (226,98)-(226,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (226,117)-(226,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (226,118)-(226,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (227,18)-(227,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first38)
                        {
                            __first38 = false;
                        }
                        __cb.Push("        ");
                        #line (228,21)-(228,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (228,30)-(228,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (228,31)-(228,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (228,38)-(228,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (228,40)-(228,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (228,51)-(228,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (228,52)-(228,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (228,61)-(228,66) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (228,67)-(228,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (228,83)-(228,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (228,84)-(228,96) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (228,96)-(228,97) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (228,97)-(228,116) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (228,116)-(228,117) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (228,117)-(228,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (229,21)-(229,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = true;
                        __cb.Push("            ");
                        #line (231,25)-(231,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (231,31)-(231,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,32)-(231,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first39 = true;
                        #line (232,30)-(232,58) 25 "SymbolGenerator.mxg"
                        foreach (var prop in props) 
                        #line hidden
                        
                        {
                            if (__first39)
                            {
                                __first39 = false;
                            }
                            else
                            {
                                __cb.Push("                ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (232,68)-(232,72) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Push("                ");
                            #line (233,33)-(233,69) 41 "SymbolGenerator.mxg"
                            __cb.Write("SymbolFactory.GetSymbolPropertyValue");
                            #line hidden
                            var __first40 = true;
                            #line (233,70)-(233,99) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first40)
                                {
                                    __first40 = false;
                                }
                                #line (233,100)-(233,101) 45 "SymbolGenerator.mxg"
                                __cb.Write("s");
                                #line hidden
                            }
                            #line (233,109)-(233,110) 41 "SymbolGenerator.mxg"
                            __cb.Write("<");
                            #line hidden
                            #line (233,111)-(233,146) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type.Type));
                            #line hidden
                            #line (233,147)-(233,154) 41 "SymbolGenerator.mxg"
                            __cb.Write(">(this,");
                            #line hidden
                            #line (233,154)-(233,155) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (233,155)-(233,162) 41 "SymbolGenerator.mxg"
                            __cb.Write("nameof(");
                            #line hidden
                            #line (233,163)-(233,172) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (233,173)-(233,175) 41 "SymbolGenerator.mxg"
                            __cb.Write("),");
                            #line hidden
                            #line (233,175)-(233,176) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (233,176)-(233,188) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (233,188)-(233,189) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (233,189)-(233,208) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first39) __cb.AppendLine();
                        __cb.Push("            ");
                        #line (235,25)-(235,27) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = false;
                        __cb.AppendLine();
                        __cb.Push("        ");
                        #line (237,21)-(237,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first38) __cb.AppendLine();
                }
                #line (239,14)-(239,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first37)
                    {
                        __first37 = false;
                    }
                    #line (240,18)-(240,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (241,18)-(241,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    var __first41 = true;
                    #line (242,18)-(242,37) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first41)
                        {
                            __first41 = false;
                        }
                        __cb.Push("        ");
                        #line (243,21)-(243,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (243,30)-(243,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (243,31)-(243,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (243,39)-(243,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (243,41)-(243,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (243,52)-(243,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (243,53)-(243,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (243,62)-(243,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (243,68)-(243,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (243,84)-(243,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (243,85)-(243,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (243,97)-(243,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (243,98)-(243,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (243,117)-(243,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (243,118)-(243,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (244,18)-(244,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first41)
                        {
                            __first41 = false;
                        }
                        __cb.Push("        ");
                        #line (245,21)-(245,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (245,30)-(245,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (245,31)-(245,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (245,38)-(245,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (245,40)-(245,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (245,51)-(245,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (245,52)-(245,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (245,61)-(245,66) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (245,67)-(245,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (245,83)-(245,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (245,84)-(245,96) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (245,96)-(245,97) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (245,97)-(245,116) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (245,116)-(245,117) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (245,117)-(245,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (246,21)-(246,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (247,25)-(247,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (247,31)-(247,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (247,32)-(247,68) 37 "SymbolGenerator.mxg"
                        __cb.Write("SymbolFactory.GetSymbolPropertyValue");
                        #line hidden
                        var __first42 = true;
                        #line (247,69)-(247,98) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first42)
                            {
                                __first42 = false;
                            }
                            #line (247,99)-(247,100) 41 "SymbolGenerator.mxg"
                            __cb.Write("s");
                            #line hidden
                        }
                        #line (247,108)-(247,109) 37 "SymbolGenerator.mxg"
                        __cb.Write("<");
                        #line hidden
                        #line (247,110)-(247,145) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type.Type));
                        #line hidden
                        #line (247,146)-(247,153) 37 "SymbolGenerator.mxg"
                        __cb.Write(">(this,");
                        #line hidden
                        #line (247,153)-(247,154) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (247,154)-(247,161) 37 "SymbolGenerator.mxg"
                        __cb.Write("nameof(");
                        #line hidden
                        #line (247,162)-(247,171) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Name);
                        #line hidden
                        #line (247,172)-(247,174) 37 "SymbolGenerator.mxg"
                        __cb.Write("),");
                        #line hidden
                        #line (247,174)-(247,175) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (247,175)-(247,187) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (247,187)-(247,188) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (247,188)-(247,207) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (248,21)-(248,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first41) __cb.AppendLine();
                }
                if (!__first37) __cb.AppendLine();
            }
            if (!__first36) __cb.AppendLine();
            __cb.Push("    ");
            #line (252,5)-(252,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (253,1)-(253,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (256,9)-(256,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (257,2)-(257,34) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (258,2)-(258,61) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            __cb.Push("");
            #line (259,1)-(259,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (259,6)-(259,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,7)-(259,14) 25 "SymbolGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (260,1)-(260,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (260,6)-(260,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,7)-(260,34) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Generic;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (261,1)-(261,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (261,6)-(261,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,7)-(261,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (262,1)-(262,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (262,6)-(262,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,7)-(262,19) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Linq;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (263,1)-(263,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (263,6)-(263,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,7)-(263,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (264,1)-(264,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (264,6)-(264,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,7)-(264,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (265,1)-(265,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (265,6)-(265,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,7)-(265,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (266,1)-(266,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (266,6)-(266,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,7)-(266,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (268,1)-(268,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (268,10)-(268,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,12)-(268,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (268,33)-(268,38) 25 "SymbolGenerator.mxg"
            __cb.Write(".Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (269,1)-(269,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (270,5)-(270,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (270,10)-(270,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,11)-(270,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (270,18)-(270,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,19)-(270,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (270,20)-(270,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,21)-(270,45) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.Model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (271,5)-(271,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (271,10)-(271,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,11)-(271,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (271,25)-(271,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,26)-(271,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (271,27)-(271,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,28)-(271,59) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (272,5)-(272,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (272,10)-(272,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,11)-(272,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (272,20)-(272,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,21)-(272,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (272,22)-(272,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,23)-(272,54) 25 "SymbolGenerator.mxg"
            __cb.Write("Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (274,5)-(274,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (274,11)-(274,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,12)-(274,17) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (274,17)-(274,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,19)-(274,46) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (274,47)-(274,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,48)-(274,49) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (274,49)-(274,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,51)-(274,78) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (275,5)-(275,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (276,9)-(276,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (276,15)-(276,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,17)-(276,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (276,45)-(276,53) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol?");
            #line hidden
            #line (276,53)-(276,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,54)-(276,64) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (276,64)-(276,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,65)-(276,77) 25 "SymbolGenerator.mxg"
            __cb.Write("Compilation?");
            #line hidden
            #line (276,77)-(276,78) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,78)-(276,89) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation");
            #line hidden
            #line (276,89)-(276,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,90)-(276,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (276,91)-(276,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,92)-(276,97) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (276,97)-(276,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,98)-(276,116) 25 "SymbolGenerator.mxg"
            __cb.Write("MergedDeclaration?");
            #line hidden
            #line (276,116)-(276,117) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,117)-(276,128) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration");
            #line hidden
            #line (276,128)-(276,129) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,129)-(276,130) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (276,130)-(276,131) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,131)-(276,136) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (276,136)-(276,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,137)-(276,145) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model?");
            #line hidden
            #line (276,145)-(276,146) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,146)-(276,151) 25 "SymbolGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (276,151)-(276,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,152)-(276,153) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (276,153)-(276,154) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,154)-(276,159) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (276,159)-(276,160) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,160)-(276,175) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (276,175)-(276,176) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,176)-(276,187) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (276,187)-(276,188) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,188)-(276,189) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (276,189)-(276,190) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,190)-(276,195) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (276,195)-(276,196) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,196)-(276,205) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (276,205)-(276,206) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,206)-(276,218) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol");
            #line hidden
            #line (276,218)-(276,219) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,219)-(276,220) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (276,220)-(276,221) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,221)-(276,226) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (276,226)-(276,227) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,227)-(276,243) 25 "SymbolGenerator.mxg"
            __cb.Write("ErrorSymbolInfo?");
            #line hidden
            #line (276,243)-(276,244) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,244)-(276,253) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo");
            #line hidden
            #line (276,253)-(276,254) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,254)-(276,255) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (276,255)-(276,256) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,256)-(276,261) 25 "SymbolGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (276,261)-(276,262) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (277,13)-(277,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (277,14)-(277,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,15)-(277,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (277,30)-(277,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,31)-(277,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (277,43)-(277,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,44)-(277,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (277,56)-(277,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,57)-(277,63) 25 "SymbolGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (277,63)-(277,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,64)-(277,76) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (277,76)-(277,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,77)-(277,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (277,90)-(277,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,91)-(277,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (278,9)-(278,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (279,9)-(279,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (281,5)-(281,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (282,1)-(282,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (285,9)-(285,71) 22 "SymbolGenerator.mxg"
        public string AssignProperty(Symbol symbol, Property prop, string variable)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first43 = true;
            #line (286,6)-(286,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first43)
                {
                    __first43 = false;
                }
                var __first44 = true;
                #line (287,10)-(287,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first44)
                    {
                        __first44 = false;
                    }
                    __cb.Push("");
                    #line (288,13)-(288,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (288,15)-(288,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (288,16)-(288,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("(!");
                    #line hidden
                    #line (288,19)-(288,27) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (288,28)-(288,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(".IsDefaultOrEmpty)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (289,13)-(289,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (290,18)-(290,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (290,37)-(290,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (290,47)-(290,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (290,49)-(290,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (290,58)-(290,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (291,13)-(291,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (292,10)-(292,14) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first44)
                    {
                        __first44 = false;
                    }
                    __cb.Push("");
                    #line (293,13)-(293,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (293,15)-(293,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (293,16)-(293,17) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (293,18)-(293,26) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (293,27)-(293,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (293,28)-(293,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (293,30)-(293,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (293,32)-(293,61) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (293,62)-(293,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (294,13)-(294,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (295,18)-(295,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (295,37)-(295,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (295,47)-(295,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (295,49)-(295,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (295,58)-(295,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (296,13)-(296,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first44) __cb.AppendLine();
            }
            #line (298,6)-(298,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first43)
                {
                    __first43 = false;
                }
                __cb.Push("");
                #line (299,10)-(299,28) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (299,29)-(299,30) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (299,30)-(299,31) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (299,31)-(299,32) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (299,33)-(299,41) 28 "SymbolGenerator.mxg"
                __cb.Write(variable);
                #line hidden
                #line (299,42)-(299,43) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first43) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}