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
            #line (13,11)-(13,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (13,20)-(13,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,21)-(13,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (13,22)-(13,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,23)-(13,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
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
            #line (14,11)-(14,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Phase");
            #line hidden
            #line (14,18)-(14,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,19)-(14,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (14,20)-(14,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,21)-(14,74) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.PhaseAttribute;");
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
            #line (15,11)-(15,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__Derived");
            #line hidden
            #line (15,20)-(15,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,21)-(15,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (15,22)-(15,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,23)-(15,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DerivedAttribute;");
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
            __cb.Write("__Weak");
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
            #line (16,20)-(16,72) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.WeakAttribute;");
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
            #line (17,11)-(17,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (17,19)-(17,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,20)-(17,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (17,21)-(17,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,22)-(17,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
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
            __cb.Write("__AttributeSymbol");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol;");
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
            __cb.Write("__AssemblySymbol");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AssemblySymbol;");
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
            #line (20,11)-(20,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol");
            #line hidden
            #line (20,25)-(20,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,26)-(20,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (20,27)-(20,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,28)-(20,79) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModuleSymbol;");
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
            #line (21,11)-(21,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol");
            #line hidden
            #line (21,30)-(21,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,31)-(21,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (21,32)-(21,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,33)-(21,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol;");
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
            __cb.Write("__NamespaceSymbol");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol;");
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
            #line (23,11)-(23,23) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol");
            #line hidden
            #line (23,23)-(23,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,24)-(23,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (23,25)-(23,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,26)-(23,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol;");
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
            __cb.Write("__ISymbolFactory");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory;");
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
            __cb.Write("__LexicalSortKey");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.LexicalSortKey;");
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
            #line (26,11)-(26,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (26,25)-(26,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,26)-(26,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (26,27)-(26,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,28)-(26,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
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
            #line (27,11)-(27,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (27,18)-(27,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,19)-(27,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (27,20)-(27,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,21)-(27,53) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
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
            #line (28,11)-(28,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (28,28)-(28,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,29)-(28,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (28,30)-(28,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,31)-(28,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
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
            #line (29,11)-(29,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (29,26)-(29,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,27)-(29,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (29,28)-(29,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,29)-(29,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
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
            __cb.Write("__CompletionGraph");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
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
            #line (31,11)-(31,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (31,27)-(31,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,28)-(31,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (31,29)-(31,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,30)-(31,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
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
            #line (32,11)-(32,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (32,30)-(32,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,31)-(32,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (32,32)-(32,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,33)-(32,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
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
            #line (33,11)-(33,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (33,26)-(33,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,27)-(33,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (33,28)-(33,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,29)-(33,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
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
            #line (34,11)-(34,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (34,24)-(34,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,25)-(34,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (34,26)-(34,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,27)-(34,69) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Compilation;");
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
            __cb.Write("__SourceLocation");
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
            #line (35,30)-(35,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
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
            __cb.Write("__CancellationToken");
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
            #line (36,33)-(36,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
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
            #line (37,11)-(37,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (37,36)-(37,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,37)-(37,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (37,38)-(37,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,39)-(37,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
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
            __cb.Write("__CultureInfo");
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
            #line (38,27)-(38,68) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Globalization.CultureInfo;");
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
            #line (39,11)-(39,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (39,38)-(39,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,39)-(39,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (39,40)-(39,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,41)-(39,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            #line (41,6)-(41,38) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (42,6)-(42,65) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            #line (43,6)-(43,122) 13 "SymbolGenerator.mxg"
            var baseName = baseSymbol is null ? "global::MetaDslx.CodeAnalysis.Symbols.Symbol" : GetBaseName(symbol, baseSymbol);
            #line hidden
            
            __cb.Push("    ");
            #line (44,5)-(44,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (44,11)-(44,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,12)-(44,20) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (44,20)-(44,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,21)-(44,28) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (44,28)-(44,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,29)-(44,34) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (44,34)-(44,35) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,36)-(44,63) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (44,64)-(44,65) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (44,65)-(44,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,67)-(44,75) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (45,5)-(45,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (46,9)-(46,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (46,15)-(46,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,16)-(46,19) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (46,19)-(46,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,20)-(46,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (46,25)-(46,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,26)-(46,41) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts");
            #line hidden
            #line (46,41)-(46,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,42)-(46,43) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (46,43)-(46,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,45)-(46,53) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            #line (46,54)-(46,70) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (47,9)-(47,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first1 = true;
            #line (48,14)-(48,54) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                __cb.Push("            ");
                #line (49,17)-(49,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (49,23)-(49,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (49,24)-(49,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (49,30)-(49,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (49,31)-(49,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (49,39)-(49,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (49,40)-(49,56) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart");
                #line hidden
                #line (49,56)-(49,57) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (49,57)-(49,63) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (49,64)-(49,69) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (49,70)-(49,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (49,71)-(49,72) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (49,72)-(49,73) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (49,73)-(49,76) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (49,76)-(49,77) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (49,77)-(49,107) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart(nameof(Start_");
                #line hidden
                #line (49,108)-(49,113) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (49,114)-(49,117) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
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
                #line (50,57)-(50,64) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (50,65)-(50,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (50,71)-(50,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (50,72)-(50,73) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (50,73)-(50,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (50,74)-(50,77) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (50,77)-(50,78) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (50,78)-(50,109) 29 "SymbolGenerator.mxg"
                __cb.Write("__CompletionPart(nameof(Finish_");
                #line hidden
                #line (50,110)-(50,115) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (50,116)-(50,119) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first1) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (53,13)-(53,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (53,19)-(53,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,20)-(53,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (53,26)-(53,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,27)-(53,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (53,35)-(53,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,36)-(53,53) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (53,53)-(53,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,54)-(53,69) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (53,69)-(53,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,70)-(53,71) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (53,71)-(53,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (54,17)-(54,51) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph.CreateFromParts(");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (55,22)-(55,30) 24 "SymbolGenerator.mxg"
            __cb.Write(baseName);
            #line hidden
            #line (55,31)-(55,63) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts.CompletionGraph");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first2 = true;
            #line (56,22)-(56,62) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first2)
                {
                    __first2 = false;
                }
                __cb.Push("                    ");
                #line (57,25)-(57,26) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (57,26)-(57,27) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (57,27)-(57,33) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (57,34)-(57,39) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (57,40)-(57,41) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (57,41)-(57,42) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (57,42)-(57,49) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (57,50)-(57,55) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            __cb.Push("                ");
            #line (59,17)-(59,19) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (60,9)-(60,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first3 = true;
            #line (62,10)-(62,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                var __first4 = true;
                #line (63,14)-(63,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first4)
                    {
                        __first4 = false;
                    }
                    __cb.Push("        ");
                    #line (64,17)-(64,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (64,24)-(64,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (64,25)-(64,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (64,31)-(64,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (64,33)-(64,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (64,60)-(64,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (64,62)-(64,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (64,81)-(64,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (64,82)-(64,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (64,83)-(64,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (64,84)-(64,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (64,87)-(64,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (64,89)-(64,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (64,116)-(64,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (65,14)-(65,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first4)
                    {
                        __first4 = false;
                    }
                    __cb.Push("        ");
                    #line (66,17)-(66,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (66,24)-(66,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (66,26)-(66,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (66,53)-(66,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (66,55)-(66,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (66,74)-(66,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first4) __cb.AppendLine();
            }
            if (!__first3) __cb.AppendLine();
            var __first5 = true;
            #line (69,10)-(69,70) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations.Where(o => o.IsCached))
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
                __cb.Push("        ");
                #line (70,13)-(70,20) 29 "SymbolGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (70,20)-(70,21) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (70,21)-(70,27) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (70,27)-(70,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (70,29)-(70,53) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (70,54)-(70,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (70,56)-(70,72) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(op));
                #line hidden
                #line (70,73)-(70,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (70,74)-(70,75) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (70,75)-(70,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (70,76)-(70,79) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (70,79)-(70,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (70,81)-(70,105) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (70,106)-(70,109) 29 "SymbolGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (73,9)-(73,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (73,15)-(73,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,17)-(73,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (73,45)-(73,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol?");
            #line hidden
            #line (73,55)-(73,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,56)-(73,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (73,66)-(73,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,67)-(73,81) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation?");
            #line hidden
            #line (73,81)-(73,82) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,82)-(73,93) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation");
            #line hidden
            #line (73,93)-(73,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,94)-(73,95) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,95)-(73,96) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,96)-(73,101) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (73,101)-(73,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,102)-(73,122) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration?");
            #line hidden
            #line (73,122)-(73,123) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,123)-(73,134) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration");
            #line hidden
            #line (73,134)-(73,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,135)-(73,136) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,136)-(73,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,137)-(73,142) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (73,142)-(73,143) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,143)-(73,151) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model?");
            #line hidden
            #line (73,151)-(73,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,152)-(73,157) 25 "SymbolGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (73,157)-(73,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,158)-(73,159) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,159)-(73,160) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,160)-(73,165) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (73,165)-(73,166) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,166)-(73,181) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (73,181)-(73,182) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,182)-(73,193) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (73,193)-(73,194) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,194)-(73,195) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,195)-(73,196) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,196)-(73,201) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (73,201)-(73,202) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,202)-(73,211) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (73,211)-(73,212) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,212)-(73,224) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol");
            #line hidden
            #line (73,224)-(73,225) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,225)-(73,226) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,226)-(73,227) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,227)-(73,232) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (73,232)-(73,233) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,233)-(73,251) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo?");
            #line hidden
            #line (73,251)-(73,252) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,252)-(73,261) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo");
            #line hidden
            #line (73,261)-(73,262) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,262)-(73,263) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,263)-(73,264) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,264)-(73,269) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (73,269)-(73,270) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,270)-(73,274) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (73,274)-(73,275) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,275)-(73,286) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol");
            #line hidden
            #line (73,286)-(73,287) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,287)-(73,288) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,288)-(73,289) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,289)-(73,295) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (73,295)-(73,296) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,296)-(73,303) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (73,303)-(73,304) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,304)-(73,308) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (73,308)-(73,309) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,309)-(73,310) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,310)-(73,311) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,311)-(73,319) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (73,319)-(73,320) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,320)-(73,327) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (73,327)-(73,328) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,328)-(73,340) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (73,340)-(73,341) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,341)-(73,342) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,342)-(73,343) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,343)-(73,351) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (73,351)-(73,352) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,352)-(73,420) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>");
            #line hidden
            #line (73,420)-(73,421) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,421)-(73,431) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (73,431)-(73,432) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,432)-(73,433) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,433)-(73,434) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,434)-(73,441) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first6 = true;
            #line (73,442)-(73,510) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                #line (73,511)-(73,512) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (73,512)-(73,513) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (73,514)-(73,544) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (73,545)-(73,546) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (73,547)-(73,565) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (73,566)-(73,567) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (73,567)-(73,568) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (73,568)-(73,569) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (73,570)-(73,604) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (73,618)-(73,619) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (73,619)-(73,620) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (74,13)-(74,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (74,14)-(74,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,15)-(74,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (74,30)-(74,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,31)-(74,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (74,43)-(74,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,44)-(74,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (74,56)-(74,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,57)-(74,63) 25 "SymbolGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (74,63)-(74,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,64)-(74,76) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (74,76)-(74,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,77)-(74,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (74,90)-(74,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,91)-(74,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (74,101)-(74,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,102)-(74,114) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol,");
            #line hidden
            #line (74,114)-(74,115) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,115)-(74,120) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (74,120)-(74,121) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,121)-(74,134) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (74,134)-(74,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,135)-(74,145) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first7 = true;
            #line (74,146)-(74,218) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (74,219)-(74,220) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (74,220)-(74,221) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (74,222)-(74,240) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (74,241)-(74,242) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (74,242)-(74,243) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (74,244)-(74,262) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (74,276)-(74,277) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (75,9)-(75,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (76,13)-(76,15) 25 "SymbolGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (76,15)-(76,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,16)-(76,29) 25 "SymbolGenerator.mxg"
            __cb.Write("(fixedSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (77,13)-(77,14) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first8 = true;
            #line (78,18)-(78,82) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                __cb.Push("                ");
                #line (79,22)-(79,70) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first8) __cb.AppendLine();
            __cb.Push("            ");
            #line (81,13)-(81,14) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
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
            var __first9 = true;
            #line (84,10)-(84,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                var __first10 = true;
                #line (85,14)-(85,34) 17 "SymbolGenerator.mxg"
                if (!prop.IsDerived)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (86,18)-(86,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (86,22)-(86,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (86,38)-(86,41) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                var __first11 = true;
                #line (88,14)-(88,32) 17 "SymbolGenerator.mxg"
                if (!prop.IsPlain)
                #line hidden
                
                {
                    if (__first11)
                    {
                        __first11 = false;
                    }
                    #line (88,34)-(88,37) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (88,38)-(88,45) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Phase");
                    #line hidden
                    var __first12 = true;
                    #line (88,46)-(88,73) 21 "SymbolGenerator.mxg"
                    if (prop.Phase is not null)
                    #line hidden
                    
                    {
                        if (__first12)
                        {
                            __first12 = false;
                        }
                        #line (88,74)-(88,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("(nameof(");
                        #line hidden
                        #line (88,83)-(88,98) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Phase.Name);
                        #line hidden
                        #line (88,99)-(88,101) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                    }
                    #line (88,110)-(88,113) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                }
                if (!__first11) __cb.AppendLine();
                var __first13 = true;
                #line (89,14)-(89,33) 17 "SymbolGenerator.mxg"
                if (prop.IsDerived)
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    #line (89,35)-(89,38) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (89,39)-(89,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Derived");
                    #line hidden
                    var __first14 = true;
                    #line (89,49)-(89,67) 21 "SymbolGenerator.mxg"
                    if (prop.IsCached)
                    #line hidden
                    
                    {
                        if (__first14)
                        {
                            __first14 = false;
                        }
                        #line (89,68)-(89,81) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true)");
                        #line hidden
                    }
                    #line (89,90)-(89,93) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                }
                if (!__first13) __cb.AppendLine();
                var __first15 = true;
                #line (90,14)-(90,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first15)
                    {
                        __first15 = false;
                    }
                    #line (90,32)-(90,35) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (90,36)-(90,42) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Weak");
                    #line hidden
                    #line (90,43)-(90,46) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                }
                if (!__first15) __cb.AppendLine();
                __cb.Push("        ");
                #line (91,13)-(91,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (91,19)-(91,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (91,21)-(91,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (91,52)-(91,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (91,54)-(91,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (92,13)-(92,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first16 = true;
                #line (93,18)-(93,35) 17 "SymbolGenerator.mxg"
                if (prop.IsPlain)
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    var __first17 = true;
                    #line (94,22)-(94,41) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        var __first18 = true;
                        #line (95,26)-(95,44) 25 "SymbolGenerator.mxg"
                        if (prop.IsCached)
                        #line hidden
                        
                        {
                            if (__first18)
                            {
                                __first18 = false;
                            }
                            __cb.Push("            ");
                            #line (96,29)-(96,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (96,31)-(96,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (96,32)-(96,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("TODO:");
                            #line hidden
                            #line (96,37)-(96,38) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (96,38)-(96,43) 41 "SymbolGenerator.mxg"
                            __cb.Write("cache");
                            #line hidden
                            #line (96,43)-(96,44) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (96,44)-(96,50) 41 "SymbolGenerator.mxg"
                            __cb.Write("result");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (97,29)-(97,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            #line (97,32)-(97,33) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (97,33)-(97,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (97,35)-(97,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (97,36)-(97,44) 41 "SymbolGenerator.mxg"
                            __cb.Write("Compute_");
                            #line hidden
                            #line (97,45)-(97,54) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (97,55)-(97,58) 41 "SymbolGenerator.mxg"
                            __cb.Write("();");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (98,26)-(98,30) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first18)
                            {
                                __first18 = false;
                            }
                            __cb.Push("            ");
                            #line (99,29)-(99,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            #line (99,32)-(99,33) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (99,33)-(99,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (99,35)-(99,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (99,36)-(99,44) 41 "SymbolGenerator.mxg"
                            __cb.Write("Compute_");
                            #line hidden
                            #line (99,45)-(99,54) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (99,55)-(99,58) 41 "SymbolGenerator.mxg"
                            __cb.Write("();");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first18) __cb.AppendLine();
                    }
                    #line (101,22)-(101,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        var __first19 = true;
                        #line (102,26)-(102,42) 25 "SymbolGenerator.mxg"
                        if (prop.IsWeak)
                        #line hidden
                        
                        {
                            if (__first19)
                            {
                                __first19 = false;
                            }
                            __cb.Push("            ");
                            #line (103,29)-(103,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (104,29)-(104,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (105,33)-(105,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (105,35)-(105,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (105,36)-(105,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (105,38)-(105,56) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (105,57)-(105,75) 41 "SymbolGenerator.mxg"
                            __cb.Write(".TryGetValue(this,");
                            #line hidden
                            #line (105,75)-(105,76) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (105,76)-(105,79) 41 "SymbolGenerator.mxg"
                            __cb.Write("out");
                            #line hidden
                            #line (105,79)-(105,80) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (105,80)-(105,83) 41 "SymbolGenerator.mxg"
                            __cb.Write("var");
                            #line hidden
                            #line (105,83)-(105,84) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (105,84)-(105,92) 41 "SymbolGenerator.mxg"
                            __cb.Write("result))");
                            #line hidden
                            #line (105,92)-(105,93) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (105,93)-(105,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (105,99)-(105,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (105,100)-(105,101) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (105,102)-(105,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type));
                            #line hidden
                            #line (105,133)-(105,141) 41 "SymbolGenerator.mxg"
                            __cb.Write(")result;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (106,33)-(106,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("else");
                            #line hidden
                            #line (106,37)-(106,38) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (106,38)-(106,44) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (106,44)-(106,45) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (106,46)-(106,75) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (106,76)-(106,77) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (107,29)-(107,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (108,29)-(108,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (108,38)-(108,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (108,39)-(108,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
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
                            #line (110,34)-(110,71) 40 "SymbolGenerator.mxg"
                            __cb.Write(AssignProperty(symbol, prop, "value"));
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (111,29)-(111,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (112,26)-(112,30) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first19)
                            {
                                __first19 = false;
                            }
                            __cb.Push("            ");
                            #line (113,29)-(113,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            #line (113,32)-(113,33) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (113,33)-(113,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (113,35)-(113,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (113,37)-(113,55) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (113,56)-(113,57) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (114,29)-(114,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (114,38)-(114,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (114,39)-(114,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
                            #line hidden
                            #line (114,42)-(114,43) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (114,43)-(114,45) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (114,45)-(114,46) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (114,47)-(114,65) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (114,66)-(114,67) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (114,67)-(114,68) 41 "SymbolGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (114,68)-(114,69) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (114,69)-(114,75) 41 "SymbolGenerator.mxg"
                            __cb.Write("value;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first19) __cb.AppendLine();
                    }
                    if (!__first17) __cb.AppendLine();
                }
                #line (117,18)-(117,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    __cb.Push("            ");
                    #line (118,21)-(118,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (119,21)-(119,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (120,25)-(120,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("this.ForceComplete(CompletionParts.Finish_");
                    #line hidden
                    #line (120,68)-(120,97) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (120,98)-(120,99) 33 "SymbolGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (120,99)-(120,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,100)-(120,105) 33 "SymbolGenerator.mxg"
                    __cb.Write("null,");
                    #line hidden
                    #line (120,105)-(120,106) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,106)-(120,115) 33 "SymbolGenerator.mxg"
                    __cb.Write("default);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first20 = true;
                    #line (121,26)-(121,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        __cb.Push("                ");
                        #line (122,29)-(122,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (122,31)-(122,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (122,32)-(122,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (122,34)-(122,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (122,53)-(122,71) 37 "SymbolGenerator.mxg"
                        __cb.Write(".TryGetValue(this,");
                        #line hidden
                        #line (122,71)-(122,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (122,72)-(122,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("out");
                        #line hidden
                        #line (122,75)-(122,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (122,76)-(122,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (122,79)-(122,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (122,80)-(122,88) 37 "SymbolGenerator.mxg"
                        __cb.Write("result))");
                        #line hidden
                        #line (122,88)-(122,89) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (122,89)-(122,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (122,95)-(122,96) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (122,96)-(122,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (122,98)-(122,128) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (122,129)-(122,137) 37 "SymbolGenerator.mxg"
                        __cb.Write(")result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (123,29)-(123,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("else");
                        #line hidden
                        #line (123,33)-(123,34) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (123,34)-(123,40) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (123,40)-(123,41) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (123,42)-(123,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (123,72)-(123,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (124,26)-(124,30) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        __cb.Push("                ");
                        #line (125,29)-(125,35) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (125,35)-(125,36) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,37)-(125,55) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (125,56)-(125,57) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first20) __cb.AppendLine();
                    __cb.Push("            ");
                    #line (127,21)-(127,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first16) __cb.AppendLine();
                __cb.Push("        ");
                #line (129,13)-(129,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first21 = true;
            #line (132,10)-(132,47) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations)
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                #line (133,14)-(133,90) 17 "SymbolGenerator.mxg"
                var arguments = "("+string.Join(", ", op.Parameters.Select(p => p.Name))+")";
                #line hidden
                
                #line (134,14)-(134,42) 17 "SymbolGenerator.mxg"
                var call = op.Name+arguments;
                #line hidden
                
                #line (135,14)-(135,65) 17 "SymbolGenerator.mxg"
                var returnType = GetTypeName(symbol, op.ReturnType);
                #line hidden
                
                __cb.WriteLine();
                __cb.Pop();
                var __first22 = true;
                #line (137,14)-(137,29) 17 "SymbolGenerator.mxg"
                if (op.IsPhase)
                #line hidden
                
                {
                    if (__first22)
                    {
                        __first22 = false;
                    }
                    __cb.Push("        ");
                    #line (138,18)-(138,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (138,22)-(138,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Phase");
                    #line hidden
                    #line (138,30)-(138,33) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (139,17)-(139,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (139,26)-(139,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (139,27)-(139,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (139,35)-(139,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (139,36)-(139,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (139,40)-(139,41) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (139,42)-(139,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (139,50)-(139,66) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (139,66)-(139,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (139,67)-(139,79) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (139,79)-(139,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (139,80)-(139,99) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (139,99)-(139,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (139,100)-(139,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (140,14)-(140,35) 17 "SymbolGenerator.mxg"
                else if (op.IsCached)
                #line hidden
                
                {
                    if (__first22)
                    {
                        __first22 = false;
                    }
                    __cb.Push("        ");
                    #line (141,18)-(141,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (141,22)-(141,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Derived");
                    #line hidden
                    var __first23 = true;
                    #line (141,32)-(141,48) 21 "SymbolGenerator.mxg"
                    if (op.IsCached)
                    #line hidden
                    
                    {
                        if (__first23)
                        {
                            __first23 = false;
                        }
                        #line (141,49)-(141,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true");
                        #line hidden
                        var __first24 = true;
                        #line (141,62)-(141,107) 25 "SymbolGenerator.mxg"
                        if (!string.IsNullOrEmpty(op.CacheCondition))
                        #line hidden
                        
                        {
                            if (__first24)
                            {
                                __first24 = false;
                            }
                            #line (141,108)-(141,109) 41 "SymbolGenerator.mxg"
                            __cb.Write(",");
                            #line hidden
                            #line (141,109)-(141,110) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (141,110)-(141,120) 41 "SymbolGenerator.mxg"
                            __cb.Write("Condition=");
                            #line hidden
                            #line (141,121)-(141,153) 40 "SymbolGenerator.mxg"
                            __cb.Write(op.CacheCondition.EncodeString());
                            #line hidden
                        }
                        #line (141,162)-(141,163) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                    }
                    #line (141,172)-(141,175) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (142,17)-(142,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (142,23)-(142,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,25)-(142,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (142,36)-(142,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,38)-(142,45) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (142,46)-(142,47) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first25 = true;
                    foreach (var __item26 in 
                    #line (142,48)-(142,118) 21 "SymbolGenerator.mxg"
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
                            #line (142,128)-(142,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item26);
                    }
                    #line (142,133)-(142,134) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (143,17)-(143,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first27 = true;
                    #line (144,22)-(144,67) 21 "SymbolGenerator.mxg"
                    if (!string.IsNullOrEmpty(op.CacheCondition))
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
                        }
                        __cb.Push("            ");
                        #line (145,25)-(145,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (145,27)-(145,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (145,28)-(145,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!(");
                        #line hidden
                        #line (145,32)-(145,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.CacheCondition);
                        #line hidden
                        #line (145,50)-(145,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                        #line (145,52)-(145,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (145,53)-(145,59) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (145,59)-(145,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (145,61)-(145,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, op.ReturnType));
                        #line hidden
                        #line (145,100)-(145,101) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first27) __cb.AppendLine();
                    #line (147,22)-(147,54) 21 "SymbolGenerator.mxg"
                    var fieldName = GetFieldName(op);
                    #line hidden
                    
                    var __first28 = true;
                    #line (148,22)-(148,51) 21 "SymbolGenerator.mxg"
                    if (op.Parameters.Count == 0)
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        __cb.Push("            ");
                        #line (149,25)-(149,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (149,31)-(149,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (149,32)-(149,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (149,34)-(149,44) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (149,45)-(149,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (149,47)-(149,56) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (149,57)-(149,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (149,72)-(149,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (149,73)-(149,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (149,79)-(149,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (149,80)-(149,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (149,82)-(149,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (149,83)-(149,91) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (149,92)-(149,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.Name);
                        #line hidden
                        #line (149,101)-(149,110) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (149,111)-(149,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (150,22)-(150,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        __cb.Push("            ");
                        #line (151,25)-(151,28) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (151,28)-(151,29) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (151,29)-(151,47) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary");
                        #line hidden
                        #line (151,47)-(151,48) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (151,48)-(151,49) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (151,49)-(151,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (151,51)-(151,60) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (151,61)-(151,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (151,76)-(151,77) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (151,77)-(151,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (151,83)-(151,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (151,84)-(151,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (151,86)-(151,87) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (151,87)-(151,90) 37 "SymbolGenerator.mxg"
                        __cb.Write("new");
                        #line hidden
                        #line (151,90)-(151,91) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (151,91)-(151,150) 37 "SymbolGenerator.mxg"
                        __cb.Write("global::System.Collections.Concurrent.ConcurrentDictionary<");
                        #line hidden
                        #line (151,151)-(151,178) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetCacheKeyType(symbol, op));
                        #line hidden
                        #line (151,179)-(151,180) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (151,180)-(151,181) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (151,182)-(151,192) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (151,193)-(151,198) 37 "SymbolGenerator.mxg"
                        __cb.Write(">());");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (152,25)-(152,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (152,31)-(152,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,32)-(152,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary.GetOrAdd(");
                        #line hidden
                        #line (152,61)-(152,70) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (152,71)-(152,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (152,72)-(152,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,73)-(152,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__args");
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
                    if (!__first28) __cb.AppendLine();
                    __cb.Push("        ");
                    #line (154,17)-(154,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (156,17)-(156,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (156,26)-(156,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (156,27)-(156,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (156,35)-(156,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (156,37)-(156,47) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (156,48)-(156,49) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (156,49)-(156,57) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (156,58)-(156,65) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (156,66)-(156,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first29 = true;
                    foreach (var __item30 in 
                    #line (156,68)-(156,138) 21 "SymbolGenerator.mxg"
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
                            #line (156,148)-(156,152) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item30);
                    }
                    #line (156,153)-(156,155) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (157,14)-(157,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first22)
                    {
                        __first22 = false;
                    }
                    __cb.Push("        ");
                    #line (158,17)-(158,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (158,23)-(158,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (158,24)-(158,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (158,32)-(158,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (158,34)-(158,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (158,45)-(158,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (158,47)-(158,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (158,55)-(158,56) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first31 = true;
                    foreach (var __item32 in 
                    #line (158,57)-(158,127) 21 "SymbolGenerator.mxg"
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
                            #line (158,137)-(158,141) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item32);
                    }
                    #line (158,142)-(158,144) 33 "SymbolGenerator.mxg"
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
            #line (162,10)-(162,40) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            __cb.Push("        ");
            #line (163,9)-(163,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (163,18)-(163,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,19)-(163,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (163,27)-(163,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,28)-(163,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (163,32)-(163,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,33)-(163,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (163,54)-(163,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,55)-(163,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (163,71)-(163,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,72)-(163,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (163,87)-(163,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,88)-(163,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (163,105)-(163,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,106)-(163,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (163,118)-(163,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,119)-(163,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (163,138)-(163,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,139)-(163,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (164,9)-(164,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (165,14)-(165,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            var __first33 = true;
            #line (166,14)-(166,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                #line (167,18)-(167,36) 17 "SymbolGenerator.mxg"
                hasNewPhase = true;
                #line hidden
                
                #line (168,18)-(168,63) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                __cb.Push("            ");
                #line (169,17)-(169,19) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (169,19)-(169,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (169,20)-(169,35) 29 "SymbolGenerator.mxg"
                __cb.Write("(incompletePart");
                #line hidden
                #line (169,35)-(169,36) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (169,36)-(169,38) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (169,38)-(169,39) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (169,39)-(169,61) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Start_");
                #line hidden
                #line (169,62)-(169,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (169,68)-(169,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (169,69)-(169,71) 29 "SymbolGenerator.mxg"
                __cb.Write("||");
                #line hidden
                #line (169,71)-(169,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (169,72)-(169,86) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart");
                #line hidden
                #line (169,86)-(169,87) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (169,87)-(169,89) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (169,89)-(169,90) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (169,90)-(169,113) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Finish_");
                #line hidden
                #line (169,114)-(169,119) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (169,120)-(169,121) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (170,17)-(170,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (171,21)-(171,23) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (171,23)-(171,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (171,24)-(171,64) 29 "SymbolGenerator.mxg"
                __cb.Write("(NotePartComplete(CompletionParts.Start_");
                #line hidden
                #line (171,65)-(171,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (171,71)-(171,73) 29 "SymbolGenerator.mxg"
                __cb.Write("))");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (172,21)-(172,22) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (173,25)-(173,28) 29 "SymbolGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (173,28)-(173,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (173,29)-(173,40) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics");
                #line hidden
                #line (173,40)-(173,41) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (173,41)-(173,42) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (173,42)-(173,43) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (173,43)-(173,73) 29 "SymbolGenerator.mxg"
                __cb.Write("__DiagnosticBag.GetInstance();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first34 = true;
                #line (174,26)-(174,48) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
                    }
                    __cb.Push("                    ");
                    #line (175,29)-(175,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (175,32)-(175,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,33)-(175,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (175,39)-(175,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,40)-(175,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (175,41)-(175,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,42)-(175,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (175,51)-(175,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (175,57)-(175,70) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (175,70)-(175,71) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,71)-(175,90) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first35 = true;
                    #line (176,30)-(176,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first35)
                        {
                            __first35 = false;
                        }
                        __cb.Push("                    ");
                        #line (177,34)-(177,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first35) __cb.AppendLine();
                }
                #line (179,26)-(179,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
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
                    __cb.Push("                    ");
                    #line (181,30)-(181,72) 32 "SymbolGenerator.mxg"
                    __cb.Write(AssignProperty(symbol, props[0], "result"));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (182,26)-(182,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
                    }
                    __cb.Push("                    ");
                    #line (183,30)-(183,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (183,36)-(183,49) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (183,49)-(183,50) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (183,50)-(183,69) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first34) __cb.AppendLine();
                __cb.Push("                    ");
                #line (185,25)-(185,59) 29 "SymbolGenerator.mxg"
                __cb.Write("AddSymbolDiagnostics(diagnostics);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (186,25)-(186,44) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics.Free();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (187,25)-(187,65) 29 "SymbolGenerator.mxg"
                __cb.Write("NotePartComplete(CompletionParts.Finish_");
                #line hidden
                #line (187,66)-(187,71) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (187,72)-(187,74) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (188,21)-(188,22) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (189,21)-(189,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (189,27)-(189,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (189,28)-(189,33) 29 "SymbolGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (190,17)-(190,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (191,17)-(191,21) 29 "SymbolGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (191,21)-(191,22) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first33) __cb.AppendLine();
            var __first36 = true;
            #line (193,14)-(193,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("            ");
                #line (194,17)-(194,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (195,21)-(195,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (195,27)-(195,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (195,28)-(195,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (195,54)-(195,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (195,55)-(195,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (195,70)-(195,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (195,71)-(195,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (195,83)-(195,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (195,84)-(195,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (196,17)-(196,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (197,14)-(197,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("            ");
                #line (198,17)-(198,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (198,23)-(198,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (198,24)-(198,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (198,50)-(198,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (198,51)-(198,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (198,66)-(198,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (198,67)-(198,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (198,79)-(198,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (198,80)-(198,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first36) __cb.AppendLine();
            __cb.Push("        ");
            #line (200,9)-(200,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first37 = true;
            #line (202,10)-(202,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (204,14)-(204,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first38 = true;
                #line (205,14)-(205,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first38)
                    {
                        __first38 = false;
                    }
                    #line (206,18)-(206,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    var __first39 = true;
                    #line (207,18)-(207,58) 21 "SymbolGenerator.mxg"
                    if (props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first39)
                        {
                            __first39 = false;
                        }
                        __cb.Push("        ");
                        #line (208,21)-(208,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (208,30)-(208,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (208,31)-(208,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (208,39)-(208,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (208,41)-(208,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (208,52)-(208,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (208,53)-(208,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (208,62)-(208,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (208,68)-(208,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (208,84)-(208,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (208,85)-(208,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (208,97)-(208,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (208,98)-(208,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (208,117)-(208,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (208,118)-(208,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (209,18)-(209,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first39)
                        {
                            __first39 = false;
                        }
                        __cb.Push("        ");
                        #line (210,21)-(210,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (210,30)-(210,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (210,31)-(210,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (210,38)-(210,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (210,40)-(210,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (210,51)-(210,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (210,52)-(210,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (210,61)-(210,66) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (210,67)-(210,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (210,83)-(210,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (210,84)-(210,96) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (210,96)-(210,97) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (210,97)-(210,116) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (210,116)-(210,117) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (210,117)-(210,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (211,21)-(211,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = true;
                        __cb.Push("            ");
                        #line (213,25)-(213,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (213,31)-(213,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (213,32)-(213,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first40 = true;
                        #line (214,30)-(214,58) 25 "SymbolGenerator.mxg"
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
                                #line (214,68)-(214,72) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Push("                ");
                            #line (215,33)-(215,87) 41 "SymbolGenerator.mxg"
                            __cb.Write("ContainingModule!.SymbolFactory.GetSymbolPropertyValue");
                            #line hidden
                            var __first41 = true;
                            #line (215,88)-(215,117) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first41)
                                {
                                    __first41 = false;
                                }
                                #line (215,118)-(215,119) 45 "SymbolGenerator.mxg"
                                __cb.Write("s");
                                #line hidden
                            }
                            #line (215,127)-(215,128) 41 "SymbolGenerator.mxg"
                            __cb.Write("<");
                            #line hidden
                            #line (215,129)-(215,164) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type.Type));
                            #line hidden
                            #line (215,165)-(215,172) 41 "SymbolGenerator.mxg"
                            __cb.Write(">(this,");
                            #line hidden
                            #line (215,172)-(215,173) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (215,173)-(215,180) 41 "SymbolGenerator.mxg"
                            __cb.Write("nameof(");
                            #line hidden
                            #line (215,181)-(215,190) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (215,191)-(215,193) 41 "SymbolGenerator.mxg"
                            __cb.Write("),");
                            #line hidden
                            #line (215,193)-(215,194) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (215,194)-(215,206) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (215,206)-(215,207) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (215,207)-(215,226) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first40) __cb.AppendLine();
                        __cb.Push("            ");
                        #line (217,25)-(217,27) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = false;
                        __cb.AppendLine();
                        __cb.Push("        ");
                        #line (219,21)-(219,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first39) __cb.AppendLine();
                }
                #line (221,14)-(221,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first38)
                    {
                        __first38 = false;
                    }
                    #line (222,18)-(222,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (223,18)-(223,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    var __first42 = true;
                    #line (224,18)-(224,37) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first42)
                        {
                            __first42 = false;
                        }
                        __cb.Push("        ");
                        #line (225,21)-(225,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (225,30)-(225,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (225,31)-(225,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (225,39)-(225,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (225,41)-(225,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (225,52)-(225,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (225,53)-(225,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (225,62)-(225,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (225,68)-(225,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (225,84)-(225,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (225,85)-(225,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (225,97)-(225,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (225,98)-(225,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (225,117)-(225,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (225,118)-(225,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (226,18)-(226,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first42)
                        {
                            __first42 = false;
                        }
                        __cb.Push("        ");
                        #line (227,21)-(227,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (227,30)-(227,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,31)-(227,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (227,38)-(227,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,40)-(227,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (227,51)-(227,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,52)-(227,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (227,61)-(227,66) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (227,67)-(227,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (227,83)-(227,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,84)-(227,96) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (227,96)-(227,97) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,97)-(227,116) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (227,116)-(227,117) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,117)-(227,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (228,21)-(228,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (229,25)-(229,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (229,31)-(229,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,32)-(229,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("ContainingModule!.SymbolFactory.GetSymbolPropertyValue");
                        #line hidden
                        var __first43 = true;
                        #line (229,87)-(229,116) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first43)
                            {
                                __first43 = false;
                            }
                            #line (229,117)-(229,118) 41 "SymbolGenerator.mxg"
                            __cb.Write("s");
                            #line hidden
                        }
                        #line (229,126)-(229,127) 37 "SymbolGenerator.mxg"
                        __cb.Write("<");
                        #line hidden
                        #line (229,128)-(229,163) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type.Type));
                        #line hidden
                        #line (229,164)-(229,171) 37 "SymbolGenerator.mxg"
                        __cb.Write(">(this,");
                        #line hidden
                        #line (229,171)-(229,172) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,172)-(229,179) 37 "SymbolGenerator.mxg"
                        __cb.Write("nameof(");
                        #line hidden
                        #line (229,180)-(229,189) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Name);
                        #line hidden
                        #line (229,190)-(229,192) 37 "SymbolGenerator.mxg"
                        __cb.Write("),");
                        #line hidden
                        #line (229,192)-(229,193) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,193)-(229,205) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (229,205)-(229,206) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,206)-(229,225) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (230,21)-(230,22) 37 "SymbolGenerator.mxg"
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
            #line (234,5)-(234,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (235,1)-(235,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (238,9)-(238,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (239,2)-(239,34) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (240,2)-(240,61) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            __cb.Push("");
            #line (241,1)-(241,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (241,6)-(241,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (241,7)-(241,14) 25 "SymbolGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (242,1)-(242,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (242,6)-(242,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (242,7)-(242,34) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Generic;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (243,1)-(243,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (243,6)-(243,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (243,7)-(243,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
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
            #line (244,7)-(244,19) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Linq;");
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
            #line (245,7)-(245,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
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
            #line (246,7)-(246,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
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
            #line (247,7)-(247,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
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
            #line (248,7)-(248,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (250,1)-(250,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (250,10)-(250,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (250,12)-(250,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (250,33)-(250,38) 25 "SymbolGenerator.mxg"
            __cb.Write(".Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (251,1)-(251,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (252,5)-(252,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (252,10)-(252,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (252,11)-(252,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (252,18)-(252,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (252,19)-(252,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (252,20)-(252,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (252,21)-(252,45) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.Model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (253,5)-(253,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (253,10)-(253,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,11)-(253,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (253,25)-(253,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,26)-(253,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (253,27)-(253,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,28)-(253,59) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.IModelObject;");
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
            #line (254,11)-(254,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (254,20)-(254,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (254,21)-(254,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (254,22)-(254,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (254,23)-(254,54) 25 "SymbolGenerator.mxg"
            __cb.Write("Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (256,5)-(256,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (256,11)-(256,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,12)-(256,17) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (256,17)-(256,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,19)-(256,46) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (256,47)-(256,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,48)-(256,49) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (256,49)-(256,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,51)-(256,78) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (257,5)-(257,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (258,9)-(258,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (258,15)-(258,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,17)-(258,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (258,45)-(258,53) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol?");
            #line hidden
            #line (258,53)-(258,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,54)-(258,64) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (258,64)-(258,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,65)-(258,77) 25 "SymbolGenerator.mxg"
            __cb.Write("Compilation?");
            #line hidden
            #line (258,77)-(258,78) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,78)-(258,89) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation");
            #line hidden
            #line (258,89)-(258,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,90)-(258,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,91)-(258,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,92)-(258,97) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (258,97)-(258,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,98)-(258,116) 25 "SymbolGenerator.mxg"
            __cb.Write("MergedDeclaration?");
            #line hidden
            #line (258,116)-(258,117) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,117)-(258,128) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration");
            #line hidden
            #line (258,128)-(258,129) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,129)-(258,130) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,130)-(258,131) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,131)-(258,136) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (258,136)-(258,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,137)-(258,145) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model?");
            #line hidden
            #line (258,145)-(258,146) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,146)-(258,151) 25 "SymbolGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (258,151)-(258,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,152)-(258,153) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,153)-(258,154) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,154)-(258,159) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (258,159)-(258,160) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,160)-(258,175) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (258,175)-(258,176) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,176)-(258,187) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (258,187)-(258,188) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,188)-(258,189) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,189)-(258,190) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,190)-(258,195) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (258,195)-(258,196) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,196)-(258,205) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (258,205)-(258,206) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,206)-(258,218) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol");
            #line hidden
            #line (258,218)-(258,219) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,219)-(258,220) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,220)-(258,221) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,221)-(258,226) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (258,226)-(258,227) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,227)-(258,243) 25 "SymbolGenerator.mxg"
            __cb.Write("ErrorSymbolInfo?");
            #line hidden
            #line (258,243)-(258,244) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,244)-(258,253) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo");
            #line hidden
            #line (258,253)-(258,254) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,254)-(258,255) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,255)-(258,256) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,256)-(258,261) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (258,261)-(258,262) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,262)-(258,266) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (258,266)-(258,267) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,267)-(258,278) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol");
            #line hidden
            #line (258,278)-(258,279) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,279)-(258,280) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,280)-(258,281) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,281)-(258,287) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (258,287)-(258,288) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,288)-(258,295) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (258,295)-(258,296) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,296)-(258,300) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (258,300)-(258,301) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,301)-(258,302) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,302)-(258,303) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,303)-(258,311) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (258,311)-(258,312) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,312)-(258,319) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (258,319)-(258,320) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,320)-(258,332) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (258,332)-(258,333) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,333)-(258,334) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,334)-(258,335) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,335)-(258,343) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (258,343)-(258,344) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,344)-(258,412) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>");
            #line hidden
            #line (258,412)-(258,413) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,413)-(258,423) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (258,423)-(258,424) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,424)-(258,425) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,425)-(258,426) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,426)-(258,433) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first44 = true;
            #line (258,434)-(258,502) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                #line (258,503)-(258,504) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (258,504)-(258,505) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (258,506)-(258,536) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (258,537)-(258,538) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (258,539)-(258,557) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (258,558)-(258,559) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (258,559)-(258,560) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (258,560)-(258,561) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (258,562)-(258,596) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (258,610)-(258,611) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (258,611)-(258,612) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (259,13)-(259,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (259,14)-(259,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,15)-(259,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (259,30)-(259,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,31)-(259,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (259,43)-(259,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,44)-(259,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (259,56)-(259,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,57)-(259,63) 25 "SymbolGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (259,63)-(259,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,64)-(259,76) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (259,76)-(259,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,77)-(259,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (259,90)-(259,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,91)-(259,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (259,101)-(259,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,102)-(259,114) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol,");
            #line hidden
            #line (259,114)-(259,115) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,115)-(259,120) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (259,120)-(259,121) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,121)-(259,134) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (259,134)-(259,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,135)-(259,145) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first45 = true;
            #line (259,146)-(259,218) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                #line (259,219)-(259,220) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (259,220)-(259,221) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (259,222)-(259,240) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (259,241)-(259,242) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (259,242)-(259,243) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (259,244)-(259,262) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (259,276)-(259,277) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (260,9)-(260,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (261,9)-(261,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (263,5)-(263,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (264,1)-(264,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (267,9)-(267,71) 22 "SymbolGenerator.mxg"
        public string AssignProperty(Symbol symbol, Property prop, string variable)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first46 = true;
            #line (268,6)-(268,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                var __first47 = true;
                #line (269,10)-(269,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first47)
                    {
                        __first47 = false;
                    }
                    __cb.Push("");
                    #line (270,13)-(270,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (270,15)-(270,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (270,16)-(270,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("(!");
                    #line hidden
                    #line (270,19)-(270,27) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (270,28)-(270,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(".IsDefaultOrEmpty)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (271,13)-(271,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (272,18)-(272,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (272,37)-(272,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (272,47)-(272,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (272,49)-(272,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (272,58)-(272,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (273,13)-(273,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (274,10)-(274,14) 17 "SymbolGenerator.mxg"
                else
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
                    #line (275,16)-(275,17) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (275,18)-(275,26) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (275,27)-(275,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (275,28)-(275,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (275,30)-(275,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (275,32)-(275,61) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (275,62)-(275,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
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
                if (!__first47) __cb.AppendLine();
            }
            #line (280,6)-(280,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                __cb.Push("");
                #line (281,10)-(281,28) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (281,29)-(281,30) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (281,30)-(281,31) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (281,31)-(281,32) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (281,33)-(281,41) 28 "SymbolGenerator.mxg"
                __cb.Write(variable);
                #line hidden
                #line (281,42)-(281,43) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first46) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}