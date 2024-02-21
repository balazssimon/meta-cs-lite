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
    #line (4,7)-(4,28) 13 "SymbolGenerator.mxg"
    MetaDslx.CodeAnalysis;
    #line hidden
    #line (5,1)-(5,6) 5 "SymbolGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,43) 13 "SymbolGenerator.mxg"
    MetaDslx.Languages.MetaSymbols.Model;
    #line hidden
    
    #line (7,10)-(7,26) 25 "SymbolGenerator.mxg"
    public partial class SymbolGenerator
    #line hidden
    {
        #line (9,9)-(9,39) 22 "SymbolGenerator.mxg"
        public string GenerateSymbol(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (10,1)-(10,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (10,10)-(10,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (10,12)-(10,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (11,1)-(11,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (12,5)-(12,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (12,10)-(12,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,11)-(12,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (12,20)-(12,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,21)-(12,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (12,22)-(12,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,23)-(12,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
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
            #line (13,11)-(13,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (13,19)-(13,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,20)-(13,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (13,21)-(13,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,22)-(13,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
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
            #line (14,11)-(14,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__AttributeSymbol");
            #line hidden
            #line (14,28)-(14,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,29)-(14,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (14,30)-(14,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,31)-(14,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol;");
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
            #line (15,11)-(15,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__AssemblySymbol");
            #line hidden
            #line (15,27)-(15,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,28)-(15,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (15,29)-(15,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,30)-(15,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AssemblySymbol;");
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
            #line (16,11)-(16,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol");
            #line hidden
            #line (16,25)-(16,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,26)-(16,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (16,27)-(16,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,28)-(16,79) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModuleSymbol;");
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
            #line (17,11)-(17,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol");
            #line hidden
            #line (17,30)-(17,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,31)-(17,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (17,32)-(17,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,33)-(17,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol;");
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
            __cb.Write("__NamespaceSymbol");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol;");
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
            #line (19,11)-(19,23) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol");
            #line hidden
            #line (19,23)-(19,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,24)-(19,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (19,25)-(19,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,26)-(19,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol;");
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
            __cb.Write("__ISymbolFactory");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory;");
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
            __cb.Write("__LexicalSortKey");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.LexicalSortKey;");
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
            __cb.Write("__IModelObject");
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
            #line (22,28)-(22,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
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
            #line (23,11)-(23,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (23,18)-(23,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,19)-(23,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (23,20)-(23,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,21)-(23,53) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
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
            __cb.Write("__ErrorSymbolInfo");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
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
            #line (25,11)-(25,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (25,26)-(25,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,27)-(25,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (25,28)-(25,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,29)-(25,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
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
            __cb.Write("__CompletionGraph");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
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
            __cb.Write("__CompletionPart");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
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
            #line (28,11)-(28,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (28,30)-(28,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,31)-(28,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (28,32)-(28,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,33)-(28,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
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
            __cb.Write("__DiagnosticBag");
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
            #line (29,29)-(29,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
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
            #line (30,11)-(30,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (30,24)-(30,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,25)-(30,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (30,26)-(30,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,27)-(30,69) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Compilation;");
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
            __cb.Write("__SourceLocation");
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
            #line (31,30)-(31,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
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
            __cb.Write("__CancellationToken");
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
            #line (32,33)-(32,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
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
            #line (33,11)-(33,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (33,36)-(33,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,37)-(33,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (33,38)-(33,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,39)-(33,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
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
            __cb.Write("__CultureInfo");
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
            #line (34,27)-(34,68) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Globalization.CultureInfo;");
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
            #line (35,11)-(35,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (35,38)-(35,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,39)-(35,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (35,40)-(35,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,41)-(35,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            #line (37,6)-(37,38) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (38,6)-(38,65) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            #line (39,5)-(39,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (39,11)-(39,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,12)-(39,20) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (39,20)-(39,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,21)-(39,28) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (39,28)-(39,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,29)-(39,34) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (39,34)-(39,35) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,36)-(39,63) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (39,64)-(39,65) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (39,65)-(39,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first1 = true;
            #line (39,67)-(39,90) 13 "SymbolGenerator.mxg"
            if (baseSymbol is null)
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                #line (39,91)-(39,135) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol");
                #line hidden
            }
            #line (39,136)-(39,140) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                #line (39,142)-(39,173) 28 "SymbolGenerator.mxg"
                __cb.Write(GetBaseName(symbol, baseSymbol));
                #line hidden
            }
            if (!__first1) __cb.AppendLine();
            __cb.Push("    ");
            #line (40,5)-(40,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (41,9)-(41,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (41,15)-(41,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,16)-(41,22) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (41,22)-(41,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,23)-(41,26) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (41,26)-(41,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,27)-(41,32) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (41,32)-(41,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,33)-(41,48) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (42,9)-(42,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first2 = true;
            #line (43,14)-(43,57) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetAllPhases(symbol))
            #line hidden
            
            {
                if (__first2)
                {
                    __first2 = false;
                }
                __cb.Push("            ");
                #line (44,17)-(44,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (44,23)-(44,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (44,24)-(44,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (44,30)-(44,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (44,31)-(44,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (44,39)-(44,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (44,40)-(44,54) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart");
                #line hidden
                #line (44,54)-(44,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (44,55)-(44,61) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (44,62)-(44,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (44,68)-(44,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (44,69)-(44,70) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (44,70)-(44,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (44,71)-(44,74) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (44,74)-(44,75) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (44,75)-(44,103) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart(nameof(Start_");
                #line hidden
                #line (44,104)-(44,109) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (44,110)-(44,113) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (45,17)-(45,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (45,23)-(45,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (45,24)-(45,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (45,30)-(45,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (45,31)-(45,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (45,39)-(45,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (45,40)-(45,54) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart");
                #line hidden
                #line (45,54)-(45,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (45,55)-(45,62) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (45,63)-(45,68) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (45,69)-(45,70) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (45,70)-(45,71) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (45,71)-(45,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (45,72)-(45,75) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (45,75)-(45,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (45,76)-(45,105) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart(nameof(Finish_");
                #line hidden
                #line (45,106)-(45,111) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (45,112)-(45,115) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            __cb.Push("            ");
            #line (47,13)-(47,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (47,19)-(47,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,20)-(47,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (47,26)-(47,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,27)-(47,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (47,35)-(47,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,36)-(47,50) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart");
            #line hidden
            #line (47,50)-(47,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,51)-(47,67) 25 "SymbolGenerator.mxg"
            __cb.Write("Start_Attributes");
            #line hidden
            #line (47,67)-(47,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,68)-(47,69) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (47,69)-(47,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,70)-(47,73) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (47,73)-(47,74) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,74)-(47,115) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart(nameof(Start_Attributes));");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (48,13)-(48,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (48,19)-(48,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,20)-(48,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (48,26)-(48,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,27)-(48,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (48,35)-(48,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,36)-(48,50) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart");
            #line hidden
            #line (48,50)-(48,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,51)-(48,68) 25 "SymbolGenerator.mxg"
            __cb.Write("Finish_Attributes");
            #line hidden
            #line (48,68)-(48,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,69)-(48,70) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (48,70)-(48,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,71)-(48,74) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (48,74)-(48,75) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,75)-(48,117) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart(nameof(Finish_Attributes));");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (50,13)-(50,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (50,19)-(50,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,20)-(50,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (50,26)-(50,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,27)-(50,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (50,35)-(50,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,36)-(50,51) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (50,51)-(50,52) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,52)-(50,67) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (50,67)-(50,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,68)-(50,69) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (50,69)-(50,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (51,17)-(51,49) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph.CreateFromParts(");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first3 = true;
            #line (52,22)-(52,65) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetAllPhases(symbol))
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                __cb.Push("                    ");
                #line (53,25)-(53,31) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (53,32)-(53,37) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (53,38)-(53,39) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (53,39)-(53,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (53,40)-(53,47) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (53,48)-(53,53) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (53,54)-(53,55) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first3) __cb.AppendLine();
            __cb.Push("                    ");
            #line (55,21)-(55,38) 25 "SymbolGenerator.mxg"
            __cb.Write("Start_Attributes,");
            #line hidden
            #line (55,38)-(55,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,39)-(55,56) 25 "SymbolGenerator.mxg"
            __cb.Write("Finish_Attributes");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (56,17)-(56,19) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (57,9)-(57,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first4 = true;
            #line (59,10)-(59,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first4)
                {
                    __first4 = false;
                }
                var __first5 = true;
                #line (60,14)-(60,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first5)
                    {
                        __first5 = false;
                    }
                    __cb.Push("        ");
                    #line (61,17)-(61,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (61,24)-(61,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (61,25)-(61,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (61,31)-(61,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (61,33)-(61,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (61,60)-(61,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (61,62)-(61,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (61,81)-(61,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (61,82)-(61,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (61,83)-(61,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (61,84)-(61,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (61,87)-(61,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (61,89)-(61,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (61,116)-(61,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (62,14)-(62,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first5)
                    {
                        __first5 = false;
                    }
                    __cb.Push("        ");
                    #line (63,17)-(63,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (63,24)-(63,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (63,26)-(63,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (63,53)-(63,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (63,55)-(63,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (63,74)-(63,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first5) __cb.AppendLine();
            }
            if (!__first4) __cb.AppendLine();
            var __first6 = true;
            #line (66,10)-(66,73) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations.Where(o => o.CacheResult))
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("        ");
                #line (67,13)-(67,20) 29 "SymbolGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (67,20)-(67,21) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (67,21)-(67,27) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (67,27)-(67,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (67,29)-(67,53) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (67,54)-(67,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (67,56)-(67,72) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(op));
                #line hidden
                #line (67,73)-(67,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (67,74)-(67,75) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (67,75)-(67,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (67,76)-(67,79) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (67,79)-(67,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (67,81)-(67,105) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (67,106)-(67,109) 29 "SymbolGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first6) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (70,9)-(70,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (70,15)-(70,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,17)-(70,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (70,45)-(70,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol?");
            #line hidden
            #line (70,55)-(70,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,56)-(70,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (70,66)-(70,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,67)-(70,81) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation?");
            #line hidden
            #line (70,81)-(70,82) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,82)-(70,93) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation");
            #line hidden
            #line (70,93)-(70,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,94)-(70,95) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,95)-(70,96) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,96)-(70,101) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (70,101)-(70,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,102)-(70,122) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration?");
            #line hidden
            #line (70,122)-(70,123) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,123)-(70,134) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration");
            #line hidden
            #line (70,134)-(70,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,135)-(70,136) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,136)-(70,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,137)-(70,142) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (70,142)-(70,143) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,143)-(70,151) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model?");
            #line hidden
            #line (70,151)-(70,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,152)-(70,157) 25 "SymbolGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (70,157)-(70,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,158)-(70,159) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,159)-(70,160) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,160)-(70,165) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (70,165)-(70,166) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,166)-(70,181) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (70,181)-(70,182) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,182)-(70,193) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (70,193)-(70,194) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,194)-(70,195) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,195)-(70,196) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,196)-(70,201) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (70,201)-(70,202) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,202)-(70,211) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (70,211)-(70,212) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,212)-(70,224) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol");
            #line hidden
            #line (70,224)-(70,225) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,225)-(70,226) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,226)-(70,227) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,227)-(70,232) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (70,232)-(70,233) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,233)-(70,251) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo?");
            #line hidden
            #line (70,251)-(70,252) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,252)-(70,261) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo");
            #line hidden
            #line (70,261)-(70,262) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,262)-(70,263) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,263)-(70,264) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,264)-(70,269) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (70,269)-(70,270) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,270)-(70,274) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (70,274)-(70,275) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,275)-(70,286) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol");
            #line hidden
            #line (70,286)-(70,287) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,287)-(70,288) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,288)-(70,289) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,289)-(70,295) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (70,295)-(70,296) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,296)-(70,303) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (70,303)-(70,304) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,304)-(70,308) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (70,308)-(70,309) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,309)-(70,310) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,310)-(70,311) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,311)-(70,319) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (70,319)-(70,320) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,320)-(70,327) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (70,327)-(70,328) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,328)-(70,340) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (70,340)-(70,341) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,341)-(70,342) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,342)-(70,343) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,343)-(70,351) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (70,351)-(70,352) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,352)-(70,420) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>");
            #line hidden
            #line (70,420)-(70,421) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,421)-(70,431) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (70,431)-(70,432) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,432)-(70,433) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,433)-(70,434) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,434)-(70,441) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first7 = true;
            #line (70,442)-(70,510) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (70,511)-(70,512) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (70,512)-(70,513) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (70,514)-(70,544) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (70,545)-(70,546) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (70,547)-(70,565) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (70,566)-(70,567) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (70,567)-(70,568) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (70,568)-(70,569) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (70,570)-(70,604) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (70,618)-(70,619) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (70,619)-(70,620) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (71,13)-(71,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (71,14)-(71,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,15)-(71,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (71,30)-(71,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,31)-(71,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (71,43)-(71,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,44)-(71,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (71,56)-(71,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,57)-(71,63) 25 "SymbolGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (71,63)-(71,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,64)-(71,76) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (71,76)-(71,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,77)-(71,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (71,90)-(71,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,91)-(71,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (71,101)-(71,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,102)-(71,114) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol,");
            #line hidden
            #line (71,114)-(71,115) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,115)-(71,120) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (71,120)-(71,121) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,121)-(71,134) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (71,134)-(71,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,135)-(71,145) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first8 = true;
            #line (71,146)-(71,218) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                #line (71,219)-(71,220) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (71,220)-(71,221) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (71,222)-(71,240) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (71,241)-(71,242) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (71,242)-(71,243) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (71,244)-(71,262) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (71,276)-(71,277) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (72,9)-(72,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (73,13)-(73,15) 25 "SymbolGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (73,15)-(73,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,16)-(73,29) 25 "SymbolGenerator.mxg"
            __cb.Write("(fixedSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (74,13)-(74,14) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first9 = true;
            #line (75,18)-(75,82) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                __cb.Push("                ");
                #line (76,22)-(76,70) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            __cb.Push("            ");
            #line (78,13)-(78,14) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
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
            var __first10 = true;
            #line (81,10)-(81,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first10)
                {
                    __first10 = false;
                }
                var __first11 = true;
                #line (82,14)-(82,34) 17 "SymbolGenerator.mxg"
                if (!prop.IsDerived)
                #line hidden
                
                {
                    if (__first11)
                    {
                        __first11 = false;
                    }
                    __cb.Push("        ");
                    #line (83,18)-(83,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (83,22)-(83,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (83,38)-(83,41) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first11) __cb.AppendLine();
                __cb.Push("        ");
                #line (85,13)-(85,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (85,19)-(85,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (85,21)-(85,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (85,52)-(85,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (85,54)-(85,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (86,13)-(86,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (87,17)-(87,20) 29 "SymbolGenerator.mxg"
                __cb.Write("get");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (88,17)-(88,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (89,21)-(89,63) 29 "SymbolGenerator.mxg"
                __cb.Write("this.ForceComplete(CompletionParts.Finish_");
                #line hidden
                #line (89,64)-(89,93) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Phase?.Name ?? prop.Name);
                #line hidden
                #line (89,94)-(89,95) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (89,95)-(89,96) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (89,96)-(89,101) 29 "SymbolGenerator.mxg"
                __cb.Write("null,");
                #line hidden
                #line (89,101)-(89,102) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (89,102)-(89,111) 29 "SymbolGenerator.mxg"
                __cb.Write("default);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first12 = true;
                #line (90,22)-(90,38) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("                ");
                    #line (91,25)-(91,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (91,27)-(91,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,28)-(91,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (91,30)-(91,48) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (91,49)-(91,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(".TryGetValue(this,");
                    #line hidden
                    #line (91,67)-(91,68) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,68)-(91,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("out");
                    #line hidden
                    #line (91,71)-(91,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,72)-(91,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (91,75)-(91,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,76)-(91,84) 33 "SymbolGenerator.mxg"
                    __cb.Write("result))");
                    #line hidden
                    #line (91,84)-(91,85) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,85)-(91,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (91,91)-(91,92) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,92)-(91,93) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (91,94)-(91,124) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (91,125)-(91,133) 33 "SymbolGenerator.mxg"
                    __cb.Write(")result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (92,25)-(92,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (92,29)-(92,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (92,30)-(92,36) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (92,36)-(92,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (92,38)-(92,67) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (92,68)-(92,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (93,22)-(93,26) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("                ");
                    #line (94,25)-(94,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (94,31)-(94,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (94,33)-(94,51) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (94,52)-(94,53) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first12) __cb.AppendLine();
                __cb.Push("            ");
                #line (96,17)-(96,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (97,13)-(97,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first10) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first13 = true;
            #line (100,10)-(100,47) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                #line (101,14)-(101,90) 17 "SymbolGenerator.mxg"
                var arguments = "("+string.Join(", ", op.Parameters.Select(p => p.Name))+")";
                #line hidden
                
                #line (102,14)-(102,42) 17 "SymbolGenerator.mxg"
                var call = op.Name+arguments;
                #line hidden
                
                #line (103,14)-(103,65) 17 "SymbolGenerator.mxg"
                var returnType = GetTypeName(symbol, op.ReturnType);
                #line hidden
                
                __cb.WriteLine();
                __cb.Pop();
                var __first14 = true;
                #line (105,14)-(105,29) 17 "SymbolGenerator.mxg"
                if (op.IsPhase)
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    __cb.Push("        ");
                    #line (106,17)-(106,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (106,26)-(106,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (106,27)-(106,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (106,35)-(106,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (106,36)-(106,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (106,40)-(106,41) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (106,42)-(106,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (106,50)-(106,66) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (106,66)-(106,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (106,67)-(106,79) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (106,79)-(106,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (106,80)-(106,99) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (106,99)-(106,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (106,100)-(106,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (107,14)-(107,38) 17 "SymbolGenerator.mxg"
                else if (op.CacheResult)
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    __cb.Push("        ");
                    #line (108,17)-(108,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (108,23)-(108,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (108,25)-(108,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (108,36)-(108,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (108,38)-(108,45) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (108,46)-(108,47) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first15 = true;
                    foreach (var __item16 in 
                    #line (108,48)-(108,118) 21 "SymbolGenerator.mxg"
                    from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                    #line hidden
                    )
                    {
                        if (__first15)
                        {
                            __first15 = false;
                        }
                        else
                        {
                            __cb.Push("        ");
                            __cb.DontIgnoreLastLineEnd = true;
                            #line (108,128)-(108,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item16);
                    }
                    #line (108,133)-(108,134) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (109,17)-(109,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first17 = true;
                    #line (110,22)-(110,67) 21 "SymbolGenerator.mxg"
                    if (!string.IsNullOrEmpty(op.CacheCondition))
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("            ");
                        #line (111,25)-(111,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (111,27)-(111,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (111,28)-(111,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!(");
                        #line hidden
                        #line (111,32)-(111,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.CacheCondition);
                        #line hidden
                        #line (111,50)-(111,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                        #line (111,52)-(111,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (111,53)-(111,59) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (111,59)-(111,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (111,61)-(111,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, op.ReturnType));
                        #line hidden
                        #line (111,100)-(111,101) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first17) __cb.AppendLine();
                    #line (113,22)-(113,54) 21 "SymbolGenerator.mxg"
                    var fieldName = GetFieldName(op);
                    #line hidden
                    
                    var __first18 = true;
                    #line (114,22)-(114,51) 21 "SymbolGenerator.mxg"
                    if (op.Parameters.Count == 0)
                    #line hidden
                    
                    {
                        if (__first18)
                        {
                            __first18 = false;
                        }
                        __cb.Push("            ");
                        #line (115,25)-(115,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (115,31)-(115,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (115,32)-(115,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (115,34)-(115,44) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (115,45)-(115,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (115,47)-(115,56) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (115,57)-(115,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (115,72)-(115,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (115,73)-(115,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (115,79)-(115,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (115,80)-(115,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (115,82)-(115,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (115,83)-(115,91) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (115,92)-(115,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.Name);
                        #line hidden
                        #line (115,101)-(115,110) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (115,111)-(115,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (116,22)-(116,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first18)
                        {
                            __first18 = false;
                        }
                        __cb.Push("            ");
                        #line (117,25)-(117,28) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (117,28)-(117,29) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (117,29)-(117,47) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary");
                        #line hidden
                        #line (117,47)-(117,48) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (117,48)-(117,49) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (117,49)-(117,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (117,51)-(117,60) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (117,61)-(117,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (117,76)-(117,77) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (117,77)-(117,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (117,83)-(117,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (117,84)-(117,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (117,86)-(117,87) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (117,87)-(117,90) 37 "SymbolGenerator.mxg"
                        __cb.Write("new");
                        #line hidden
                        #line (117,90)-(117,91) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (117,91)-(117,150) 37 "SymbolGenerator.mxg"
                        __cb.Write("global::System.Collections.Concurrent.ConcurrentDictionary<");
                        #line hidden
                        #line (117,151)-(117,178) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetCacheKeyType(symbol, op));
                        #line hidden
                        #line (117,179)-(117,180) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (117,180)-(117,181) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (117,182)-(117,192) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (117,193)-(117,198) 37 "SymbolGenerator.mxg"
                        __cb.Write(">());");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (118,25)-(118,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (118,31)-(118,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (118,32)-(118,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary.GetOrAdd(");
                        #line hidden
                        #line (118,61)-(118,70) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (118,71)-(118,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (118,72)-(118,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (118,73)-(118,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__args");
                        #line hidden
                        #line (118,79)-(118,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (118,80)-(118,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (118,82)-(118,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (118,83)-(118,91) 37 "SymbolGenerator.mxg"
                        __cb.Write("Compute_");
                        #line hidden
                        #line (118,92)-(118,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.Name);
                        #line hidden
                        #line (118,101)-(118,110) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (118,111)-(118,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first18) __cb.AppendLine();
                    __cb.Push("        ");
                    #line (120,17)-(120,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (122,17)-(122,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (122,26)-(122,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (122,27)-(122,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (122,35)-(122,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (122,37)-(122,47) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (122,48)-(122,49) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (122,49)-(122,57) 33 "SymbolGenerator.mxg"
                    __cb.Write("Compute_");
                    #line hidden
                    #line (122,58)-(122,65) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (122,66)-(122,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first19 = true;
                    foreach (var __item20 in 
                    #line (122,68)-(122,138) 21 "SymbolGenerator.mxg"
                    from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                    #line hidden
                    )
                    {
                        if (__first19)
                        {
                            __first19 = false;
                        }
                        else
                        {
                            __cb.Push("        ");
                            __cb.DontIgnoreLastLineEnd = true;
                            #line (122,148)-(122,152) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item20);
                    }
                    #line (122,153)-(122,155) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (123,14)-(123,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    __cb.Push("        ");
                    #line (124,17)-(124,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (124,23)-(124,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (124,24)-(124,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (124,32)-(124,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (124,34)-(124,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (124,45)-(124,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (124,47)-(124,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (124,55)-(124,56) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first21 = true;
                    foreach (var __item22 in 
                    #line (124,57)-(124,127) 21 "SymbolGenerator.mxg"
                    from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                    #line hidden
                    )
                    {
                        if (__first21)
                        {
                            __first21 = false;
                        }
                        else
                        {
                            __cb.Push("        ");
                            __cb.DontIgnoreLastLineEnd = true;
                            #line (124,137)-(124,141) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item22);
                    }
                    #line (124,142)-(124,144) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first14) __cb.AppendLine();
            }
            if (!__first13) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            #line (128,10)-(128,40) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            __cb.Push("        ");
            #line (129,9)-(129,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (129,18)-(129,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,19)-(129,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (129,27)-(129,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,28)-(129,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (129,32)-(129,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,33)-(129,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (129,54)-(129,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,55)-(129,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (129,71)-(129,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,72)-(129,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (129,87)-(129,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,88)-(129,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (129,105)-(129,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,106)-(129,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (129,118)-(129,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,119)-(129,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (129,138)-(129,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,139)-(129,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (130,9)-(130,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (131,14)-(131,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            var __first23 = true;
            #line (132,14)-(132,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                #line (133,18)-(133,36) 17 "SymbolGenerator.mxg"
                hasNewPhase = true;
                #line hidden
                
                #line (134,18)-(134,63) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                __cb.Push("            ");
                #line (135,17)-(135,19) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (135,19)-(135,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (135,20)-(135,35) 29 "SymbolGenerator.mxg"
                __cb.Write("(incompletePart");
                #line hidden
                #line (135,35)-(135,36) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (135,36)-(135,38) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (135,38)-(135,39) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (135,39)-(135,61) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Start_");
                #line hidden
                #line (135,62)-(135,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (135,68)-(135,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (135,69)-(135,71) 29 "SymbolGenerator.mxg"
                __cb.Write("||");
                #line hidden
                #line (135,71)-(135,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (135,72)-(135,86) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart");
                #line hidden
                #line (135,86)-(135,87) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (135,87)-(135,89) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (135,89)-(135,90) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (135,90)-(135,113) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionParts.Finish_");
                #line hidden
                #line (135,114)-(135,119) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (135,120)-(135,121) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (136,17)-(136,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (137,21)-(137,23) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (137,23)-(137,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (137,24)-(137,64) 29 "SymbolGenerator.mxg"
                __cb.Write("(NotePartComplete(CompletionParts.Start_");
                #line hidden
                #line (137,65)-(137,70) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (137,71)-(137,73) 29 "SymbolGenerator.mxg"
                __cb.Write("))");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (138,21)-(138,22) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (139,25)-(139,28) 29 "SymbolGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (139,28)-(139,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (139,29)-(139,40) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics");
                #line hidden
                #line (139,40)-(139,41) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (139,41)-(139,42) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (139,42)-(139,43) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (139,43)-(139,73) 29 "SymbolGenerator.mxg"
                __cb.Write("__DiagnosticBag.GetInstance();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first24 = true;
                #line (140,26)-(140,48) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    __cb.Push("                    ");
                    #line (141,29)-(141,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (141,32)-(141,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (141,33)-(141,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (141,39)-(141,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (141,40)-(141,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (141,41)-(141,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (141,42)-(141,51) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (141,52)-(141,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (141,58)-(141,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (141,71)-(141,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (141,72)-(141,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first25 = true;
                    #line (142,30)-(142,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("                    ");
                        #line (143,34)-(143,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first25) __cb.AppendLine();
                }
                #line (145,26)-(145,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    __cb.Push("                    ");
                    #line (146,29)-(146,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (146,32)-(146,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,33)-(146,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (146,39)-(146,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,40)-(146,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (146,41)-(146,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,42)-(146,51) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (146,52)-(146,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (146,58)-(146,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (146,71)-(146,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,72)-(146,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (147,30)-(147,72) 32 "SymbolGenerator.mxg"
                    __cb.Write(AssignProperty(symbol, props[0], "result"));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (148,26)-(148,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    __cb.Push("                    ");
                    #line (149,30)-(149,35) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (149,36)-(149,49) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (149,49)-(149,50) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (149,50)-(149,69) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first24) __cb.AppendLine();
                __cb.Push("                    ");
                #line (151,25)-(151,59) 29 "SymbolGenerator.mxg"
                __cb.Write("AddSymbolDiagnostics(diagnostics);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (152,25)-(152,44) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics.Free();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (153,25)-(153,65) 29 "SymbolGenerator.mxg"
                __cb.Write("NotePartComplete(CompletionParts.Finish_");
                #line hidden
                #line (153,66)-(153,71) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (153,72)-(153,74) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (154,21)-(154,22) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (155,21)-(155,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (155,27)-(155,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (155,28)-(155,33) 29 "SymbolGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (156,17)-(156,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (157,17)-(157,21) 29 "SymbolGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (157,21)-(157,22) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first23) __cb.AppendLine();
            var __first26 = true;
            #line (159,14)-(159,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first26)
                {
                    __first26 = false;
                }
                __cb.Push("            ");
                #line (160,17)-(160,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (161,21)-(161,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (161,27)-(161,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (161,28)-(161,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (161,54)-(161,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (161,55)-(161,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (161,70)-(161,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (161,71)-(161,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (161,83)-(161,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (161,84)-(161,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (162,17)-(162,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (163,14)-(163,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first26)
                {
                    __first26 = false;
                }
                __cb.Push("            ");
                #line (164,17)-(164,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (164,23)-(164,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (164,24)-(164,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (164,50)-(164,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (164,51)-(164,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (164,66)-(164,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (164,67)-(164,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (164,79)-(164,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (164,80)-(164,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first26) __cb.AppendLine();
            __cb.Push("        ");
            #line (166,9)-(166,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first27 = true;
            #line (168,10)-(168,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first27)
                {
                    __first27 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (170,14)-(170,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first28 = true;
                #line (171,14)-(171,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    #line (172,18)-(172,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    var __first29 = true;
                    #line (173,18)-(173,58) 21 "SymbolGenerator.mxg"
                    if (props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first29)
                        {
                            __first29 = false;
                        }
                        __cb.Push("        ");
                        #line (174,21)-(174,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (174,30)-(174,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (174,31)-(174,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (174,39)-(174,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (174,41)-(174,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (174,52)-(174,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (174,53)-(174,62) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (174,63)-(174,68) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (174,69)-(174,85) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (174,85)-(174,86) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (174,86)-(174,98) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (174,98)-(174,99) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (174,99)-(174,118) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (174,118)-(174,119) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (174,119)-(174,138) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (175,18)-(175,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first29)
                        {
                            __first29 = false;
                        }
                        __cb.Push("        ");
                        #line (176,21)-(176,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (176,30)-(176,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,31)-(176,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (176,38)-(176,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,40)-(176,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (176,51)-(176,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,52)-(176,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (176,62)-(176,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (176,68)-(176,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (176,84)-(176,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,85)-(176,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (176,97)-(176,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,98)-(176,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (176,117)-(176,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,118)-(176,136) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (177,21)-(177,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = true;
                        __cb.Push("            ");
                        #line (179,25)-(179,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (179,31)-(179,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (179,32)-(179,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first30 = true;
                        #line (180,30)-(180,58) 25 "SymbolGenerator.mxg"
                        foreach (var prop in props) 
                        #line hidden
                        
                        {
                            if (__first30)
                            {
                                __first30 = false;
                            }
                            else
                            {
                                __cb.Push("                ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (180,68)-(180,72) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Push("                ");
                            #line (181,33)-(181,87) 41 "SymbolGenerator.mxg"
                            __cb.Write("ContainingModule!.SymbolFactory.GetSymbolPropertyValue");
                            #line hidden
                            var __first31 = true;
                            #line (181,88)-(181,117) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first31)
                                {
                                    __first31 = false;
                                }
                                #line (181,118)-(181,119) 45 "SymbolGenerator.mxg"
                                __cb.Write("s");
                                #line hidden
                            }
                            #line (181,127)-(181,128) 41 "SymbolGenerator.mxg"
                            __cb.Write("<");
                            #line hidden
                            #line (181,129)-(181,164) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type.Type));
                            #line hidden
                            #line (181,165)-(181,172) 41 "SymbolGenerator.mxg"
                            __cb.Write(">(this,");
                            #line hidden
                            #line (181,172)-(181,173) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (181,173)-(181,180) 41 "SymbolGenerator.mxg"
                            __cb.Write("nameof(");
                            #line hidden
                            #line (181,181)-(181,190) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (181,191)-(181,193) 41 "SymbolGenerator.mxg"
                            __cb.Write("),");
                            #line hidden
                            #line (181,193)-(181,194) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (181,194)-(181,206) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (181,206)-(181,207) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (181,207)-(181,226) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first30) __cb.AppendLine();
                        __cb.Push("            ");
                        #line (183,25)-(183,27) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.SingleLineMode = false;
                        __cb.AppendLine();
                        __cb.Push("        ");
                        #line (185,21)-(185,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first29) __cb.AppendLine();
                }
                #line (187,14)-(187,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    #line (188,18)-(188,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (189,18)-(189,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    var __first32 = true;
                    #line (190,18)-(190,37) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        __cb.Push("        ");
                        #line (191,21)-(191,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (191,30)-(191,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (191,31)-(191,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (191,39)-(191,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (191,41)-(191,51) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (191,52)-(191,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (191,53)-(191,62) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (191,63)-(191,68) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (191,69)-(191,85) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (191,85)-(191,86) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (191,86)-(191,98) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (191,98)-(191,99) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (191,99)-(191,118) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (191,118)-(191,119) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (191,119)-(191,138) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (192,18)-(192,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        __cb.Push("        ");
                        #line (193,21)-(193,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (193,30)-(193,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (193,31)-(193,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (193,38)-(193,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (193,40)-(193,50) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (193,51)-(193,52) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (193,52)-(193,61) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (193,62)-(193,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (193,68)-(193,84) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (193,84)-(193,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (193,85)-(193,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (193,97)-(193,98) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (193,98)-(193,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (193,117)-(193,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (193,118)-(193,136) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (194,21)-(194,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (195,25)-(195,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (195,31)-(195,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (195,32)-(195,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("ContainingModule!.SymbolFactory.GetSymbolPropertyValue");
                        #line hidden
                        var __first33 = true;
                        #line (195,87)-(195,116) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first33)
                            {
                                __first33 = false;
                            }
                            #line (195,117)-(195,118) 41 "SymbolGenerator.mxg"
                            __cb.Write("s");
                            #line hidden
                        }
                        #line (195,126)-(195,127) 37 "SymbolGenerator.mxg"
                        __cb.Write("<");
                        #line hidden
                        #line (195,128)-(195,163) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type.Type));
                        #line hidden
                        #line (195,164)-(195,171) 37 "SymbolGenerator.mxg"
                        __cb.Write(">(this,");
                        #line hidden
                        #line (195,171)-(195,172) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (195,172)-(195,179) 37 "SymbolGenerator.mxg"
                        __cb.Write("nameof(");
                        #line hidden
                        #line (195,180)-(195,189) 36 "SymbolGenerator.mxg"
                        __cb.Write(prop.Name);
                        #line hidden
                        #line (195,190)-(195,192) 37 "SymbolGenerator.mxg"
                        __cb.Write("),");
                        #line hidden
                        #line (195,192)-(195,193) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (195,193)-(195,205) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (195,205)-(195,206) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (195,206)-(195,225) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (196,21)-(196,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first32) __cb.AppendLine();
                }
                if (!__first28) __cb.AppendLine();
            }
            if (!__first27) __cb.AppendLine();
            __cb.Push("    ");
            #line (200,5)-(200,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (201,1)-(201,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (204,9)-(204,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (205,2)-(205,34) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (206,2)-(206,61) 13 "SymbolGenerator.mxg"
            var baseSymbol = baseTypes.Count == 1 ? baseTypes[0] : null;
            #line hidden
            
            __cb.Push("");
            #line (207,1)-(207,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (207,6)-(207,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,7)-(207,14) 25 "SymbolGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (208,1)-(208,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (208,6)-(208,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,7)-(208,34) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Generic;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (209,1)-(209,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (209,6)-(209,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,7)-(209,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (210,1)-(210,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (210,6)-(210,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,7)-(210,19) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Linq;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (211,1)-(211,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (211,6)-(211,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,7)-(211,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (212,1)-(212,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (212,6)-(212,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (212,7)-(212,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (213,1)-(213,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (213,6)-(213,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,7)-(213,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (214,1)-(214,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (214,6)-(214,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,7)-(214,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (216,1)-(216,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (216,10)-(216,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,12)-(216,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (216,33)-(216,38) 25 "SymbolGenerator.mxg"
            __cb.Write(".Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (217,1)-(217,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (218,5)-(218,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (218,10)-(218,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (218,11)-(218,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (218,18)-(218,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (218,19)-(218,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (218,20)-(218,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (218,21)-(218,45) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.Model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (219,5)-(219,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (219,10)-(219,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,11)-(219,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (219,25)-(219,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,26)-(219,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (219,27)-(219,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,28)-(219,59) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (220,5)-(220,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (220,10)-(220,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,11)-(220,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (220,20)-(220,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,21)-(220,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (220,22)-(220,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,23)-(220,54) 25 "SymbolGenerator.mxg"
            __cb.Write("Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (222,5)-(222,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (222,11)-(222,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,12)-(222,17) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (222,17)-(222,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,19)-(222,46) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (222,47)-(222,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,48)-(222,49) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (222,49)-(222,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,51)-(222,78) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (223,5)-(223,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (224,9)-(224,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (224,15)-(224,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,17)-(224,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (224,45)-(224,53) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol?");
            #line hidden
            #line (224,53)-(224,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,54)-(224,64) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (224,64)-(224,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,65)-(224,77) 25 "SymbolGenerator.mxg"
            __cb.Write("Compilation?");
            #line hidden
            #line (224,77)-(224,78) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,78)-(224,89) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation");
            #line hidden
            #line (224,89)-(224,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,90)-(224,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (224,91)-(224,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,92)-(224,97) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (224,97)-(224,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,98)-(224,116) 25 "SymbolGenerator.mxg"
            __cb.Write("MergedDeclaration?");
            #line hidden
            #line (224,116)-(224,117) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,117)-(224,128) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration");
            #line hidden
            #line (224,128)-(224,129) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,129)-(224,130) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (224,130)-(224,131) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,131)-(224,136) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (224,136)-(224,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,137)-(224,145) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model?");
            #line hidden
            #line (224,145)-(224,146) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,146)-(224,151) 25 "SymbolGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (224,151)-(224,152) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,152)-(224,153) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (224,153)-(224,154) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,154)-(224,159) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (224,159)-(224,160) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,160)-(224,175) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (224,175)-(224,176) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,176)-(224,187) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (224,187)-(224,188) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,188)-(224,189) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (224,189)-(224,190) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,190)-(224,195) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (224,195)-(224,196) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,196)-(224,205) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (224,205)-(224,206) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,206)-(224,218) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol");
            #line hidden
            #line (224,218)-(224,219) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,219)-(224,220) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (224,220)-(224,221) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,221)-(224,226) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (224,226)-(224,227) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,227)-(224,243) 25 "SymbolGenerator.mxg"
            __cb.Write("ErrorSymbolInfo?");
            #line hidden
            #line (224,243)-(224,244) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,244)-(224,253) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo");
            #line hidden
            #line (224,253)-(224,254) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,254)-(224,255) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (224,255)-(224,256) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,256)-(224,261) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (224,261)-(224,262) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,262)-(224,266) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (224,266)-(224,267) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,267)-(224,278) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol");
            #line hidden
            #line (224,278)-(224,279) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,279)-(224,280) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (224,280)-(224,281) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,281)-(224,287) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (224,287)-(224,288) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,288)-(224,295) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (224,295)-(224,296) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,296)-(224,300) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (224,300)-(224,301) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,301)-(224,302) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (224,302)-(224,303) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,303)-(224,311) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (224,311)-(224,312) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,312)-(224,319) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (224,319)-(224,320) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,320)-(224,332) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (224,332)-(224,333) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,333)-(224,334) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (224,334)-(224,335) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,335)-(224,343) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (224,343)-(224,344) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,344)-(224,412) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>");
            #line hidden
            #line (224,412)-(224,413) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,413)-(224,423) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (224,423)-(224,424) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,424)-(224,425) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (224,425)-(224,426) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,426)-(224,433) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first34 = true;
            #line (224,434)-(224,502) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                #line (224,503)-(224,504) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (224,504)-(224,505) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (224,506)-(224,536) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (224,537)-(224,538) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (224,539)-(224,557) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (224,558)-(224,559) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (224,559)-(224,560) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (224,560)-(224,561) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (224,562)-(224,596) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (224,610)-(224,611) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (224,611)-(224,612) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (225,13)-(225,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (225,14)-(225,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,15)-(225,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (225,30)-(225,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,31)-(225,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (225,43)-(225,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,44)-(225,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (225,56)-(225,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,57)-(225,63) 25 "SymbolGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (225,63)-(225,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,64)-(225,76) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (225,76)-(225,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,77)-(225,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (225,90)-(225,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,91)-(225,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (225,101)-(225,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,102)-(225,114) 25 "SymbolGenerator.mxg"
            __cb.Write("fixedSymbol,");
            #line hidden
            #line (225,114)-(225,115) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,115)-(225,120) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (225,120)-(225,121) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,121)-(225,134) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (225,134)-(225,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,135)-(225,145) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first35 = true;
            #line (225,146)-(225,218) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first35)
                {
                    __first35 = false;
                }
                #line (225,219)-(225,220) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (225,220)-(225,221) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (225,222)-(225,240) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (225,241)-(225,242) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (225,242)-(225,243) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (225,244)-(225,262) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (225,276)-(225,277) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (226,9)-(226,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (227,9)-(227,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (229,5)-(229,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (230,1)-(230,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (233,9)-(233,71) 22 "SymbolGenerator.mxg"
        public string AssignProperty(Symbol symbol, Property prop, string variable)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first36 = true;
            #line (234,6)-(234,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                var __first37 = true;
                #line (235,10)-(235,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first37)
                    {
                        __first37 = false;
                    }
                    __cb.Push("");
                    #line (236,13)-(236,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (236,15)-(236,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (236,16)-(236,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("(!");
                    #line hidden
                    #line (236,19)-(236,27) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (236,28)-(236,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(".IsDefaultOrEmpty)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (237,13)-(237,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (238,18)-(238,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (238,37)-(238,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (238,47)-(238,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (238,49)-(238,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (238,58)-(238,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (239,13)-(239,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (240,10)-(240,14) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first37)
                    {
                        __first37 = false;
                    }
                    __cb.Push("");
                    #line (241,13)-(241,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (241,15)-(241,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (241,16)-(241,17) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (241,18)-(241,26) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (241,27)-(241,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (241,28)-(241,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (241,30)-(241,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (241,32)-(241,61) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (241,62)-(241,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (242,13)-(242,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (243,18)-(243,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (243,37)-(243,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (243,47)-(243,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (243,49)-(243,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (243,58)-(243,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (244,13)-(244,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first37) __cb.AppendLine();
            }
            #line (246,6)-(246,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("");
                #line (247,10)-(247,28) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (247,29)-(247,30) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (247,30)-(247,31) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (247,31)-(247,32) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (247,33)-(247,41) 28 "SymbolGenerator.mxg"
                __cb.Write(variable);
                #line hidden
                #line (247,42)-(247,43) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first36) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}