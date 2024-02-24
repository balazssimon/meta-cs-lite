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
            #line (15,11)-(15,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Phase");
            #line hidden
            #line (15,18)-(15,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,19)-(15,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (15,20)-(15,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,21)-(15,74) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.PhaseAttribute;");
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
            __cb.Write("__Derived");
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
            #line (16,23)-(16,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DerivedAttribute;");
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
            #line (17,11)-(17,17) 25 "SymbolGenerator.mxg"
            __cb.Write("__Weak");
            #line hidden
            #line (17,17)-(17,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,18)-(17,19) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (17,19)-(17,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,20)-(17,72) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.WeakAttribute;");
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
            #line (18,11)-(18,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (18,19)-(18,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,20)-(18,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (18,21)-(18,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,22)-(18,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
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
            #line (19,11)-(19,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__AttributeSymbol");
            #line hidden
            #line (19,28)-(19,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,29)-(19,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (19,30)-(19,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,31)-(19,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol;");
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
            #line (20,11)-(20,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__AssemblySymbol");
            #line hidden
            #line (20,27)-(20,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,28)-(20,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (20,29)-(20,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,30)-(20,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AssemblySymbol;");
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
            #line (21,11)-(21,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol");
            #line hidden
            #line (21,25)-(21,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,26)-(21,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (21,27)-(21,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,28)-(21,79) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModuleSymbol;");
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
            #line (22,11)-(22,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol");
            #line hidden
            #line (22,30)-(22,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,31)-(22,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (22,32)-(22,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,33)-(22,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol;");
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
            __cb.Write("__NamespaceSymbol");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol;");
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
            #line (24,11)-(24,23) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol");
            #line hidden
            #line (24,23)-(24,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,24)-(24,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (24,25)-(24,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,26)-(24,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol;");
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
            #line (25,11)-(25,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbolFactory");
            #line hidden
            #line (25,27)-(25,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,28)-(25,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (25,29)-(25,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,30)-(25,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory;");
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
            __cb.Write("__LexicalSortKey");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.LexicalSortKey;");
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
            #line (27,11)-(27,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (27,25)-(27,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,26)-(27,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (27,27)-(27,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,28)-(27,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
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
            #line (28,11)-(28,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (28,18)-(28,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,19)-(28,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (28,20)-(28,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,21)-(28,53) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
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
            #line (29,11)-(29,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (29,28)-(29,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,29)-(29,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (29,30)-(29,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,31)-(29,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
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
            #line (30,11)-(30,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (30,26)-(30,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,27)-(30,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (30,28)-(30,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,29)-(30,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
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
            #line (31,11)-(31,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (31,28)-(31,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,29)-(31,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (31,30)-(31,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,31)-(31,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
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
            #line (32,11)-(32,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (32,27)-(32,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,28)-(32,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (32,29)-(32,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,30)-(32,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
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
            #line (33,11)-(33,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (33,30)-(33,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,31)-(33,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (33,32)-(33,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,33)-(33,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
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
            #line (34,11)-(34,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (34,26)-(34,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,27)-(34,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (34,28)-(34,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,29)-(34,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
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
            #line (35,11)-(35,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (35,24)-(35,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,25)-(35,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (35,26)-(35,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,27)-(35,69) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Compilation;");
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
            __cb.Write("__SourceLocation");
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
            #line (36,30)-(36,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
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
            __cb.Write("__CancellationToken");
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
            #line (37,33)-(37,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
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
            #line (38,11)-(38,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (38,36)-(38,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,37)-(38,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (38,38)-(38,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,39)-(38,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
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
            __cb.Write("__CultureInfo");
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
            #line (39,27)-(39,68) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Globalization.CultureInfo;");
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
            #line (40,11)-(40,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (40,38)-(40,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,39)-(40,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (40,40)-(40,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,41)-(40,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            #line (42,6)-(42,38) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (43,6)-(43,65) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            #line (44,6)-(44,122) 13 "SymbolGenerator.mxg"
            var baseName = baseSymbol is null ? "global::MetaDslx.CodeAnalysis.Symbols.Symbol" : GetBaseName(symbol, baseSymbol);
            #line hidden
            
            __cb.Push("    ");
            #line (45,5)-(45,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (45,11)-(45,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,12)-(45,20) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (45,20)-(45,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,21)-(45,28) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (45,28)-(45,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,29)-(45,34) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (45,34)-(45,35) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,36)-(45,63) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (45,64)-(45,65) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (45,65)-(45,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,67)-(45,75) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (46,5)-(46,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (47,9)-(47,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (47,15)-(47,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,16)-(47,19) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (47,19)-(47,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,20)-(47,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (47,25)-(47,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,26)-(47,41) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts");
            #line hidden
            #line (47,41)-(47,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,42)-(47,43) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (47,43)-(47,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,45)-(47,53) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            #line (47,54)-(47,70) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (48,9)-(48,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first1 = true;
            #line (49,14)-(49,54) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                __cb.Push("            ");
                #line (50,17)-(50,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (50,23)-(50,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (50,24)-(50,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (50,30)-(50,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (50,31)-(50,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (50,39)-(50,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (50,40)-(50,56) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart");
                #line hidden
                #line (50,56)-(50,57) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (50,57)-(50,63) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (50,64)-(50,69) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (50,70)-(50,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (50,71)-(50,72) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (50,72)-(50,73) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (50,73)-(50,76) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (50,76)-(50,77) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (50,77)-(50,107) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart(nameof(Start_");
                #line hidden
                #line (50,108)-(50,113) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (50,114)-(50,117) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (51,17)-(51,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (51,23)-(51,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (51,24)-(51,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (51,30)-(51,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (51,31)-(51,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (51,39)-(51,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (51,40)-(51,56) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart");
                #line hidden
                #line (51,56)-(51,57) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (51,57)-(51,64) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (51,65)-(51,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (51,71)-(51,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (51,72)-(51,73) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (51,73)-(51,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (51,74)-(51,77) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (51,77)-(51,78) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (51,78)-(51,109) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart(nameof(Finish_");
                #line hidden
                #line (51,110)-(51,115) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (51,116)-(51,119) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first1) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (54,13)-(54,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (54,19)-(54,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,20)-(54,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (54,26)-(54,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,27)-(54,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (54,35)-(54,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,36)-(54,53) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (54,53)-(54,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,54)-(54,69) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (54,69)-(54,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,70)-(54,71) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (54,71)-(54,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (55,17)-(55,51) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph.CreateFromParts(");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (56,22)-(56,30) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            #line (56,31)-(56,63) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts.CompletionGraph");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first2 = true;
            #line (57,22)-(57,62) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first2)
                {
                    __first2 = false;
                }
                __cb.Push("                    ");
                #line (58,25)-(58,26) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (58,26)-(58,27) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (58,27)-(58,33) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (58,34)-(58,39) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (58,40)-(58,41) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (58,41)-(58,42) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (58,42)-(58,49) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (58,50)-(58,55) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            __cb.Push("                ");
            #line (60,17)-(60,19) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (61,9)-(61,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first3 = true;
            #line (63,10)-(63,75) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsAbstract))
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                var __first4 = true;
                #line (64,14)-(64,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first4)
                    {
                        __first4 = false;
                    }
                    __cb.Push("        ");
                    #line (65,17)-(65,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (65,24)-(65,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (65,25)-(65,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (65,31)-(65,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (65,33)-(65,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (65,60)-(65,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (65,62)-(65,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (65,81)-(65,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (65,82)-(65,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (65,83)-(65,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (65,84)-(65,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (65,87)-(65,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (65,89)-(65,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (65,116)-(65,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (66,14)-(66,18) 17 "SymbolGenerator.mxg"
                else
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
                    #line (67,26)-(67,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (67,53)-(67,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (67,55)-(67,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (67,74)-(67,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first4) __cb.AppendLine();
            }
            if (!__first3) __cb.AppendLine();
            var __first5 = true;
            #line (70,10)-(70,70) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations.Where(o => o.IsCached))
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
                __cb.Push("        ");
                #line (71,13)-(71,20) 29 "SymbolGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (71,20)-(71,21) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (71,21)-(71,27) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (71,27)-(71,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (71,29)-(71,53) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (71,54)-(71,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (71,56)-(71,72) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(op));
                #line hidden
                #line (71,73)-(71,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (71,74)-(71,75) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (71,75)-(71,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (71,76)-(71,79) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (71,79)-(71,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (71,81)-(71,105) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (71,106)-(71,109) 29 "SymbolGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (74,9)-(74,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (74,15)-(74,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,17)-(74,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (74,45)-(74,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol?");
            #line hidden
            #line (74,55)-(74,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,56)-(74,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (74,66)-(74,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,67)-(74,81) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation?");
            #line hidden
            #line (74,81)-(74,82) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,82)-(74,93) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation");
            #line hidden
            #line (74,93)-(74,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,94)-(74,95) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,95)-(74,96) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,96)-(74,101) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (74,101)-(74,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,102)-(74,122) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration?");
            #line hidden
            #line (74,122)-(74,123) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,123)-(74,134) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration");
            #line hidden
            #line (74,134)-(74,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,135)-(74,136) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,136)-(74,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,137)-(74,142) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (74,142)-(74,143) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,143)-(74,151) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model?");
            #line hidden
            #line (74,151)-(74,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,152)-(74,157) 25 "SymbolGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (74,157)-(74,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,158)-(74,159) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,159)-(74,160) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,160)-(74,165) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (74,165)-(74,166) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,166)-(74,181) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (74,181)-(74,182) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,182)-(74,193) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (74,193)-(74,194) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,194)-(74,195) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,195)-(74,196) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,196)-(74,201) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (74,201)-(74,202) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,202)-(74,211) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (74,211)-(74,212) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,212)-(74,224) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol");
            #line hidden
            #line (74,224)-(74,225) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,225)-(74,226) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,226)-(74,227) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,227)-(74,232) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (74,232)-(74,233) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,233)-(74,251) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo?");
            #line hidden
            #line (74,251)-(74,252) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,252)-(74,261) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo");
            #line hidden
            #line (74,261)-(74,262) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,262)-(74,263) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,263)-(74,264) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,264)-(74,269) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (74,269)-(74,270) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,270)-(74,274) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (74,274)-(74,275) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,275)-(74,286) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol");
            #line hidden
            #line (74,286)-(74,287) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,287)-(74,288) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,288)-(74,289) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,289)-(74,295) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (74,295)-(74,296) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,296)-(74,303) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (74,303)-(74,304) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,304)-(74,308) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (74,308)-(74,309) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,309)-(74,310) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,310)-(74,311) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,311)-(74,319) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (74,319)-(74,320) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,320)-(74,327) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (74,327)-(74,328) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,328)-(74,340) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (74,340)-(74,341) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,341)-(74,342) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,342)-(74,343) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,343)-(74,351) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (74,351)-(74,352) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,352)-(74,420) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>");
            #line hidden
            #line (74,420)-(74,421) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,421)-(74,431) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (74,431)-(74,432) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,432)-(74,433) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,433)-(74,434) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,434)-(74,441) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first6 = true;
            #line (74,442)-(74,527) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsAbstract && !p.IsDerived))
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                #line (74,528)-(74,529) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (74,529)-(74,530) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (74,531)-(74,561) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (74,562)-(74,563) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (74,564)-(74,582) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (74,583)-(74,584) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (74,584)-(74,585) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (74,585)-(74,586) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (74,587)-(74,621) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (74,635)-(74,636) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (74,636)-(74,637) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (75,13)-(75,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (75,14)-(75,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,15)-(75,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (75,30)-(75,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,31)-(75,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (75,43)-(75,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,44)-(75,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (75,56)-(75,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,57)-(75,63) 25 "SymbolGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (75,63)-(75,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,64)-(75,76) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (75,76)-(75,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,77)-(75,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (75,90)-(75,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,91)-(75,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (75,101)-(75,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,102)-(75,114) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol,");
            #line hidden
            #line (75,114)-(75,115) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,115)-(75,120) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (75,120)-(75,121) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,121)-(75,134) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (75,134)-(75,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,135)-(75,145) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first7 = true;
            #line (75,146)-(75,235) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsAbstract && !p.IsDerived))
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (75,236)-(75,237) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (75,237)-(75,238) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (75,239)-(75,257) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (75,258)-(75,259) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (75,259)-(75,260) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (75,261)-(75,279) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (75,293)-(75,294) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (76,9)-(76,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (77,13)-(77,15) 25 "SymbolGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (77,15)-(77,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,16)-(77,29) 25 "SymbolGenerator.mxg"
            __cb.Write("(fixedSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (78,13)-(78,14) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first8 = true;
            #line (79,18)-(79,99) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsAbstract && !p.IsDerived))
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                __cb.Push("                ");
                #line (80,22)-(80,70) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first8) __cb.AppendLine();
            __cb.Push("            ");
            #line (82,13)-(82,14) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (83,9)-(83,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (85,9)-(85,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (85,15)-(85,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,16)-(85,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (85,24)-(85,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,25)-(85,31) 25 "SymbolGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (85,31)-(85,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,32)-(85,42) 25 "SymbolGenerator.mxg"
            __cb.Write("SymbolType");
            #line hidden
            #line (85,42)-(85,43) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,43)-(85,45) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (85,45)-(85,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,46)-(85,53) 25 "SymbolGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (85,54)-(85,81) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (85,82)-(85,84) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (86,9)-(86,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (86,18)-(86,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,19)-(86,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (86,27)-(86,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,28)-(86,43) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (86,43)-(86,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,44)-(86,59) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (86,59)-(86,60) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,60)-(86,62) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (86,62)-(86,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,63)-(86,95) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first9 = true;
            #line (88,10)-(88,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                var __first10 = true;
                #line (89,14)-(89,51) 17 "SymbolGenerator.mxg"
                if (!prop.IsDerived && !prop.IsPlain)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (90,18)-(90,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (90,22)-(90,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (90,38)-(90,41) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                var __first11 = true;
                #line (92,14)-(92,32) 17 "SymbolGenerator.mxg"
                if (!prop.IsPlain)
                #line hidden
                
                {
                    if (__first11)
                    {
                        __first11 = false;
                    }
                    __cb.Push("        ");
                    #line (93,18)-(93,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (93,22)-(93,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Phase");
                    #line hidden
                    var __first12 = true;
                    #line (93,30)-(93,57) 21 "SymbolGenerator.mxg"
                    if (prop.Phase is not null)
                    #line hidden
                    
                    {
                        if (__first12)
                        {
                            __first12 = false;
                        }
                        #line (93,58)-(93,66) 37 "SymbolGenerator.mxg"
                        __cb.Write("(nameof(");
                        #line hidden
                        #line (93,67)-(93,82) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Phase.Name);
                        #line hidden
                        #line (93,83)-(93,85) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                    }
                    #line (93,94)-(93,97) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first11) __cb.AppendLine();
                var __first13 = true;
                #line (95,14)-(95,33) 17 "SymbolGenerator.mxg"
                if (prop.IsDerived)
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    __cb.Push("        ");
                    #line (96,18)-(96,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (96,22)-(96,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Derived");
                    #line hidden
                    var __first14 = true;
                    #line (96,32)-(96,50) 21 "SymbolGenerator.mxg"
                    if (prop.IsCached)
                    #line hidden
                    
                    {
                        if (__first14)
                        {
                            __first14 = false;
                        }
                        #line (96,51)-(96,64) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true)");
                        #line hidden
                    }
                    #line (96,73)-(96,76) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first13) __cb.AppendLine();
                var __first15 = true;
                #line (98,14)-(98,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first15)
                    {
                        __first15 = false;
                    }
                    __cb.Push("        ");
                    #line (99,18)-(99,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (99,22)-(99,28) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Weak");
                    #line hidden
                    #line (99,29)-(99,32) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first15) __cb.AppendLine();
                __cb.Push("        ");
                #line (101,13)-(101,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (101,19)-(101,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first16 = true;
                #line (101,21)-(101,41) 17 "SymbolGenerator.mxg"
                if (prop.IsAbstract)
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    #line (101,42)-(101,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (101,50)-(101,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (101,60)-(101,90) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (101,91)-(101,92) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (101,93)-(101,102) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (102,13)-(102,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first17 = true;
                #line (103,18)-(103,35) 17 "SymbolGenerator.mxg"
                if (prop.IsPlain)
                #line hidden
                
                {
                    if (__first17)
                    {
                        __first17 = false;
                    }
                    var __first18 = true;
                    #line (104,22)-(104,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsAbstract)
                    #line hidden
                    
                    {
                        if (__first18)
                        {
                            __first18 = false;
                        }
                        __cb.Push("            ");
                        #line (105,25)-(105,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("get;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (106,22)-(106,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first18)
                        {
                            __first18 = false;
                        }
                        var __first19 = true;
                        #line (107,26)-(107,42) 25 "SymbolGenerator.mxg"
                        if (prop.IsWeak)
                        #line hidden
                        
                        {
                            if (__first19)
                            {
                                __first19 = false;
                            }
                            __cb.Push("            ");
                            #line (108,29)-(108,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (109,29)-(109,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (110,33)-(110,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (110,35)-(110,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (110,36)-(110,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (110,38)-(110,56) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (110,57)-(110,75) 41 "SymbolGenerator.mxg"
                            __cb.Write(".TryGetValue(this,");
                            #line hidden
                            #line (110,75)-(110,76) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (110,76)-(110,79) 41 "SymbolGenerator.mxg"
                            __cb.Write("out");
                            #line hidden
                            #line (110,79)-(110,80) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (110,80)-(110,83) 41 "SymbolGenerator.mxg"
                            __cb.Write("var");
                            #line hidden
                            #line (110,83)-(110,84) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (110,84)-(110,92) 41 "SymbolGenerator.mxg"
                            __cb.Write("result))");
                            #line hidden
                            #line (110,92)-(110,93) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (110,93)-(110,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (110,99)-(110,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (110,100)-(110,101) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (110,102)-(110,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type));
                            #line hidden
                            #line (110,133)-(110,141) 41 "SymbolGenerator.mxg"
                            __cb.Write(")result;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (111,33)-(111,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("else");
                            #line hidden
                            #line (111,37)-(111,38) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (111,38)-(111,44) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (111,44)-(111,45) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (111,46)-(111,75) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (111,76)-(111,77) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (112,29)-(112,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (113,29)-(113,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (113,38)-(113,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (113,39)-(113,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (114,29)-(114,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (115,34)-(115,71) 40 "SymbolGenerator.mxg"
                            __cb.Write(AssignProperty(symbol, prop, "value"));
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (116,29)-(116,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (117,26)-(117,30) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first19)
                            {
                                __first19 = false;
                            }
                            __cb.Push("            ");
                            #line (118,29)-(118,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            #line (118,32)-(118,33) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (118,33)-(118,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (118,35)-(118,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (118,37)-(118,55) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (118,56)-(118,57) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (119,29)-(119,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (119,38)-(119,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (119,39)-(119,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
                            #line hidden
                            #line (119,42)-(119,43) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (119,43)-(119,45) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (119,45)-(119,46) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (119,47)-(119,65) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (119,66)-(119,67) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (119,67)-(119,68) 41 "SymbolGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (119,68)-(119,69) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (119,69)-(119,75) 41 "SymbolGenerator.mxg"
                            __cb.Write("value;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first19) __cb.AppendLine();
                    }
                    if (!__first18) __cb.AppendLine();
                }
                #line (122,18)-(122,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first17)
                    {
                        __first17 = false;
                    }
                    __cb.Push("            ");
                    #line (123,21)-(123,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (124,21)-(124,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (125,25)-(125,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("this.ForceComplete(CompletionParts.Finish_");
                    #line hidden
                    #line (125,68)-(125,97) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (125,98)-(125,99) 33 "SymbolGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (125,99)-(125,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (125,100)-(125,105) 33 "SymbolGenerator.mxg"
                    __cb.Write("null,");
                    #line hidden
                    #line (125,105)-(125,106) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (125,106)-(125,115) 33 "SymbolGenerator.mxg"
                    __cb.Write("default);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first20 = true;
                    #line (126,26)-(126,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        __cb.Push("                ");
                        #line (127,29)-(127,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (127,31)-(127,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (127,32)-(127,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (127,34)-(127,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (127,53)-(127,71) 37 "SymbolGenerator.mxg"
                        __cb.Write(".TryGetValue(this,");
                        #line hidden
                        #line (127,71)-(127,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (127,72)-(127,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("out");
                        #line hidden
                        #line (127,75)-(127,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (127,76)-(127,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (127,79)-(127,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (127,80)-(127,88) 37 "SymbolGenerator.mxg"
                        __cb.Write("result))");
                        #line hidden
                        #line (127,88)-(127,89) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (127,89)-(127,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (127,95)-(127,96) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (127,96)-(127,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (127,98)-(127,128) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (127,129)-(127,137) 37 "SymbolGenerator.mxg"
                        __cb.Write(")result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (128,29)-(128,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("else");
                        #line hidden
                        #line (128,33)-(128,34) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (128,34)-(128,40) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (128,40)-(128,41) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (128,42)-(128,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (128,72)-(128,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (129,26)-(129,30) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        __cb.Push("                ");
                        #line (130,29)-(130,35) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (130,35)-(130,36) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (130,37)-(130,55) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (130,56)-(130,57) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first20) __cb.AppendLine();
                    __cb.Push("            ");
                    #line (132,21)-(132,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first17) __cb.AppendLine();
                __cb.Push("        ");
                #line (134,13)-(134,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first21 = true;
            #line (137,10)-(137,47) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations)
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
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
                var __first22 = true;
                #line (142,14)-(142,29) 17 "SymbolGenerator.mxg"
                if (op.IsPhase)
                #line hidden
                
                {
                    if (__first22)
                    {
                        __first22 = false;
                    }
                    __cb.Push("        ");
                    #line (143,18)-(143,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (143,22)-(143,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Phase");
                    #line hidden
                    #line (143,30)-(143,33) 32 "SymbolGenerator.mxg"
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
                    if (__first22)
                    {
                        __first22 = false;
                    }
                    __cb.Push("        ");
                    #line (146,18)-(146,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (146,22)-(146,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Derived");
                    #line hidden
                    var __first23 = true;
                    #line (146,32)-(146,48) 21 "SymbolGenerator.mxg"
                    if (op.IsCached)
                    #line hidden
                    
                    {
                        if (__first23)
                        {
                            __first23 = false;
                        }
                        #line (146,49)-(146,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true");
                        #line hidden
                        var __first24 = true;
                        #line (146,62)-(146,107) 25 "SymbolGenerator.mxg"
                        if (!string.IsNullOrEmpty(op.CacheCondition))
                        #line hidden
                        
                        {
                            if (__first24)
                            {
                                __first24 = false;
                            }
                            #line (146,108)-(146,109) 41 "SymbolGenerator.mxg"
                            __cb.Write(",");
                            #line hidden
                            #line (146,109)-(146,110) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (146,110)-(146,120) 41 "SymbolGenerator.mxg"
                            __cb.Write("Condition=");
                            #line hidden
                            #line (146,121)-(146,153) 40 "SymbolGenerator.mxg"
                            __cb.Write(op.CacheCondition.EncodeString());
                            #line hidden
                        }
                        #line (146,162)-(146,163) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                    }
                    #line (146,172)-(146,175) 32 "SymbolGenerator.mxg"
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
                    var __first25 = true;
                    foreach (var __item26 in 
                    #line (147,48)-(147,118) 21 "SymbolGenerator.mxg"
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
                            #line (147,128)-(147,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item26);
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
                    var __first27 = true;
                    #line (149,22)-(149,67) 21 "SymbolGenerator.mxg"
                    if (!string.IsNullOrEmpty(op.CacheCondition))
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
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
                    if (!__first27) __cb.AppendLine();
                    #line (152,22)-(152,54) 21 "SymbolGenerator.mxg"
                    var fieldName = GetFieldName(op);
                    #line hidden
                    
                    var __first28 = true;
                    #line (153,22)-(153,51) 21 "SymbolGenerator.mxg"
                    if (op.Parameters.Count == 0)
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
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
                        if (__first28)
                        {
                            __first28 = false;
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
                    if (!__first28) __cb.AppendLine();
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
                    var __first29 = true;
                    foreach (var __item30 in 
                    #line (161,68)-(161,138) 21 "SymbolGenerator.mxg"
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
                            #line (161,148)-(161,152) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item30);
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
                    if (__first22)
                    {
                        __first22 = false;
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
                    var __first31 = true;
                    foreach (var __item32 in 
                    #line (163,57)-(163,127) 21 "SymbolGenerator.mxg"
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
                            #line (163,137)-(163,141) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item32);
                    }
                    #line (163,142)-(163,144) 33 "SymbolGenerator.mxg"
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
            
            var __first33 = true;
            #line (171,14)-(171,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
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
                __cb.Push("                    ");
                #line (178,25)-(178,28) 29 "SymbolGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (178,28)-(178,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,29)-(178,40) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics");
                #line hidden
                #line (178,40)-(178,41) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,41)-(178,42) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (178,42)-(178,43) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,43)-(178,73) 29 "SymbolGenerator.mxg"
                __cb.Write("__DiagnosticBag.GetInstance();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first34 = true;
                #line (179,26)-(179,48) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
                    }
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
                    var __first35 = true;
                    #line (181,30)-(181,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first35)
                        {
                            __first35 = false;
                        }
                        __cb.Push("                    ");
                        #line (182,34)-(182,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first35) __cb.AppendLine();
                }
                #line (184,26)-(184,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
                    }
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
                    #line (186,30)-(186,72) 32 "SymbolGenerator.mxg"
                    __cb.Write(AssignProperty(symbol, props[0], "result"));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (187,26)-(187,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
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
                if (!__first34) __cb.AppendLine();
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
            if (!__first33) __cb.AppendLine();
            var __first36 = true;
            #line (198,14)-(198,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
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
                if (__first36)
                {
                    __first36 = false;
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
            if (!__first36) __cb.AppendLine();
            __cb.Push("        ");
            #line (205,9)-(205,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first37 = true;
            #line (207,10)-(207,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (209,14)-(209,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first38 = true;
                #line (210,14)-(210,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first38)
                    {
                        __first38 = false;
                    }
                    #line (211,18)-(211,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    var __first39 = true;
                    #line (212,18)-(212,58) 21 "SymbolGenerator.mxg"
                    if (props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first39)
                        {
                            __first39 = false;
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
                        var __first40 = true;
                        #line (219,30)-(219,58) 25 "SymbolGenerator.mxg"
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
                            var __first41 = true;
                            #line (220,70)-(220,99) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first41)
                                {
                                    __first41 = false;
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
                        if (!__first40) __cb.AppendLine();
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
                    if (!__first39) __cb.AppendLine();
                }
                #line (226,14)-(226,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first38)
                    {
                        __first38 = false;
                    }
                    #line (227,18)-(227,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (228,18)-(228,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    var __first42 = true;
                    #line (229,18)-(229,37) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first42)
                        {
                            __first42 = false;
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
                        var __first43 = true;
                        #line (234,69)-(234,98) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first43)
                            {
                                __first43 = false;
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
                    if (!__first42) __cb.AppendLine();
                }
                if (!__first38) __cb.AppendLine();
            }
            if (!__first37) __cb.AppendLine();
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
            #line (255,12)-(255,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (255,33)-(255,38) 25 "SymbolGenerator.mxg"
            __cb.Write(".Impl");
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
            #line (263,78)-(263,89) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation");
            #line hidden
            #line (263,89)-(263,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,90)-(263,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (263,91)-(263,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,92)-(263,97) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (263,97)-(263,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,98)-(263,116) 25 "SymbolGenerator.mxg"
            __cb.Write("MergedDeclaration?");
            #line hidden
            #line (263,116)-(263,117) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,117)-(263,128) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration");
            #line hidden
            #line (263,128)-(263,129) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,129)-(263,130) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (263,130)-(263,131) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,131)-(263,136) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (263,136)-(263,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,137)-(263,145) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model?");
            #line hidden
            #line (263,145)-(263,146) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,146)-(263,151) 25 "SymbolGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (263,151)-(263,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,152)-(263,153) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (263,153)-(263,154) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,154)-(263,159) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (263,159)-(263,160) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,160)-(263,175) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (263,175)-(263,176) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,176)-(263,187) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (263,187)-(263,188) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,188)-(263,189) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (263,189)-(263,190) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,190)-(263,195) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (263,195)-(263,196) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,196)-(263,205) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (263,205)-(263,206) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,206)-(263,218) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol");
            #line hidden
            #line (263,218)-(263,219) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,219)-(263,220) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (263,220)-(263,221) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,221)-(263,226) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (263,226)-(263,227) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,227)-(263,243) 25 "SymbolGenerator.mxg"
            __cb.Write("ErrorSymbolInfo?");
            #line hidden
            #line (263,243)-(263,244) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,244)-(263,253) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo");
            #line hidden
            #line (263,253)-(263,254) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,254)-(263,255) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (263,255)-(263,256) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,256)-(263,261) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (263,261)-(263,262) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,262)-(263,266) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (263,266)-(263,267) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,267)-(263,278) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol");
            #line hidden
            #line (263,278)-(263,279) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,279)-(263,280) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (263,280)-(263,281) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,281)-(263,287) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (263,287)-(263,288) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,288)-(263,295) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (263,295)-(263,296) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,296)-(263,300) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (263,300)-(263,301) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,301)-(263,302) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (263,302)-(263,303) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,303)-(263,311) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (263,311)-(263,312) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,312)-(263,319) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (263,319)-(263,320) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,320)-(263,332) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (263,332)-(263,333) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,333)-(263,334) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (263,334)-(263,335) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,335)-(263,343) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (263,343)-(263,344) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,344)-(263,412) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>");
            #line hidden
            #line (263,412)-(263,413) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,413)-(263,423) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (263,423)-(263,424) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,424)-(263,425) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (263,425)-(263,426) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,426)-(263,433) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first44 = true;
            #line (263,434)-(263,502) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                #line (263,503)-(263,504) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (263,504)-(263,505) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (263,506)-(263,536) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (263,537)-(263,538) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (263,539)-(263,557) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (263,558)-(263,559) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (263,559)-(263,560) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (263,560)-(263,561) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (263,562)-(263,596) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (263,610)-(263,611) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (263,611)-(263,612) 25 "SymbolGenerator.mxg"
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
            __cb.Write("errorInfo,");
            #line hidden
            #line (264,101)-(264,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,102)-(264,114) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol,");
            #line hidden
            #line (264,114)-(264,115) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,115)-(264,120) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (264,120)-(264,121) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,121)-(264,134) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (264,134)-(264,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,135)-(264,145) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first45 = true;
            #line (264,146)-(264,218) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                #line (264,219)-(264,220) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (264,220)-(264,221) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (264,222)-(264,240) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (264,241)-(264,242) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (264,242)-(264,243) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (264,244)-(264,262) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (264,276)-(264,277) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
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
            var __first46 = true;
            #line (273,6)-(273,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                var __first47 = true;
                #line (274,10)-(274,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first47)
                    {
                        __first47 = false;
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
                    if (__first47)
                    {
                        __first47 = false;
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
                if (!__first47) __cb.AppendLine();
            }
            #line (285,6)-(285,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
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
            if (!__first46) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}