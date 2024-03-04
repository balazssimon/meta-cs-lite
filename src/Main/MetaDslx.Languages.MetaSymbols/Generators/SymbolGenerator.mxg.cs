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
            #line (11,12)-(11,28) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.Namespace);
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
            #line (76,82)-(76,94) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (76,94)-(76,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,95)-(76,115) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration?");
            #line hidden
            #line (76,115)-(76,116) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,116)-(76,128) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (76,128)-(76,129) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,129)-(76,144) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (76,144)-(76,145) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,145)-(76,157) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (76,157)-(76,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,158)-(76,168) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol?");
            #line hidden
            #line (76,168)-(76,169) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,169)-(76,182) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (76,182)-(76,183) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,183)-(76,201) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo?");
            #line hidden
            #line (76,201)-(76,202) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,202)-(76,212) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (76,212)-(76,213) 25 "SymbolGenerator.mxg"
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
            #line (77,57)-(77,69) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (77,69)-(77,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,70)-(77,83) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (77,83)-(77,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,84)-(77,94) 25 "SymbolGenerator.mxg"
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
                }
                if (!__first14) __cb.AppendLine();
                __cb.Push("        ");
                #line (130,13)-(130,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first6) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first18 = true;
            #line (133,10)-(133,47) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations)
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                #line (134,14)-(134,90) 17 "SymbolGenerator.mxg"
                var arguments = "("+string.Join(", ", op.Parameters.Select(p => p.Name))+")";
                #line hidden
                
                #line (135,14)-(135,42) 17 "SymbolGenerator.mxg"
                var call = op.Name+arguments;
                #line hidden
                
                #line (136,14)-(136,65) 17 "SymbolGenerator.mxg"
                var returnType = GetTypeName(symbol, op.ReturnType);
                #line hidden
                
                __cb.WriteLine();
                __cb.Pop();
                var __first19 = true;
                #line (138,14)-(138,29) 17 "SymbolGenerator.mxg"
                if (op.IsPhase)
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("        ");
                    #line (139,18)-(139,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (139,22)-(139,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("__PhaseAttribute");
                    #line hidden
                    #line (139,39)-(139,42) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (140,17)-(140,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (140,26)-(140,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,27)-(140,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (140,35)-(140,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,36)-(140,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (140,40)-(140,41) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,42)-(140,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (140,50)-(140,66) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (140,66)-(140,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,67)-(140,79) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (140,79)-(140,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,80)-(140,99) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (140,99)-(140,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,100)-(140,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (141,14)-(141,35) 17 "SymbolGenerator.mxg"
                else if (op.IsCached)
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
                    #line (142,22)-(142,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DerivedAttribute");
                    #line hidden
                    var __first20 = true;
                    #line (142,41)-(142,57) 21 "SymbolGenerator.mxg"
                    if (op.IsCached)
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        #line (142,58)-(142,70) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true");
                        #line hidden
                        var __first21 = true;
                        #line (142,71)-(142,116) 25 "SymbolGenerator.mxg"
                        if (!string.IsNullOrEmpty(op.CacheCondition))
                        #line hidden
                        
                        {
                            if (__first21)
                            {
                                __first21 = false;
                            }
                            #line (142,117)-(142,118) 41 "SymbolGenerator.mxg"
                            __cb.Write(",");
                            #line hidden
                            #line (142,118)-(142,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (142,119)-(142,129) 41 "SymbolGenerator.mxg"
                            __cb.Write("Condition=");
                            #line hidden
                            #line (142,130)-(142,162) 40 "SymbolGenerator.mxg"
                            __cb.Write(op.CacheCondition.EncodeString());
                            #line hidden
                        }
                        #line (142,171)-(142,172) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                    }
                    #line (142,181)-(142,184) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (143,17)-(143,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (143,23)-(143,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (143,25)-(143,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (143,36)-(143,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (143,38)-(143,45) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (143,46)-(143,47) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first22 = true;
                    foreach (var __item23 in 
                    #line (143,48)-(143,118) 21 "SymbolGenerator.mxg"
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
                            #line (143,128)-(143,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item23);
                    }
                    #line (143,133)-(143,134) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (144,17)-(144,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first24 = true;
                    #line (145,22)-(145,67) 21 "SymbolGenerator.mxg"
                    if (!string.IsNullOrEmpty(op.CacheCondition))
                    #line hidden
                    
                    {
                        if (__first24)
                        {
                            __first24 = false;
                        }
                        __cb.Push("            ");
                        #line (146,25)-(146,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (146,27)-(146,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (146,28)-(146,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!(");
                        #line hidden
                        #line (146,32)-(146,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.CacheCondition);
                        #line hidden
                        #line (146,50)-(146,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                        #line (146,52)-(146,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (146,53)-(146,59) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (146,59)-(146,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (146,61)-(146,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, op.ReturnType));
                        #line hidden
                        #line (146,100)-(146,101) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first24) __cb.AppendLine();
                    #line (148,22)-(148,54) 21 "SymbolGenerator.mxg"
                    var fieldName = GetFieldName(op);
                    #line hidden
                    
                    var __first25 = true;
                    #line (149,22)-(149,51) 21 "SymbolGenerator.mxg"
                    if (op.Parameters.Count == 0)
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("            ");
                        #line (150,25)-(150,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (150,31)-(150,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (150,32)-(150,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (150,34)-(150,44) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (150,45)-(150,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (150,47)-(150,56) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (150,57)-(150,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (150,72)-(150,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (150,73)-(150,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (150,79)-(150,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (150,80)-(150,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (150,82)-(150,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (150,83)-(150,91) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (150,92)-(150,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.Name);
                        #line hidden
                        #line (150,101)-(150,110) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (150,111)-(150,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (151,22)-(151,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("            ");
                        #line (152,25)-(152,28) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (152,28)-(152,29) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,29)-(152,47) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary");
                        #line hidden
                        #line (152,47)-(152,48) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,48)-(152,49) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (152,49)-(152,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,51)-(152,60) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (152,61)-(152,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (152,76)-(152,77) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,77)-(152,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (152,83)-(152,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,84)-(152,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (152,86)-(152,87) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,87)-(152,90) 37 "SymbolGenerator.mxg"
                        __cb.Write("new");
                        #line hidden
                        #line (152,90)-(152,91) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,91)-(152,150) 37 "SymbolGenerator.mxg"
                        __cb.Write("global::System.Collections.Concurrent.ConcurrentDictionary<");
                        #line hidden
                        #line (152,151)-(152,178) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetCacheKeyType(symbol, op));
                        #line hidden
                        #line (152,179)-(152,180) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (152,180)-(152,181) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,182)-(152,192) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (152,193)-(152,198) 37 "SymbolGenerator.mxg"
                        __cb.Write(">());");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (153,25)-(153,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (153,31)-(153,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,32)-(153,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary.GetOrAdd(");
                        #line hidden
                        #line (153,61)-(153,70) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (153,71)-(153,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (153,72)-(153,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,73)-(153,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__args");
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
                    if (!__first25) __cb.AppendLine();
                    __cb.Push("        ");
                    #line (155,17)-(155,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (157,17)-(157,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (157,26)-(157,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (157,27)-(157,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (157,35)-(157,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (157,37)-(157,47) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (157,48)-(157,49) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (157,49)-(157,57) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (157,58)-(157,65) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (157,66)-(157,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first26 = true;
                    foreach (var __item27 in 
                    #line (157,68)-(157,138) 21 "SymbolGenerator.mxg"
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
                            #line (157,148)-(157,152) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item27);
                    }
                    #line (157,153)-(157,155) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (158,14)-(158,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("        ");
                    #line (159,17)-(159,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (159,23)-(159,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (159,24)-(159,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (159,32)-(159,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (159,34)-(159,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (159,45)-(159,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (159,47)-(159,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (159,55)-(159,56) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first28 = true;
                    foreach (var __item29 in 
                    #line (159,57)-(159,127) 21 "SymbolGenerator.mxg"
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
                            #line (159,137)-(159,141) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item29);
                    }
                    #line (159,142)-(159,144) 33 "SymbolGenerator.mxg"
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
            #line (163,10)-(163,40) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            __cb.Push("        ");
            #line (164,9)-(164,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (164,18)-(164,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,19)-(164,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (164,27)-(164,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,28)-(164,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (164,32)-(164,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,33)-(164,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (164,54)-(164,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,55)-(164,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (164,71)-(164,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,72)-(164,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (164,87)-(164,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,88)-(164,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (164,105)-(164,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,106)-(164,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (164,118)-(164,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,119)-(164,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (164,138)-(164,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,139)-(164,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (165,9)-(165,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (166,14)-(166,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            var __first30 = true;
            #line (167,14)-(167,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                #line (168,18)-(168,36) 17 "SymbolGenerator.mxg"
                hasNewPhase = true;
                #line hidden
                
                #line (169,18)-(169,63) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                __cb.Push("            ");
                #line (170,17)-(170,19) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (170,19)-(170,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,20)-(170,35) 29 "SymbolGenerator.mxg"
                __cb.Write("(incompletePart");
                #line hidden
                #line (170,35)-(170,36) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,36)-(170,38) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (170,38)-(170,39) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,39)-(170,61) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Start_");
                #line hidden
                #line (170,62)-(170,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (170,68)-(170,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,69)-(170,71) 29 "SymbolGenerator.mxg"
                __cb.Write("||");
                #line hidden
                #line (170,71)-(170,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,72)-(170,86) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart");
                #line hidden
                #line (170,86)-(170,87) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,87)-(170,89) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (170,89)-(170,90) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,90)-(170,113) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Finish_");
                #line hidden
                #line (170,114)-(170,119) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (170,120)-(170,121) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (171,17)-(171,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (172,21)-(172,23) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (172,23)-(172,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (172,24)-(172,64) 29 "SymbolGenerator.mxg"
                __cb.Write("(NotePartComplete(CompletionParts.Start_");
                #line hidden
                #line (172,65)-(172,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (172,71)-(172,73) 29 "SymbolGenerator.mxg"
                __cb.Write("))");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (173,21)-(173,22) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (174,25)-(174,28) 29 "SymbolGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (174,28)-(174,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,29)-(174,40) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics");
                #line hidden
                #line (174,40)-(174,41) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,41)-(174,42) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (174,42)-(174,43) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,43)-(174,73) 29 "SymbolGenerator.mxg"
                __cb.Write("__DiagnosticBag.GetInstance();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first31 = true;
                #line (175,26)-(175,48) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("                    ");
                    #line (176,29)-(176,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (176,32)-(176,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (176,33)-(176,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (176,39)-(176,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (176,40)-(176,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (176,41)-(176,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (176,42)-(176,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (176,51)-(176,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (176,57)-(176,70) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (176,70)-(176,71) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (176,71)-(176,90) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first32 = true;
                    #line (177,30)-(177,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        __cb.Push("                    ");
                        #line (178,34)-(178,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first32) __cb.AppendLine();
                }
                #line (180,26)-(180,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    #line (181,30)-(181,49) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
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
                    __cb.Push("                    ");
                    #line (183,30)-(183,68) 32 "SymbolGenerator.mxg"
                    __cb.Write(AssignProperty(symbol, prop, "result"));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (184,26)-(184,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("                    ");
                    #line (185,30)-(185,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (185,36)-(185,49) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (185,49)-(185,50) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (185,50)-(185,69) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first31) __cb.AppendLine();
                __cb.Push("                    ");
                #line (187,25)-(187,59) 29 "SymbolGenerator.mxg"
                __cb.Write("AddSymbolDiagnostics(diagnostics);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (188,25)-(188,44) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics.Free();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (189,25)-(189,65) 29 "SymbolGenerator.mxg"
                __cb.Write("NotePartComplete(CompletionParts.Finish_");
                #line hidden
                #line (189,66)-(189,71) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (189,72)-(189,74) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (190,21)-(190,22) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (191,21)-(191,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (191,27)-(191,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (191,28)-(191,33) 29 "SymbolGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (192,17)-(192,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (193,17)-(193,21) 29 "SymbolGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (193,21)-(193,22) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first30) __cb.AppendLine();
            var __first33 = true;
            #line (195,14)-(195,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("            ");
                #line (196,17)-(196,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (197,21)-(197,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (197,27)-(197,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (197,28)-(197,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (197,54)-(197,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (197,55)-(197,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (197,70)-(197,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (197,71)-(197,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (197,83)-(197,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (197,84)-(197,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (198,17)-(198,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (199,14)-(199,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("            ");
                #line (200,17)-(200,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (200,23)-(200,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,24)-(200,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (200,50)-(200,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,51)-(200,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (200,66)-(200,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,67)-(200,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (200,79)-(200,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,80)-(200,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first33) __cb.AppendLine();
            __cb.Push("        ");
            #line (202,9)-(202,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first34 = true;
            #line (204,10)-(204,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (206,14)-(206,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first35 = true;
                #line (207,14)-(207,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    #line (208,18)-(208,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    var __first36 = true;
                    #line (209,18)-(209,58) 21 "SymbolGenerator.mxg"
                    if (props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first36)
                        {
                            __first36 = false;
                        }
                        __cb.Push("        ");
                        #line (210,21)-(210,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (210,30)-(210,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (210,31)-(210,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (210,39)-(210,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (210,41)-(210,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (210,52)-(210,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (210,53)-(210,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (210,62)-(210,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (210,68)-(210,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (210,84)-(210,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (210,85)-(210,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (210,97)-(210,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (210,98)-(210,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (210,117)-(210,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (210,118)-(210,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (211,18)-(211,22) 21 "SymbolGenerator.mxg"
                    else
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
                        #line (212,31)-(212,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (212,38)-(212,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,40)-(212,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (212,51)-(212,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,52)-(212,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (212,61)-(212,66) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (212,67)-(212,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (212,83)-(212,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,84)-(212,96) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (212,96)-(212,97) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,97)-(212,116) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (212,116)-(212,117) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,117)-(212,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (213,21)-(213,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = true;
                        __cb.Push("            ");
                        #line (215,25)-(215,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (215,31)-(215,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (215,32)-(215,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first37 = true;
                        #line (216,30)-(216,58) 25 "SymbolGenerator.mxg"
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
                                #line (216,68)-(216,72) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Push("                ");
                            #line (217,33)-(217,69) 41 "SymbolGenerator.mxg"
                            __cb.Write("SymbolFactory.GetSymbolPropertyValue");
                            #line hidden
                            var __first38 = true;
                            #line (217,70)-(217,99) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first38)
                                {
                                    __first38 = false;
                                }
                                #line (217,100)-(217,101) 45 "SymbolGenerator.mxg"
                                __cb.Write("s");
                                #line hidden
                            }
                            #line (217,109)-(217,110) 41 "SymbolGenerator.mxg"
                            __cb.Write("<");
                            #line hidden
                            #line (217,111)-(217,146) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type.Type));
                            #line hidden
                            #line (217,147)-(217,154) 41 "SymbolGenerator.mxg"
                            __cb.Write(">(this,");
                            #line hidden
                            #line (217,154)-(217,155) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (217,155)-(217,162) 41 "SymbolGenerator.mxg"
                            __cb.Write("nameof(");
                            #line hidden
                            #line (217,163)-(217,172) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (217,173)-(217,175) 41 "SymbolGenerator.mxg"
                            __cb.Write("),");
                            #line hidden
                            #line (217,175)-(217,176) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (217,176)-(217,188) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (217,188)-(217,189) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (217,189)-(217,208) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first37) __cb.AppendLine();
                        __cb.Push("            ");
                        #line (219,25)-(219,27) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = false;
                        __cb.AppendLine();
                        __cb.Push("        ");
                        #line (221,21)-(221,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first36) __cb.AppendLine();
                }
                #line (223,14)-(223,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    #line (224,18)-(224,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (225,18)-(225,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    var __first39 = true;
                    #line (226,18)-(226,37) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first39)
                        {
                            __first39 = false;
                        }
                        __cb.Push("        ");
                        #line (227,21)-(227,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (227,30)-(227,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,31)-(227,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (227,39)-(227,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,41)-(227,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (227,52)-(227,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,53)-(227,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (227,62)-(227,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (227,68)-(227,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (227,84)-(227,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,85)-(227,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (227,97)-(227,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,98)-(227,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (227,117)-(227,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,118)-(227,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (228,18)-(228,22) 21 "SymbolGenerator.mxg"
                    else
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
                        #line (229,31)-(229,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (229,38)-(229,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,40)-(229,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (229,51)-(229,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,52)-(229,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (229,61)-(229,66) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (229,67)-(229,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (229,83)-(229,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,84)-(229,96) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (229,96)-(229,97) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,97)-(229,116) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (229,116)-(229,117) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,117)-(229,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (230,21)-(230,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (231,25)-(231,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (231,31)-(231,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,32)-(231,68) 37 "SymbolGenerator.mxg"
                        __cb.Write("SymbolFactory.GetSymbolPropertyValue");
                        #line hidden
                        var __first40 = true;
                        #line (231,69)-(231,98) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first40)
                            {
                                __first40 = false;
                            }
                            #line (231,99)-(231,100) 41 "SymbolGenerator.mxg"
                            __cb.Write("s");
                            #line hidden
                        }
                        #line (231,108)-(231,109) 37 "SymbolGenerator.mxg"
                        __cb.Write("<");
                        #line hidden
                        #line (231,110)-(231,145) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type.Type));
                        #line hidden
                        #line (231,146)-(231,153) 37 "SymbolGenerator.mxg"
                        __cb.Write(">(this,");
                        #line hidden
                        #line (231,153)-(231,154) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,154)-(231,161) 37 "SymbolGenerator.mxg"
                        __cb.Write("nameof(");
                        #line hidden
                        #line (231,162)-(231,171) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Name);
                        #line hidden
                        #line (231,172)-(231,174) 37 "SymbolGenerator.mxg"
                        __cb.Write("),");
                        #line hidden
                        #line (231,174)-(231,175) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,175)-(231,187) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (231,187)-(231,188) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,188)-(231,207) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (232,21)-(232,22) 37 "SymbolGenerator.mxg"
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
            #line (236,5)-(236,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (237,1)-(237,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (240,9)-(240,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (241,2)-(241,34) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (242,2)-(242,61) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            __cb.Push("");
            #line (243,1)-(243,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (243,6)-(243,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (243,7)-(243,14) 25 "SymbolGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (244,1)-(244,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (244,6)-(244,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (244,7)-(244,34) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Generic;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (245,1)-(245,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (245,6)-(245,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (245,7)-(245,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
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
            #line (246,7)-(246,19) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Linq;");
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
            #line (247,7)-(247,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
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
            #line (248,7)-(248,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
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
            #line (249,7)-(249,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
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
            #line (250,7)-(250,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (252,1)-(252,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (252,10)-(252,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (252,12)-(252,28) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.Namespace);
            #line hidden
            #line (252,29)-(252,44) 25 "SymbolGenerator.mxg"
            __cb.Write(".Implementation");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (253,1)-(253,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (254,5)-(254,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (254,10)-(254,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (254,11)-(254,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (254,18)-(254,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (254,19)-(254,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (254,20)-(254,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (254,21)-(254,45) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.Model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (255,5)-(255,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (255,10)-(255,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (255,11)-(255,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (255,25)-(255,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (255,26)-(255,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (255,27)-(255,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (255,28)-(255,59) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.IModelObject;");
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
            #line (256,11)-(256,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (256,20)-(256,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,21)-(256,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (256,22)-(256,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,23)-(256,54) 25 "SymbolGenerator.mxg"
            __cb.Write("Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (258,5)-(258,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (258,11)-(258,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,12)-(258,17) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (258,17)-(258,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,19)-(258,46) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (258,47)-(258,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,48)-(258,49) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (258,49)-(258,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,51)-(258,78) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (259,5)-(259,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (260,9)-(260,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (260,15)-(260,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,17)-(260,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (260,45)-(260,53) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol?");
            #line hidden
            #line (260,53)-(260,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,54)-(260,64) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (260,64)-(260,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,65)-(260,77) 25 "SymbolGenerator.mxg"
            __cb.Write("Compilation?");
            #line hidden
            #line (260,77)-(260,78) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,78)-(260,90) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (260,90)-(260,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,91)-(260,109) 25 "SymbolGenerator.mxg"
            __cb.Write("MergedDeclaration?");
            #line hidden
            #line (260,109)-(260,110) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,110)-(260,122) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (260,122)-(260,123) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,123)-(260,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (260,138)-(260,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,139)-(260,151) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (260,151)-(260,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,152)-(260,162) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol?");
            #line hidden
            #line (260,162)-(260,163) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,163)-(260,176) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (260,176)-(260,177) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,177)-(260,193) 25 "SymbolGenerator.mxg"
            __cb.Write("ErrorSymbolInfo?");
            #line hidden
            #line (260,193)-(260,194) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,194)-(260,204) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (260,204)-(260,205) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (261,13)-(261,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (261,14)-(261,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,15)-(261,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (261,30)-(261,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,31)-(261,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (261,43)-(261,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,44)-(261,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (261,56)-(261,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,57)-(261,63) 25 "SymbolGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (261,63)-(261,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,64)-(261,76) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (261,76)-(261,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,77)-(261,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (261,90)-(261,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,91)-(261,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (262,9)-(262,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (263,9)-(263,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (265,5)-(265,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (266,1)-(266,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (269,9)-(269,71) 22 "SymbolGenerator.mxg"
        public string AssignProperty(Symbol symbol, Property prop, string variable)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first41 = true;
            #line (270,6)-(270,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                var __first42 = true;
                #line (271,10)-(271,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.Push("");
                    #line (272,13)-(272,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (272,15)-(272,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (272,16)-(272,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("(!");
                    #line hidden
                    #line (272,19)-(272,27) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (272,28)-(272,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(".IsDefaultOrEmpty)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (273,13)-(273,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (274,18)-(274,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (274,37)-(274,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (274,47)-(274,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (274,49)-(274,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (274,58)-(274,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (275,13)-(275,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (276,10)-(276,14) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.Push("");
                    #line (277,13)-(277,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (277,15)-(277,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (277,16)-(277,17) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (277,18)-(277,26) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (277,27)-(277,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (277,28)-(277,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (277,30)-(277,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (277,32)-(277,61) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (277,62)-(277,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
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
                if (!__first42) __cb.AppendLine();
            }
            #line (282,6)-(282,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                __cb.Push("");
                #line (283,10)-(283,28) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (283,29)-(283,30) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (283,30)-(283,31) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (283,31)-(283,32) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (283,33)-(283,41) 28 "SymbolGenerator.mxg"
                __cb.Write(variable);
                #line hidden
                #line (283,42)-(283,43) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first41) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}