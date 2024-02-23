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
            #line (84,28)-(84,43) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (84,43)-(84,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,44)-(84,59) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (84,59)-(84,60) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,60)-(84,62) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (84,62)-(84,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,63)-(84,95) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first9 = true;
            #line (86,10)-(86,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                var __first10 = true;
                #line (87,14)-(87,34) 17 "SymbolGenerator.mxg"
                if (!prop.IsDerived)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (88,18)-(88,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (88,22)-(88,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (88,38)-(88,41) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                var __first11 = true;
                #line (90,14)-(90,32) 17 "SymbolGenerator.mxg"
                if (!prop.IsPlain)
                #line hidden
                
                {
                    if (__first11)
                    {
                        __first11 = false;
                    }
                    #line (90,34)-(90,37) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (90,38)-(90,45) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Phase");
                    #line hidden
                    var __first12 = true;
                    #line (90,46)-(90,73) 21 "SymbolGenerator.mxg"
                    if (prop.Phase is not null)
                    #line hidden
                    
                    {
                        if (__first12)
                        {
                            __first12 = false;
                        }
                        #line (90,74)-(90,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("(nameof(");
                        #line hidden
                        #line (90,83)-(90,98) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Phase.Name);
                        #line hidden
                        #line (90,99)-(90,101) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                    }
                    #line (90,110)-(90,113) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                }
                if (!__first11) __cb.AppendLine();
                var __first13 = true;
                #line (91,14)-(91,33) 17 "SymbolGenerator.mxg"
                if (prop.IsDerived)
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    #line (91,35)-(91,38) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (91,39)-(91,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Derived");
                    #line hidden
                    var __first14 = true;
                    #line (91,49)-(91,67) 21 "SymbolGenerator.mxg"
                    if (prop.IsCached)
                    #line hidden
                    
                    {
                        if (__first14)
                        {
                            __first14 = false;
                        }
                        #line (91,68)-(91,81) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true)");
                        #line hidden
                    }
                    #line (91,90)-(91,93) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                }
                if (!__first13) __cb.AppendLine();
                var __first15 = true;
                #line (92,14)-(92,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first15)
                    {
                        __first15 = false;
                    }
                    #line (92,32)-(92,35) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (92,36)-(92,42) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Weak");
                    #line hidden
                    #line (92,43)-(92,46) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                }
                if (!__first15) __cb.AppendLine();
                __cb.Push("        ");
                #line (93,13)-(93,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (93,19)-(93,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (93,21)-(93,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (93,52)-(93,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (93,54)-(93,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (94,13)-(94,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first16 = true;
                #line (95,18)-(95,35) 17 "SymbolGenerator.mxg"
                if (prop.IsPlain)
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    var __first17 = true;
                    #line (96,22)-(96,41) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        var __first18 = true;
                        #line (97,26)-(97,44) 25 "SymbolGenerator.mxg"
                        if (prop.IsCached)
                        #line hidden
                        
                        {
                            if (__first18)
                            {
                                __first18 = false;
                            }
                            __cb.Push("            ");
                            #line (98,29)-(98,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (98,31)-(98,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (98,32)-(98,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("TODO:");
                            #line hidden
                            #line (98,37)-(98,38) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (98,38)-(98,43) 41 "SymbolGenerator.mxg"
                            __cb.Write("cache");
                            #line hidden
                            #line (98,43)-(98,44) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (98,44)-(98,50) 41 "SymbolGenerator.mxg"
                            __cb.Write("result");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
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
                        #line (100,26)-(100,30) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first18)
                            {
                                __first18 = false;
                            }
                            __cb.Push("            ");
                            #line (101,29)-(101,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            #line (101,32)-(101,33) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (101,33)-(101,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (101,35)-(101,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (101,36)-(101,44) 41 "SymbolGenerator.mxg"
                            __cb.Write("Compute_");
                            #line hidden
                            #line (101,45)-(101,54) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (101,55)-(101,58) 41 "SymbolGenerator.mxg"
                            __cb.Write("();");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first18) __cb.AppendLine();
                    }
                    #line (103,22)-(103,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        var __first19 = true;
                        #line (104,26)-(104,42) 25 "SymbolGenerator.mxg"
                        if (prop.IsWeak)
                        #line hidden
                        
                        {
                            if (__first19)
                            {
                                __first19 = false;
                            }
                            __cb.Push("            ");
                            #line (105,29)-(105,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (106,29)-(106,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (107,33)-(107,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (107,35)-(107,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (107,36)-(107,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (107,38)-(107,56) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (107,57)-(107,75) 41 "SymbolGenerator.mxg"
                            __cb.Write(".TryGetValue(this,");
                            #line hidden
                            #line (107,75)-(107,76) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (107,76)-(107,79) 41 "SymbolGenerator.mxg"
                            __cb.Write("out");
                            #line hidden
                            #line (107,79)-(107,80) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (107,80)-(107,83) 41 "SymbolGenerator.mxg"
                            __cb.Write("var");
                            #line hidden
                            #line (107,83)-(107,84) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (107,84)-(107,92) 41 "SymbolGenerator.mxg"
                            __cb.Write("result))");
                            #line hidden
                            #line (107,92)-(107,93) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (107,93)-(107,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (107,99)-(107,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (107,100)-(107,101) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            #line (107,102)-(107,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type));
                            #line hidden
                            #line (107,133)-(107,141) 41 "SymbolGenerator.mxg"
                            __cb.Write(")result;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                ");
                            #line (108,33)-(108,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("else");
                            #line hidden
                            #line (108,37)-(108,38) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (108,38)-(108,44) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (108,44)-(108,45) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (108,46)-(108,75) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (108,76)-(108,77) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (109,29)-(109,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (110,29)-(110,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (110,38)-(110,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (110,39)-(110,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
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
                            #line (112,34)-(112,71) 40 "SymbolGenerator.mxg"
                            __cb.Write(AssignProperty(symbol, prop, "value"));
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (113,29)-(113,30) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (114,26)-(114,30) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first19)
                            {
                                __first19 = false;
                            }
                            __cb.Push("            ");
                            #line (115,29)-(115,32) 41 "SymbolGenerator.mxg"
                            __cb.Write("get");
                            #line hidden
                            #line (115,32)-(115,33) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (115,33)-(115,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (115,35)-(115,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (115,37)-(115,55) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (115,56)-(115,57) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (116,29)-(116,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("protected");
                            #line hidden
                            #line (116,38)-(116,39) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (116,39)-(116,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("set");
                            #line hidden
                            #line (116,42)-(116,43) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (116,43)-(116,45) 41 "SymbolGenerator.mxg"
                            __cb.Write("=>");
                            #line hidden
                            #line (116,45)-(116,46) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (116,47)-(116,65) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (116,66)-(116,67) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (116,67)-(116,68) 41 "SymbolGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (116,68)-(116,69) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (116,69)-(116,75) 41 "SymbolGenerator.mxg"
                            __cb.Write("value;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first19) __cb.AppendLine();
                    }
                    if (!__first17) __cb.AppendLine();
                }
                #line (119,18)-(119,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    __cb.Push("            ");
                    #line (120,21)-(120,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (121,21)-(121,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (122,25)-(122,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("this.ForceComplete(CompletionParts.Finish_");
                    #line hidden
                    #line (122,68)-(122,97) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (122,98)-(122,99) 33 "SymbolGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (122,99)-(122,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (122,100)-(122,105) 33 "SymbolGenerator.mxg"
                    __cb.Write("null,");
                    #line hidden
                    #line (122,105)-(122,106) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (122,106)-(122,115) 33 "SymbolGenerator.mxg"
                    __cb.Write("default);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first20 = true;
                    #line (123,26)-(123,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        __cb.Push("                ");
                        #line (124,29)-(124,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (124,31)-(124,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (124,32)-(124,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (124,34)-(124,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (124,53)-(124,71) 37 "SymbolGenerator.mxg"
                        __cb.Write(".TryGetValue(this,");
                        #line hidden
                        #line (124,71)-(124,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (124,72)-(124,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("out");
                        #line hidden
                        #line (124,75)-(124,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (124,76)-(124,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (124,79)-(124,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (124,80)-(124,88) 37 "SymbolGenerator.mxg"
                        __cb.Write("result))");
                        #line hidden
                        #line (124,88)-(124,89) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (124,89)-(124,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (124,95)-(124,96) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (124,96)-(124,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (124,98)-(124,128) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (124,129)-(124,137) 37 "SymbolGenerator.mxg"
                        __cb.Write(")result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (125,29)-(125,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("else");
                        #line hidden
                        #line (125,33)-(125,34) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,34)-(125,40) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (125,40)-(125,41) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,42)-(125,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (125,72)-(125,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (126,26)-(126,30) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        __cb.Push("                ");
                        #line (127,29)-(127,35) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (127,35)-(127,36) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (127,37)-(127,55) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (127,56)-(127,57) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first20) __cb.AppendLine();
                    __cb.Push("            ");
                    #line (129,21)-(129,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first16) __cb.AppendLine();
                __cb.Push("        ");
                #line (131,13)-(131,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first21 = true;
            #line (134,10)-(134,47) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations)
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                #line (135,14)-(135,90) 17 "SymbolGenerator.mxg"
                var arguments = "("+string.Join(", ", op.Parameters.Select(p => p.Name))+")";
                #line hidden
                
                #line (136,14)-(136,42) 17 "SymbolGenerator.mxg"
                var call = op.Name+arguments;
                #line hidden
                
                #line (137,14)-(137,65) 17 "SymbolGenerator.mxg"
                var returnType = GetTypeName(symbol, op.ReturnType);
                #line hidden
                
                __cb.WriteLine();
                __cb.Pop();
                var __first22 = true;
                #line (139,14)-(139,29) 17 "SymbolGenerator.mxg"
                if (op.IsPhase)
                #line hidden
                
                {
                    if (__first22)
                    {
                        __first22 = false;
                    }
                    __cb.Push("        ");
                    #line (140,18)-(140,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (140,22)-(140,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Phase");
                    #line hidden
                    #line (140,30)-(140,33) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (141,17)-(141,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (141,26)-(141,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (141,27)-(141,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (141,35)-(141,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (141,36)-(141,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (141,40)-(141,41) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (141,42)-(141,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (141,50)-(141,66) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (141,66)-(141,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (141,67)-(141,79) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (141,79)-(141,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (141,80)-(141,99) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (141,99)-(141,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (141,100)-(141,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (142,14)-(142,35) 17 "SymbolGenerator.mxg"
                else if (op.IsCached)
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
                    #line (143,22)-(143,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("__Derived");
                    #line hidden
                    var __first23 = true;
                    #line (143,32)-(143,48) 21 "SymbolGenerator.mxg"
                    if (op.IsCached)
                    #line hidden
                    
                    {
                        if (__first23)
                        {
                            __first23 = false;
                        }
                        #line (143,49)-(143,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("(Cached=true");
                        #line hidden
                        var __first24 = true;
                        #line (143,62)-(143,107) 25 "SymbolGenerator.mxg"
                        if (!string.IsNullOrEmpty(op.CacheCondition))
                        #line hidden
                        
                        {
                            if (__first24)
                            {
                                __first24 = false;
                            }
                            #line (143,108)-(143,109) 41 "SymbolGenerator.mxg"
                            __cb.Write(",");
                            #line hidden
                            #line (143,109)-(143,110) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (143,110)-(143,120) 41 "SymbolGenerator.mxg"
                            __cb.Write("Condition=");
                            #line hidden
                            #line (143,121)-(143,153) 40 "SymbolGenerator.mxg"
                            __cb.Write(op.CacheCondition.EncodeString());
                            #line hidden
                        }
                        #line (143,162)-(143,163) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                    }
                    #line (143,172)-(143,175) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (144,17)-(144,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (144,23)-(144,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (144,25)-(144,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (144,36)-(144,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (144,38)-(144,45) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (144,46)-(144,47) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first25 = true;
                    foreach (var __item26 in 
                    #line (144,48)-(144,118) 21 "SymbolGenerator.mxg"
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
                            #line (144,128)-(144,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item26);
                    }
                    #line (144,133)-(144,134) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (145,17)-(145,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first27 = true;
                    #line (146,22)-(146,67) 21 "SymbolGenerator.mxg"
                    if (!string.IsNullOrEmpty(op.CacheCondition))
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
                        }
                        __cb.Push("            ");
                        #line (147,25)-(147,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (147,27)-(147,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (147,28)-(147,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!(");
                        #line hidden
                        #line (147,32)-(147,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.CacheCondition);
                        #line hidden
                        #line (147,50)-(147,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                        #line (147,52)-(147,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (147,53)-(147,59) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (147,59)-(147,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (147,61)-(147,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, op.ReturnType));
                        #line hidden
                        #line (147,100)-(147,101) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first27) __cb.AppendLine();
                    #line (149,22)-(149,54) 21 "SymbolGenerator.mxg"
                    var fieldName = GetFieldName(op);
                    #line hidden
                    
                    var __first28 = true;
                    #line (150,22)-(150,51) 21 "SymbolGenerator.mxg"
                    if (op.Parameters.Count == 0)
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        __cb.Push("            ");
                        #line (151,25)-(151,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (151,31)-(151,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (151,32)-(151,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (151,34)-(151,44) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (151,45)-(151,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (151,47)-(151,56) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (151,57)-(151,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (151,72)-(151,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (151,73)-(151,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (151,79)-(151,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (151,80)-(151,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (151,82)-(151,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (151,83)-(151,91) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (151,92)-(151,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.Name);
                        #line hidden
                        #line (151,101)-(151,110) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (151,111)-(151,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (152,22)-(152,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        __cb.Push("            ");
                        #line (153,25)-(153,28) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (153,28)-(153,29) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,29)-(153,47) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary");
                        #line hidden
                        #line (153,47)-(153,48) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,48)-(153,49) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (153,49)-(153,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,51)-(153,60) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (153,61)-(153,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (153,76)-(153,77) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,77)-(153,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (153,83)-(153,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,84)-(153,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (153,86)-(153,87) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,87)-(153,90) 37 "SymbolGenerator.mxg"
                        __cb.Write("new");
                        #line hidden
                        #line (153,90)-(153,91) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,91)-(153,150) 37 "SymbolGenerator.mxg"
                        __cb.Write("global::System.Collections.Concurrent.ConcurrentDictionary<");
                        #line hidden
                        #line (153,151)-(153,178) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetCacheKeyType(symbol, op));
                        #line hidden
                        #line (153,179)-(153,180) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (153,180)-(153,181) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (153,182)-(153,192) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (153,193)-(153,198) 37 "SymbolGenerator.mxg"
                        __cb.Write(">());");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (154,25)-(154,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (154,31)-(154,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,32)-(154,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary.GetOrAdd(");
                        #line hidden
                        #line (154,61)-(154,70) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (154,71)-(154,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (154,72)-(154,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (154,73)-(154,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__args");
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
                    if (!__first28) __cb.AppendLine();
                    __cb.Push("        ");
                    #line (156,17)-(156,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (158,17)-(158,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (158,26)-(158,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (158,27)-(158,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (158,35)-(158,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (158,37)-(158,47) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (158,48)-(158,49) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (158,49)-(158,57) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (158,58)-(158,65) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (158,66)-(158,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first29 = true;
                    foreach (var __item30 in 
                    #line (158,68)-(158,138) 21 "SymbolGenerator.mxg"
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
                            #line (158,148)-(158,152) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item30);
                    }
                    #line (158,153)-(158,155) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (159,14)-(159,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first22)
                    {
                        __first22 = false;
                    }
                    __cb.Push("        ");
                    #line (160,17)-(160,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (160,23)-(160,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (160,24)-(160,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (160,32)-(160,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (160,34)-(160,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (160,45)-(160,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (160,47)-(160,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (160,55)-(160,56) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first31 = true;
                    foreach (var __item32 in 
                    #line (160,57)-(160,127) 21 "SymbolGenerator.mxg"
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
                            #line (160,137)-(160,141) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item32);
                    }
                    #line (160,142)-(160,144) 33 "SymbolGenerator.mxg"
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
            #line (164,10)-(164,40) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            __cb.Push("        ");
            #line (165,9)-(165,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (165,18)-(165,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,19)-(165,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (165,27)-(165,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,28)-(165,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (165,32)-(165,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,33)-(165,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (165,54)-(165,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,55)-(165,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (165,71)-(165,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,72)-(165,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (165,87)-(165,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,88)-(165,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (165,105)-(165,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,106)-(165,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (165,118)-(165,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,119)-(165,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (165,138)-(165,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,139)-(165,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (166,9)-(166,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (167,14)-(167,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            var __first33 = true;
            #line (168,14)-(168,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                #line (169,18)-(169,36) 17 "SymbolGenerator.mxg"
                hasNewPhase = true;
                #line hidden
                
                #line (170,18)-(170,63) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                __cb.Push("            ");
                #line (171,17)-(171,19) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (171,19)-(171,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (171,20)-(171,35) 29 "SymbolGenerator.mxg"
                __cb.Write("(incompletePart");
                #line hidden
                #line (171,35)-(171,36) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (171,36)-(171,38) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (171,38)-(171,39) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (171,39)-(171,61) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Start_");
                #line hidden
                #line (171,62)-(171,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (171,68)-(171,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (171,69)-(171,71) 29 "SymbolGenerator.mxg"
                __cb.Write("||");
                #line hidden
                #line (171,71)-(171,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (171,72)-(171,86) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart");
                #line hidden
                #line (171,86)-(171,87) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (171,87)-(171,89) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (171,89)-(171,90) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (171,90)-(171,113) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Finish_");
                #line hidden
                #line (171,114)-(171,119) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (171,120)-(171,121) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (172,17)-(172,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (173,21)-(173,23) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (173,23)-(173,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (173,24)-(173,64) 29 "SymbolGenerator.mxg"
                __cb.Write("(NotePartComplete(CompletionParts.Start_");
                #line hidden
                #line (173,65)-(173,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (173,71)-(173,73) 29 "SymbolGenerator.mxg"
                __cb.Write("))");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (174,21)-(174,22) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (175,25)-(175,28) 29 "SymbolGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (175,28)-(175,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (175,29)-(175,40) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics");
                #line hidden
                #line (175,40)-(175,41) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (175,41)-(175,42) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (175,42)-(175,43) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (175,43)-(175,73) 29 "SymbolGenerator.mxg"
                __cb.Write("__DiagnosticBag.GetInstance();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first34 = true;
                #line (176,26)-(176,48) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
                    }
                    __cb.Push("                    ");
                    #line (177,29)-(177,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (177,32)-(177,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (177,33)-(177,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (177,39)-(177,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (177,40)-(177,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (177,41)-(177,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (177,42)-(177,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (177,51)-(177,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (177,57)-(177,70) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (177,70)-(177,71) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (177,71)-(177,90) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first35 = true;
                    #line (178,30)-(178,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first35)
                        {
                            __first35 = false;
                        }
                        __cb.Push("                    ");
                        #line (179,34)-(179,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first35) __cb.AppendLine();
                }
                #line (181,26)-(181,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
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
                    __cb.Push("                    ");
                    #line (183,30)-(183,72) 32 "SymbolGenerator.mxg"
                    __cb.Write(AssignProperty(symbol, props[0], "result"));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (184,26)-(184,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
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
                if (!__first34) __cb.AppendLine();
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
            if (!__first33) __cb.AppendLine();
            var __first36 = true;
            #line (195,14)-(195,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
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
                if (__first36)
                {
                    __first36 = false;
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
            if (!__first36) __cb.AppendLine();
            __cb.Push("        ");
            #line (202,9)-(202,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first37 = true;
            #line (204,10)-(204,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (206,14)-(206,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first38 = true;
                #line (207,14)-(207,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first38)
                    {
                        __first38 = false;
                    }
                    #line (208,18)-(208,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    var __first39 = true;
                    #line (209,18)-(209,58) 21 "SymbolGenerator.mxg"
                    if (props.Where(p => p.IsDerived).Any())
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
                        if (__first39)
                        {
                            __first39 = false;
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
                        var __first40 = true;
                        #line (216,30)-(216,58) 25 "SymbolGenerator.mxg"
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
                                #line (216,68)-(216,72) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Push("                ");
                            #line (217,33)-(217,87) 41 "SymbolGenerator.mxg"
                            __cb.Write("ContainingModule!.SymbolFactory.GetSymbolPropertyValue");
                            #line hidden
                            var __first41 = true;
                            #line (217,88)-(217,117) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first41)
                                {
                                    __first41 = false;
                                }
                                #line (217,118)-(217,119) 45 "SymbolGenerator.mxg"
                                __cb.Write("s");
                                #line hidden
                            }
                            #line (217,127)-(217,128) 41 "SymbolGenerator.mxg"
                            __cb.Write("<");
                            #line hidden
                            #line (217,129)-(217,164) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type.Type));
                            #line hidden
                            #line (217,165)-(217,172) 41 "SymbolGenerator.mxg"
                            __cb.Write(">(this,");
                            #line hidden
                            #line (217,172)-(217,173) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (217,173)-(217,180) 41 "SymbolGenerator.mxg"
                            __cb.Write("nameof(");
                            #line hidden
                            #line (217,181)-(217,190) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (217,191)-(217,193) 41 "SymbolGenerator.mxg"
                            __cb.Write("),");
                            #line hidden
                            #line (217,193)-(217,194) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (217,194)-(217,206) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (217,206)-(217,207) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (217,207)-(217,226) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first40) __cb.AppendLine();
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
                    if (!__first39) __cb.AppendLine();
                }
                #line (223,14)-(223,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first38)
                    {
                        __first38 = false;
                    }
                    #line (224,18)-(224,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (225,18)-(225,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    var __first42 = true;
                    #line (226,18)-(226,37) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
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
                        if (__first42)
                        {
                            __first42 = false;
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
                        #line (231,32)-(231,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("ContainingModule!.SymbolFactory.GetSymbolPropertyValue");
                        #line hidden
                        var __first43 = true;
                        #line (231,87)-(231,116) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first43)
                            {
                                __first43 = false;
                            }
                            #line (231,117)-(231,118) 41 "SymbolGenerator.mxg"
                            __cb.Write("s");
                            #line hidden
                        }
                        #line (231,126)-(231,127) 37 "SymbolGenerator.mxg"
                        __cb.Write("<");
                        #line hidden
                        #line (231,128)-(231,163) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type.Type));
                        #line hidden
                        #line (231,164)-(231,171) 37 "SymbolGenerator.mxg"
                        __cb.Write(">(this,");
                        #line hidden
                        #line (231,171)-(231,172) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,172)-(231,179) 37 "SymbolGenerator.mxg"
                        __cb.Write("nameof(");
                        #line hidden
                        #line (231,180)-(231,189) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Name);
                        #line hidden
                        #line (231,190)-(231,192) 37 "SymbolGenerator.mxg"
                        __cb.Write("),");
                        #line hidden
                        #line (231,192)-(231,193) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,193)-(231,205) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (231,205)-(231,206) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,206)-(231,225) 37 "SymbolGenerator.mxg"
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
                    if (!__first42) __cb.AppendLine();
                }
                if (!__first38) __cb.AppendLine();
            }
            if (!__first37) __cb.AppendLine();
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
            #line (252,12)-(252,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (252,33)-(252,38) 25 "SymbolGenerator.mxg"
            __cb.Write(".Impl");
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
            #line (260,78)-(260,89) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation");
            #line hidden
            #line (260,89)-(260,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,90)-(260,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (260,91)-(260,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,92)-(260,97) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (260,97)-(260,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,98)-(260,116) 25 "SymbolGenerator.mxg"
            __cb.Write("MergedDeclaration?");
            #line hidden
            #line (260,116)-(260,117) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,117)-(260,128) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration");
            #line hidden
            #line (260,128)-(260,129) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,129)-(260,130) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (260,130)-(260,131) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,131)-(260,136) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (260,136)-(260,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,137)-(260,145) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model?");
            #line hidden
            #line (260,145)-(260,146) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,146)-(260,151) 25 "SymbolGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (260,151)-(260,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,152)-(260,153) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (260,153)-(260,154) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,154)-(260,159) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (260,159)-(260,160) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,160)-(260,175) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (260,175)-(260,176) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,176)-(260,187) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (260,187)-(260,188) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,188)-(260,189) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (260,189)-(260,190) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,190)-(260,195) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (260,195)-(260,196) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,196)-(260,205) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (260,205)-(260,206) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,206)-(260,218) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol");
            #line hidden
            #line (260,218)-(260,219) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,219)-(260,220) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (260,220)-(260,221) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,221)-(260,226) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (260,226)-(260,227) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,227)-(260,243) 25 "SymbolGenerator.mxg"
            __cb.Write("ErrorSymbolInfo?");
            #line hidden
            #line (260,243)-(260,244) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,244)-(260,253) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo");
            #line hidden
            #line (260,253)-(260,254) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,254)-(260,255) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (260,255)-(260,256) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,256)-(260,261) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (260,261)-(260,262) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,262)-(260,266) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (260,266)-(260,267) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,267)-(260,278) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol");
            #line hidden
            #line (260,278)-(260,279) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,279)-(260,280) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (260,280)-(260,281) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,281)-(260,287) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (260,287)-(260,288) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,288)-(260,295) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (260,295)-(260,296) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,296)-(260,300) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (260,300)-(260,301) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,301)-(260,302) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (260,302)-(260,303) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,303)-(260,311) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (260,311)-(260,312) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,312)-(260,319) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (260,319)-(260,320) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,320)-(260,332) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (260,332)-(260,333) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,333)-(260,334) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (260,334)-(260,335) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,335)-(260,343) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (260,343)-(260,344) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,344)-(260,412) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>");
            #line hidden
            #line (260,412)-(260,413) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,413)-(260,423) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (260,423)-(260,424) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,424)-(260,425) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (260,425)-(260,426) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,426)-(260,433) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first44 = true;
            #line (260,434)-(260,502) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                #line (260,503)-(260,504) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (260,504)-(260,505) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (260,506)-(260,536) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (260,537)-(260,538) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (260,539)-(260,557) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (260,558)-(260,559) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (260,559)-(260,560) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (260,560)-(260,561) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (260,562)-(260,596) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (260,610)-(260,611) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (260,611)-(260,612) 25 "SymbolGenerator.mxg"
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
            __cb.Write("errorInfo,");
            #line hidden
            #line (261,101)-(261,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,102)-(261,114) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol,");
            #line hidden
            #line (261,114)-(261,115) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,115)-(261,120) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (261,120)-(261,121) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,121)-(261,134) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (261,134)-(261,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,135)-(261,145) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first45 = true;
            #line (261,146)-(261,218) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                #line (261,219)-(261,220) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (261,220)-(261,221) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (261,222)-(261,240) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (261,241)-(261,242) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (261,242)-(261,243) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (261,244)-(261,262) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (261,276)-(261,277) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
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
            var __first46 = true;
            #line (270,6)-(270,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                var __first47 = true;
                #line (271,10)-(271,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first47)
                    {
                        __first47 = false;
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
                if (!__first47) __cb.AppendLine();
            }
            #line (282,6)-(282,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
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
            if (!__first46) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}