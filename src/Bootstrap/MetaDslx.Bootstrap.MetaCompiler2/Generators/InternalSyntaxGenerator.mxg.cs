#line (1,10)-(1,54) 10 "InternalSyntaxGenerator.mxg"
namespace MetaDslx.Bootstrap.MetaCompiler2.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "InternalSyntaxGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,45) 13 "InternalSyntaxGenerator.mxg"
    MetaDslx.Bootstrap.MetaCompiler2.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "InternalSyntaxGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "InternalSyntaxGenerator.mxg"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "InternalSyntaxGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "InternalSyntaxGenerator.mxg"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "InternalSyntaxGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,18) 13 "InternalSyntaxGenerator.mxg"
    System.Linq;
    #line hidden
    
    #line (8,10)-(8,29) 25 "InternalSyntaxGenerator.mxg"
    public partial class RoslynApiGenerator
    #line hidden
    {
        #line (10,9)-(10,34) 22 "InternalSyntaxGenerator.mxg"
        public string GenerateInternalSyntax()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (11,1)-(11,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (11,10)-(11,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,11)-(11,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (13,10)-(13,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,12)-(13,21) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (13,22)-(13,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Syntax.InternalSyntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,2) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (15,2)-(15,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (15,7)-(15,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,8)-(15,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Debug");
            #line hidden
            #line (15,15)-(15,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,16)-(15,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (15,17)-(15,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,18)-(15,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("System.Diagnostics.Debug;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (16,2)-(16,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (16,7)-(16,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,8)-(16,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Language");
            #line hidden
            #line (16,18)-(16,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,19)-(16,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (16,20)-(16,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,21)-(16,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Language;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (17,2)-(17,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (17,7)-(17,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,8)-(17,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (17,24)-(17,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,25)-(17,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (17,26)-(17,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,27)-(17,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticInfo;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (18,2)-(18,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (18,7)-(18,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,8)-(18,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (18,26)-(18,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,27)-(18,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (18,28)-(18,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,29)-(18,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SyntaxAnnotation;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (19,2)-(19,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (19,7)-(19,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,8)-(19,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (19,19)-(19,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,20)-(19,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (19,21)-(19,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,22)-(19,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.GreenNode;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (20,2)-(20,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (20,7)-(20,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,8)-(20,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxKind");
            #line hidden
            #line (20,28)-(20,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,29)-(20,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (20,30)-(20,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,31)-(20,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxKind;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (21,2)-(21,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (21,7)-(21,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,8)-(21,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (21,29)-(21,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,30)-(21,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (21,31)-(21,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,32)-(21,104) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxToken;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (22,2)-(22,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (22,7)-(22,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,8)-(22,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxTrivia");
            #line hidden
            #line (22,30)-(22,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,31)-(22,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (22,32)-(22,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,33)-(22,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxTrivia;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (23,2)-(23,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (23,7)-(23,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,8)-(23,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (23,28)-(23,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,29)-(23,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (23,30)-(23,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,31)-(23,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxNode;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (24,2)-(24,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (24,7)-(24,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,8)-(24,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxToken");
            #line hidden
            #line (24,21)-(24,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,22)-(24,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (24,23)-(24,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,24)-(24,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SyntaxToken;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (25,2)-(25,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (25,7)-(25,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,8)-(25,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxTrivia");
            #line hidden
            #line (25,22)-(25,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,23)-(25,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (25,24)-(25,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,25)-(25,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SyntaxTrivia;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (26,2)-(26,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (26,7)-(26,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,8)-(26,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxNode");
            #line hidden
            #line (26,20)-(26,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,21)-(26,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (26,22)-(26,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,23)-(26,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SyntaxNode;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (27,2)-(27,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (27,7)-(27,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,8)-(27,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__ArgumentNullException");
            #line hidden
            #line (27,31)-(27,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,32)-(27,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (27,33)-(27,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,34)-(27,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.ArgumentNullException;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (28,5)-(28,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (28,10)-(28,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,11)-(28,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__ArgumentException");
            #line hidden
            #line (28,30)-(28,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,31)-(28,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (28,32)-(28,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,33)-(28,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.ArgumentException;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (30,5)-(30,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (30,13)-(30,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,14)-(30,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (30,22)-(30,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,23)-(30,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (30,28)-(30,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,29)-(30,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxNode");
            #line hidden
            #line (30,44)-(30,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,45)-(30,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (30,46)-(30,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,47)-(30,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (31,5)-(31,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (32,9)-(32,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (32,18)-(32,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,19)-(32,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxNode(");
            #line hidden
            #line (32,36)-(32,40) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (32,41)-(32,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (32,51)-(32,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,52)-(32,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (33,13)-(33,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (33,14)-(33,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,15)-(33,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (34,9)-(34,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (35,9)-(35,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (37,9)-(37,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (37,18)-(37,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,19)-(37,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxNode(");
            #line hidden
            #line (37,36)-(37,40) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (37,41)-(37,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (37,51)-(37,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,52)-(37,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (37,57)-(37,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,58)-(37,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (37,61)-(37,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,62)-(37,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("fullWidth)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (38,13)-(38,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (38,14)-(38,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,15)-(38,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind,");
            #line hidden
            #line (38,33)-(38,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,34)-(38,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("fullWidth)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (39,9)-(39,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (40,9)-(40,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (42,9)-(42,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (42,18)-(42,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,19)-(42,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxNode(");
            #line hidden
            #line (42,36)-(42,40) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (42,41)-(42,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (42,51)-(42,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,52)-(42,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (42,57)-(42,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,58)-(42,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (42,75)-(42,79) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (42,80)-(42,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,81)-(42,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (43,13)-(43,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (43,14)-(43,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,15)-(43,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind,");
            #line hidden
            #line (43,33)-(43,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,34)-(43,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (44,9)-(44,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (45,9)-(45,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (47,9)-(47,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (47,18)-(47,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,19)-(47,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxNode(");
            #line hidden
            #line (47,36)-(47,40) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (47,41)-(47,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (47,51)-(47,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,52)-(47,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (47,57)-(47,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,58)-(47,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (47,75)-(47,79) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (47,80)-(47,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,81)-(47,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (47,93)-(47,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,94)-(47,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (47,97)-(47,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,98)-(47,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("fullWidth)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (48,13)-(48,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (48,14)-(48,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,15)-(48,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind,");
            #line hidden
            #line (48,33)-(48,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,34)-(48,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (48,46)-(48,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,47)-(48,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("fullWidth)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (49,9)-(49,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (50,9)-(50,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (52,9)-(52,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (52,18)-(52,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,19)-(52,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxNode(");
            #line hidden
            #line (52,36)-(52,40) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (52,41)-(52,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (52,51)-(52,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,52)-(52,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (52,57)-(52,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,58)-(52,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (52,75)-(52,79) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (52,80)-(52,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,81)-(52,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (52,93)-(52,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,94)-(52,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (52,113)-(52,117) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (52,118)-(52,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,119)-(52,131) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (53,13)-(53,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (53,14)-(53,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,15)-(53,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind,");
            #line hidden
            #line (53,33)-(53,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,34)-(53,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (53,46)-(53,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,47)-(53,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (54,9)-(54,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (55,9)-(55,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (57,9)-(57,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (57,18)-(57,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,19)-(57,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxNode(");
            #line hidden
            #line (57,36)-(57,40) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (57,41)-(57,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (57,51)-(57,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,52)-(57,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (57,57)-(57,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,58)-(57,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (57,75)-(57,79) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (57,80)-(57,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,81)-(57,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (57,93)-(57,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,94)-(57,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (57,113)-(57,117) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (57,118)-(57,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,119)-(57,131) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations,");
            #line hidden
            #line (57,131)-(57,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,132)-(57,135) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (57,135)-(57,136) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,136)-(57,146) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("fullWidth)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (58,13)-(58,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (58,14)-(58,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,15)-(58,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind,");
            #line hidden
            #line (58,33)-(58,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,34)-(58,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (58,46)-(58,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,47)-(58,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations,");
            #line hidden
            #line (58,59)-(58,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,60)-(58,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("fullWidth)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (59,9)-(59,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (60,9)-(60,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (62,9)-(62,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (62,15)-(62,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,16)-(62,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (62,24)-(62,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,25)-(62,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TResult");
            #line hidden
            #line (62,32)-(62,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,33)-(62,131) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Accept<TResult>(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor<TResult>");
            #line hidden
            #line (62,131)-(62,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,132)-(62,140) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (63,9)-(63,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (64,13)-(64,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (64,15)-(64,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,16)-(64,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(visitor");
            #line hidden
            #line (64,24)-(64,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,25)-(64,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (64,27)-(64,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,29)-(64,33) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (64,34)-(64,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxVisitor<TResult>");
            #line hidden
            #line (64,64)-(64,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,65)-(64,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("typedVisitor)");
            #line hidden
            #line (64,78)-(64,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,79)-(64,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (64,85)-(64,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,86)-(64,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.Accept(typedVisitor);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (65,13)-(65,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("else");
            #line hidden
            #line (65,17)-(65,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,18)-(65,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (65,24)-(65,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,25)-(65,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor.DefaultVisit(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (66,9)-(66,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (68,9)-(68,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (68,15)-(68,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,16)-(68,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (68,24)-(68,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,25)-(68,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (68,29)-(68,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,30)-(68,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Accept(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor");
            #line hidden
            #line (68,110)-(68,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,111)-(68,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor)");
            #line hidden
            #line (68,119)-(68,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (69,9)-(69,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (70,13)-(70,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (70,15)-(70,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,16)-(70,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(visitor");
            #line hidden
            #line (70,24)-(70,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,25)-(70,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (70,27)-(70,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,29)-(70,33) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (70,34)-(70,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxVisitor");
            #line hidden
            #line (70,55)-(70,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,56)-(70,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("typedVisitor)");
            #line hidden
            #line (70,69)-(70,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,70)-(70,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.Accept(typedVisitor);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (71,13)-(71,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("else");
            #line hidden
            #line (71,17)-(71,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,18)-(71,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor.DefaultVisit(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (72,9)-(72,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (74,9)-(74,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (74,15)-(74,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,16)-(74,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (74,24)-(74,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,25)-(74,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TResult");
            #line hidden
            #line (74,32)-(74,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,33)-(74,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Accept<TResult>(");
            #line hidden
            #line (74,50)-(74,54) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (74,55)-(74,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxVisitor<TResult>");
            #line hidden
            #line (74,85)-(74,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,86)-(74,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (75,9)-(75,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (75,15)-(75,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,16)-(75,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (75,24)-(75,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,25)-(75,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (75,29)-(75,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,30)-(75,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Accept(");
            #line hidden
            #line (75,38)-(75,42) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (75,43)-(75,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxVisitor");
            #line hidden
            #line (75,64)-(75,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,65)-(75,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (77,9)-(77,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (77,15)-(77,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,16)-(77,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (77,24)-(77,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,25)-(77,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Language");
            #line hidden
            #line (77,35)-(77,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,36)-(77,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language");
            #line hidden
            #line (77,44)-(77,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,45)-(77,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (77,47)-(77,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,49)-(77,53) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (77,54)-(77,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (78,9)-(78,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (78,15)-(78,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,17)-(78,21) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (78,22)-(78,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (78,32)-(78,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,33)-(78,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Kind");
            #line hidden
            #line (78,37)-(78,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,38)-(78,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (78,40)-(78,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,41)-(78,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (78,43)-(78,47) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (78,48)-(78,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)this.RawKind;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (79,3)-(79,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (79,9)-(79,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,10)-(79,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (79,18)-(79,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,19)-(79,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (79,25)-(79,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,26)-(79,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("KindText");
            #line hidden
            #line (79,34)-(79,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,35)-(79,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (79,37)-(79,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,39)-(79,43) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (79,44)-(79,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.SyntaxFacts.GetKindText(Kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (81,3)-(81,5) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (81,5)-(81,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,6)-(81,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Use");
            #line hidden
            #line (81,9)-(81,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,10)-(81,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("conditional");
            #line hidden
            #line (81,21)-(81,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,22)-(81,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("weak");
            #line hidden
            #line (81,26)-(81,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,27)-(81,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("table");
            #line hidden
            #line (81,32)-(81,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,33)-(81,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("so");
            #line hidden
            #line (81,35)-(81,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,36)-(81,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("we");
            #line hidden
            #line (81,38)-(81,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,39)-(81,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("always");
            #line hidden
            #line (81,45)-(81,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,46)-(81,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (81,52)-(81,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,53)-(81,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("same");
            #line hidden
            #line (81,57)-(81,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,58)-(81,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("identity");
            #line hidden
            #line (81,66)-(81,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,67)-(81,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (81,70)-(81,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,71)-(81,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structured");
            #line hidden
            #line (81,81)-(81,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,82)-(81,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (82,3)-(82,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (82,10)-(82,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,11)-(82,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (82,17)-(82,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,18)-(82,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (82,26)-(82,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,27)-(82,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.Runtime.CompilerServices.ConditionalWeakTable<__SyntaxNode,");
            #line hidden
            #line (82,101)-(82,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,102)-(82,163) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.Collections.Generic.Dictionary<__SyntaxTrivia,");
            #line hidden
            #line (82,163)-(82,164) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,164)-(82,178) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxNode>>");
            #line hidden
            #line (82,178)-(82,179) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,179)-(82,196) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_structuresTable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (83,4)-(83,5) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (83,5)-(83,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,6)-(83,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (83,9)-(83,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,10)-(83,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.Runtime.CompilerServices.ConditionalWeakTable<__SyntaxNode,");
            #line hidden
            #line (83,84)-(83,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,85)-(83,146) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.Collections.Generic.Dictionary<__SyntaxTrivia,");
            #line hidden
            #line (83,146)-(83,147) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,147)-(83,164) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxNode>>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (85,3)-(85,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (85,6)-(85,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,7)-(85,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (86,3)-(86,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (86,6)-(86,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,7)-(86,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Gets");
            #line hidden
            #line (86,11)-(86,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,12)-(86,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (86,15)-(86,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,16)-(86,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("syntax");
            #line hidden
            #line (86,22)-(86,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,23)-(86,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("node");
            #line hidden
            #line (86,27)-(86,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,28)-(86,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("represented");
            #line hidden
            #line (86,39)-(86,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,40)-(86,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (86,43)-(86,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,44)-(86,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure");
            #line hidden
            #line (86,53)-(86,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,54)-(86,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("of");
            #line hidden
            #line (86,56)-(86,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,57)-(86,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this");
            #line hidden
            #line (86,61)-(86,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,62)-(86,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (86,69)-(86,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,70)-(86,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (86,72)-(86,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,73)-(86,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("any.");
            #line hidden
            #line (86,77)-(86,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,78)-(86,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("The");
            #line hidden
            #line (86,81)-(86,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,82)-(86,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("HasStructure");
            #line hidden
            #line (86,94)-(86,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,95)-(86,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("property");
            #line hidden
            #line (86,103)-(86,104) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,104)-(86,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("can");
            #line hidden
            #line (86,107)-(86,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,108)-(86,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("be");
            #line hidden
            #line (86,110)-(86,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,111)-(86,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("used");
            #line hidden
            #line (86,115)-(86,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,116)-(86,118) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("to");
            #line hidden
            #line (86,118)-(86,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (87,3)-(87,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (87,6)-(87,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,7)-(87,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("determine");
            #line hidden
            #line (87,16)-(87,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,17)-(87,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (87,19)-(87,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,20)-(87,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this");
            #line hidden
            #line (87,24)-(87,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,25)-(87,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia");
            #line hidden
            #line (87,31)-(87,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,32)-(87,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("has");
            #line hidden
            #line (87,35)-(87,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,36)-(87,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (88,3)-(88,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (88,6)-(88,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,7)-(88,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (89,3)-(89,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (89,6)-(89,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,7)-(89,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("<returns>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (90,3)-(90,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (90,6)-(90,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,7)-(90,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("A");
            #line hidden
            #line (90,8)-(90,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,10)-(90,14) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (90,15)-(90,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxNode");
            #line hidden
            #line (90,25)-(90,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,26)-(90,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("derived");
            #line hidden
            #line (90,33)-(90,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,34)-(90,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("from");
            #line hidden
            #line (90,38)-(90,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,39)-(90,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("StructuredTriviaSyntax,");
            #line hidden
            #line (90,62)-(90,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,63)-(90,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("with");
            #line hidden
            #line (90,67)-(90,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,68)-(90,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (90,71)-(90,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,72)-(90,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structured");
            #line hidden
            #line (90,82)-(90,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,83)-(90,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("view");
            #line hidden
            #line (90,87)-(90,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,88)-(90,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("of");
            #line hidden
            #line (90,90)-(90,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,91)-(90,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this");
            #line hidden
            #line (90,95)-(90,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,96)-(90,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia");
            #line hidden
            #line (90,102)-(90,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,103)-(90,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (90,108)-(90,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (91,3)-(91,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (91,6)-(91,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,7)-(91,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("If");
            #line hidden
            #line (91,9)-(91,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,10)-(91,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this");
            #line hidden
            #line (91,14)-(91,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,15)-(91,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia");
            #line hidden
            #line (91,21)-(91,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,22)-(91,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("node");
            #line hidden
            #line (91,26)-(91,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,27)-(91,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("does");
            #line hidden
            #line (91,31)-(91,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,32)-(91,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (91,35)-(91,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,36)-(91,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("have");
            #line hidden
            #line (91,40)-(91,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,41)-(91,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure,");
            #line hidden
            #line (91,51)-(91,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,52)-(91,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("returns");
            #line hidden
            #line (91,59)-(91,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,60)-(91,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (92,3)-(92,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (92,6)-(92,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,7)-(92,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("</returns>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (93,3)-(93,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (93,6)-(93,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,7)-(93,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("<remarks>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (94,3)-(94,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (94,6)-(94,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,7)-(94,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Some");
            #line hidden
            #line (94,11)-(94,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,12)-(94,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("types");
            #line hidden
            #line (94,17)-(94,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,18)-(94,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("of");
            #line hidden
            #line (94,20)-(94,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,21)-(94,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia");
            #line hidden
            #line (94,27)-(94,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,28)-(94,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("have");
            #line hidden
            #line (94,32)-(94,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,33)-(94,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure");
            #line hidden
            #line (94,42)-(94,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,43)-(94,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("that");
            #line hidden
            #line (94,47)-(94,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,48)-(94,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("can");
            #line hidden
            #line (94,51)-(94,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,52)-(94,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("be");
            #line hidden
            #line (94,54)-(94,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,55)-(94,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("accessed");
            #line hidden
            #line (94,63)-(94,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,64)-(94,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("as");
            #line hidden
            #line (94,66)-(94,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,67)-(94,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("additional");
            #line hidden
            #line (94,77)-(94,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,78)-(94,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("syntax");
            #line hidden
            #line (94,84)-(94,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,85)-(94,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("nodes.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (95,3)-(95,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (95,6)-(95,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,7)-(95,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("These");
            #line hidden
            #line (95,12)-(95,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,13)-(95,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("forms");
            #line hidden
            #line (95,18)-(95,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,19)-(95,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("of");
            #line hidden
            #line (95,21)-(95,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,22)-(95,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia");
            #line hidden
            #line (95,28)-(95,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,29)-(95,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("include:");
            #line hidden
            #line (95,37)-(95,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (96,3)-(96,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (96,6)-(96,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("   ");
            #line hidden
            #line (96,9)-(96,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("directives,");
            #line hidden
            #line (96,20)-(96,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,21)-(96,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("where");
            #line hidden
            #line (96,26)-(96,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,27)-(96,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (96,30)-(96,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,31)-(96,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure");
            #line hidden
            #line (96,40)-(96,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,41)-(96,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("describes");
            #line hidden
            #line (96,50)-(96,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,51)-(96,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (96,54)-(96,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,55)-(96,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure");
            #line hidden
            #line (96,64)-(96,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,65)-(96,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("of");
            #line hidden
            #line (96,67)-(96,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,68)-(96,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (96,71)-(96,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,72)-(96,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("directive.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (97,3)-(97,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (97,6)-(97,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("   ");
            #line hidden
            #line (97,9)-(97,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("documentation");
            #line hidden
            #line (97,22)-(97,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,23)-(97,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("comments,");
            #line hidden
            #line (97,32)-(97,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,33)-(97,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("where");
            #line hidden
            #line (97,38)-(97,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,39)-(97,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (97,42)-(97,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,43)-(97,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure");
            #line hidden
            #line (97,52)-(97,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,53)-(97,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("describes");
            #line hidden
            #line (97,62)-(97,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,63)-(97,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (97,66)-(97,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,67)-(97,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("XML");
            #line hidden
            #line (97,70)-(97,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,71)-(97,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure");
            #line hidden
            #line (97,80)-(97,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,81)-(97,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("of");
            #line hidden
            #line (97,83)-(97,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,84)-(97,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (97,87)-(97,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,88)-(97,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("comment.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (98,3)-(98,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (98,6)-(98,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("   ");
            #line hidden
            #line (98,9)-(98,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("skipped");
            #line hidden
            #line (98,16)-(98,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,17)-(98,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("tokens,");
            #line hidden
            #line (98,24)-(98,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,25)-(98,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("where");
            #line hidden
            #line (98,30)-(98,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,31)-(98,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (98,34)-(98,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,35)-(98,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure");
            #line hidden
            #line (98,44)-(98,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,45)-(98,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("describes");
            #line hidden
            #line (98,54)-(98,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,55)-(98,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (98,58)-(98,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,59)-(98,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("tokens");
            #line hidden
            #line (98,65)-(98,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,66)-(98,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("that");
            #line hidden
            #line (98,70)-(98,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,71)-(98,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("were");
            #line hidden
            #line (98,75)-(98,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,76)-(98,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("skipped");
            #line hidden
            #line (98,83)-(98,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,84)-(98,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("by");
            #line hidden
            #line (98,86)-(98,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,87)-(98,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (98,90)-(98,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,91)-(98,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("parser.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (99,3)-(99,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (99,6)-(99,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,7)-(99,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("</remarks>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (100,3)-(100,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (100,9)-(100,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,10)-(100,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (100,18)-(100,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,19)-(100,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxNode");
            #line hidden
            #line (100,31)-(100,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,32)-(100,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetStructure(__SyntaxTrivia");
            #line hidden
            #line (100,59)-(100,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,60)-(100,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (101,3)-(101,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (102,4)-(102,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (102,6)-(102,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,7)-(102,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trivia.HasStructure)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (103,4)-(103,5) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (104,5)-(104,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (104,8)-(104,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,9)-(104,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("parent");
            #line hidden
            #line (104,15)-(104,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,16)-(104,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (104,17)-(104,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,18)-(104,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia.Token.Parent;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (105,5)-(105,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (105,7)-(105,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,8)-(105,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(parent");
            #line hidden
            #line (105,15)-(105,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,16)-(105,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (105,18)-(105,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,19)-(105,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (106,5)-(106,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (107,6)-(107,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxNode");
            #line hidden
            #line (107,18)-(107,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,19)-(107,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (108,6)-(108,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (108,9)-(108,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,10)-(108,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structsInParent");
            #line hidden
            #line (108,25)-(108,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,26)-(108,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (108,27)-(108,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,28)-(108,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_structuresTable.GetOrCreateValue(parent);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (109,6)-(109,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("lock");
            #line hidden
            #line (109,10)-(109,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,11)-(109,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(structsInParent)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (110,6)-(110,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t\t");
            #line (111,7)-(111,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (111,9)-(111,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,10)-(111,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(!structsInParent.TryGetValue(trivia,");
            #line hidden
            #line (111,47)-(111,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,48)-(111,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("out");
            #line hidden
            #line (111,51)-(111,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,52)-(111,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure))");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t\t");
            #line (112,7)-(112,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t\t\t");
            #line (113,8)-(113,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure");
            #line hidden
            #line (113,17)-(113,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,18)-(113,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (113,19)-(113,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,21)-(113,25) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (113,26)-(113,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("StructuredTriviaSyntax.Create(trivia);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t\t\t");
            #line (114,8)-(114,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structsInParent.Add(trivia,");
            #line hidden
            #line (114,35)-(114,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,36)-(114,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t\t");
            #line (115,7)-(115,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (116,6)-(116,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (118,6)-(118,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (118,12)-(118,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (118,13)-(118,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("structure;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (119,5)-(119,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (120,5)-(120,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("else");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (121,5)-(121,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (122,6)-(122,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (122,12)-(122,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,14)-(122,18) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (122,19)-(122,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("StructuredTriviaSyntax.Create(trivia);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (123,5)-(123,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (124,4)-(124,5) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (126,4)-(126,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (126,10)-(126,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,11)-(126,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (127,3)-(127,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (129,2)-(129,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (131,5)-(131,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (131,13)-(131,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,14)-(131,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (131,19)-(131,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,20)-(131,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxTrivia");
            #line hidden
            #line (131,37)-(131,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,38)-(131,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (131,39)-(131,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,40)-(131,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxTrivia");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (132,5)-(132,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (133,9)-(133,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (133,17)-(133,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,18)-(133,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxTrivia(");
            #line hidden
            #line (133,37)-(133,41) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (133,42)-(133,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (133,52)-(133,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,53)-(133,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (133,58)-(133,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,59)-(133,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (133,65)-(133,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,66)-(133,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (133,71)-(133,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,72)-(133,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (133,89)-(133,93) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (133,94)-(133,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,95)-(133,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics");
            #line hidden
            #line (133,106)-(133,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,107)-(133,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (133,108)-(133,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,109)-(133,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (133,114)-(133,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,115)-(133,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (133,134)-(133,138) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (133,139)-(133,140) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,140)-(133,151) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations");
            #line hidden
            #line (133,151)-(133,152) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,152)-(133,153) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (133,153)-(133,154) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,154)-(133,159) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (134,13)-(134,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (134,14)-(134,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,15)-(134,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind,");
            #line hidden
            #line (134,33)-(134,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,34)-(134,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (134,39)-(134,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,40)-(134,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (134,52)-(134,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,53)-(134,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (135,9)-(135,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (136,9)-(136,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (138,3)-(138,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (138,9)-(138,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,10)-(138,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (138,18)-(138,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,19)-(138,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Language");
            #line hidden
            #line (138,29)-(138,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,30)-(138,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language");
            #line hidden
            #line (138,38)-(138,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,39)-(138,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (138,41)-(138,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,43)-(138,47) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (138,48)-(138,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (139,3)-(139,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (139,9)-(139,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,11)-(139,15) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (139,16)-(139,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (139,26)-(139,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,27)-(139,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Kind");
            #line hidden
            #line (139,31)-(139,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,32)-(139,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (139,34)-(139,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,35)-(139,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (139,37)-(139,41) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (139,42)-(139,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)this.RawKind;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (140,3)-(140,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (140,9)-(140,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (140,10)-(140,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (140,18)-(140,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (140,19)-(140,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (140,25)-(140,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (140,26)-(140,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("KindText");
            #line hidden
            #line (140,34)-(140,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (140,35)-(140,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (140,37)-(140,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (140,39)-(140,43) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (140,44)-(140,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.SyntaxFacts.GetKindText(Kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (142,3)-(142,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (142,11)-(142,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,12)-(142,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (142,18)-(142,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,19)-(142,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxTrivia");
            #line hidden
            #line (142,36)-(142,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,37)-(142,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Create(");
            #line hidden
            #line (142,45)-(142,49) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (142,50)-(142,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (142,60)-(142,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,61)-(142,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (142,66)-(142,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,67)-(142,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (142,73)-(142,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,74)-(142,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (143,9)-(143,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (144,13)-(144,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (144,19)-(144,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (144,20)-(144,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (144,23)-(144,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (144,24)-(144,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxTrivia(kind,");
            #line hidden
            #line (144,47)-(144,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (144,48)-(144,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (145,9)-(145,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (147,9)-(147,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (147,15)-(147,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,16)-(147,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (147,24)-(147,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,25)-(147,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (147,45)-(147,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,46)-(147,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithDiagnostics(__DiagnosticInfo");
            #line hidden
            #line (147,79)-(147,83) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (147,84)-(147,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,85)-(147,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (148,9)-(148,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (149,13)-(149,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (149,19)-(149,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,20)-(149,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (149,23)-(149,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,24)-(149,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxTrivia(this.Kind,");
            #line hidden
            #line (149,52)-(149,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,53)-(149,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.Text,");
            #line hidden
            #line (149,63)-(149,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,64)-(149,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (149,76)-(149,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,77)-(149,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (150,9)-(150,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (152,9)-(152,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (152,15)-(152,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,16)-(152,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (152,24)-(152,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,25)-(152,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (152,45)-(152,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,46)-(152,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithAnnotations(__SyntaxAnnotation");
            #line hidden
            #line (152,81)-(152,85) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (152,86)-(152,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,87)-(152,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (153,9)-(153,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (154,13)-(154,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (154,19)-(154,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,20)-(154,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (154,23)-(154,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,24)-(154,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxTrivia(this.Kind,");
            #line hidden
            #line (154,52)-(154,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,53)-(154,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.Text,");
            #line hidden
            #line (154,63)-(154,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,64)-(154,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetDiagnostics(),");
            #line hidden
            #line (154,81)-(154,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,82)-(154,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (155,9)-(155,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (157,9)-(157,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (157,15)-(157,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,16)-(157,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (157,24)-(157,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,25)-(157,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (157,36)-(157,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,37)-(157,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Clone()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (158,9)-(158,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (159,4)-(159,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (159,10)-(159,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,11)-(159,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (159,14)-(159,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,15)-(159,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxTrivia(this.Kind,");
            #line hidden
            #line (159,43)-(159,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,44)-(159,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.Text,");
            #line hidden
            #line (159,54)-(159,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,55)-(159,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetDiagnostics(),");
            #line hidden
            #line (159,72)-(159,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,73)-(159,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (160,3)-(160,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (162,9)-(162,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (162,15)-(162,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,16)-(162,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (162,22)-(162,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,23)-(162,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("implicit");
            #line hidden
            #line (162,31)-(162,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,32)-(162,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("operator");
            #line hidden
            #line (162,40)-(162,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,41)-(162,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxTrivia(GreenSyntaxTrivia");
            #line hidden
            #line (162,73)-(162,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,74)-(162,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (163,9)-(163,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (164,13)-(164,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (164,19)-(164,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,20)-(164,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (164,23)-(164,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,24)-(164,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxTrivia(default,");
            #line hidden
            #line (164,47)-(164,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,48)-(164,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (164,55)-(164,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,56)-(164,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("position:");
            #line hidden
            #line (164,65)-(164,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,66)-(164,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("0,");
            #line hidden
            #line (164,68)-(164,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,69)-(164,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("index:");
            #line hidden
            #line (164,75)-(164,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,76)-(164,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("0);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (165,9)-(165,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (166,5)-(166,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (168,5)-(168,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (168,13)-(168,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,14)-(168,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (168,22)-(168,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,23)-(168,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (168,28)-(168,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,29)-(168,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenStructuredTriviaSyntax");
            #line hidden
            #line (168,56)-(168,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,57)-(168,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (168,58)-(168,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,59)-(168,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxNode");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (169,5)-(169,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (170,9)-(170,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (170,17)-(170,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,18)-(170,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenStructuredTriviaSyntax(");
            #line hidden
            #line (170,47)-(170,51) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (170,52)-(170,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (170,62)-(170,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,63)-(170,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (170,68)-(170,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,69)-(170,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (170,86)-(170,90) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (170,91)-(170,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,92)-(170,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics");
            #line hidden
            #line (170,103)-(170,104) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,104)-(170,105) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (170,105)-(170,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,106)-(170,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (170,111)-(170,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,112)-(170,130) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (170,131)-(170,135) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (170,136)-(170,137) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,137)-(170,148) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations");
            #line hidden
            #line (170,148)-(170,149) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,149)-(170,150) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (170,150)-(170,151) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,151)-(170,156) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (171,13)-(171,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (171,14)-(171,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,15)-(171,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (171,25)-(171,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,26)-(171,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (171,38)-(171,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,39)-(171,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (172,9)-(172,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (173,13)-(173,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.Initialize();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (174,9)-(174,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (176,9)-(176,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (176,16)-(176,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (176,17)-(176,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (176,21)-(176,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (176,22)-(176,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Initialize()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (177,9)-(177,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (178,13)-(178,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.flags");
            #line hidden
            #line (178,23)-(178,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (178,24)-(178,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("|=");
            #line hidden
            #line (178,26)-(178,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (178,27)-(178,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("NodeFlags.ContainsStructuredTrivia;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (180,13)-(180,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (180,15)-(180,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,16)-(180,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(this.RawKind");
            #line hidden
            #line (180,29)-(180,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,30)-(180,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (180,32)-(180,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,33)-(180,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)__InternalSyntaxKind.SkippedTokensTrivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (181,13)-(181,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (182,17)-(182,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.flags");
            #line hidden
            #line (182,27)-(182,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (182,28)-(182,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("|=");
            #line hidden
            #line (182,30)-(182,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (182,31)-(182,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("NodeFlags.ContainsSkippedText;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (183,13)-(183,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (184,9)-(184,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (186,9)-(186,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (186,15)-(186,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (186,16)-(186,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (186,24)-(186,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (186,25)-(186,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (186,29)-(186,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (186,30)-(186,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("IsStructuredTrivia");
            #line hidden
            #line (186,48)-(186,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (186,49)-(186,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (186,51)-(186,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (186,52)-(186,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (187,5)-(187,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (189,5)-(189,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (189,13)-(189,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,14)-(189,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("sealed");
            #line hidden
            #line (189,20)-(189,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,21)-(189,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (189,28)-(189,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,29)-(189,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (189,34)-(189,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,35)-(189,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSkippedTokensTriviaSyntax");
            #line hidden
            #line (189,65)-(189,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,66)-(189,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (189,67)-(189,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,68)-(189,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenStructuredTriviaSyntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (190,5)-(190,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (191,9)-(191,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (191,17)-(191,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,18)-(191,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (191,26)-(191,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,27)-(191,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (191,38)-(191,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,39)-(191,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("tokens;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (193,9)-(193,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (193,17)-(193,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,18)-(193,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSkippedTokensTriviaSyntax(");
            #line hidden
            #line (193,50)-(193,54) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (193,55)-(193,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (193,65)-(193,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,66)-(193,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (193,71)-(193,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,72)-(193,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (193,83)-(193,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,84)-(193,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("tokens,");
            #line hidden
            #line (193,91)-(193,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,92)-(193,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (193,109)-(193,113) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (193,114)-(193,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,115)-(193,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics");
            #line hidden
            #line (193,126)-(193,127) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,127)-(193,128) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (193,128)-(193,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,129)-(193,134) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (193,134)-(193,135) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,135)-(193,153) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (193,154)-(193,158) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (193,159)-(193,160) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,160)-(193,171) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations");
            #line hidden
            #line (193,171)-(193,172) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,172)-(193,173) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (193,173)-(193,174) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,174)-(193,179) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (194,13)-(194,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (194,14)-(194,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (194,15)-(194,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (194,25)-(194,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (194,26)-(194,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (194,38)-(194,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (194,39)-(194,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (195,9)-(195,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (196,13)-(196,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.SlotCount");
            #line hidden
            #line (196,27)-(196,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,28)-(196,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (196,29)-(196,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,30)-(196,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("1;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (197,13)-(197,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (197,15)-(197,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (197,16)-(197,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(tokens");
            #line hidden
            #line (197,23)-(197,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (197,24)-(197,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (197,26)-(197,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (197,27)-(197,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (198,13)-(198,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (199,17)-(199,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(tokens);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (200,17)-(200,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.tokens");
            #line hidden
            #line (200,28)-(200,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,29)-(200,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (200,30)-(200,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,31)-(200,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("tokens;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (201,13)-(201,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (202,9)-(202,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (204,9)-(204,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (204,15)-(204,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,16)-(204,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<__InternalSyntaxToken>");
            #line hidden
            #line (204,93)-(204,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,94)-(204,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Tokens");
            #line hidden
            #line (204,100)-(204,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,101)-(204,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (204,103)-(204,104) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,104)-(204,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (204,107)-(204,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,108)-(204,199) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<__InternalSyntaxToken>(this.tokens);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (206,9)-(206,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (206,18)-(206,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,19)-(206,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (206,27)-(206,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,28)-(206,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (206,39)-(206,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,40)-(206,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetSlot(int");
            #line hidden
            #line (206,51)-(206,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,52)-(206,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("index)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (207,9)-(207,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (208,13)-(208,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (208,19)-(208,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,20)-(208,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(index)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (209,13)-(209,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (210,17)-(210,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (210,21)-(210,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,22)-(210,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("0:");
            #line hidden
            #line (210,24)-(210,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,25)-(210,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (210,31)-(210,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,32)-(210,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.tokens;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (211,17)-(211,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            #line (211,25)-(211,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,26)-(211,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (211,32)-(211,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,33)-(211,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (212,13)-(212,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (213,9)-(213,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (215,9)-(215,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (215,18)-(215,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,19)-(215,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (215,27)-(215,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,28)-(215,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxNode");
            #line hidden
            #line (215,40)-(215,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,41)-(215,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("CreateRed(__SyntaxNode");
            #line hidden
            #line (215,63)-(215,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,64)-(215,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("parent,");
            #line hidden
            #line (215,71)-(215,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,72)-(215,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (215,75)-(215,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,76)-(215,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("position)");
            #line hidden
            #line (215,85)-(215,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,86)-(215,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (215,88)-(215,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,89)-(215,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (215,92)-(215,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,94)-(215,98) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (215,99)-(215,130) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SkippedTokensTriviaSyntax(this,");
            #line hidden
            #line (215,130)-(215,131) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,131)-(215,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (215,133)-(215,137) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (215,138)-(215,156) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxNode)parent,");
            #line hidden
            #line (215,156)-(215,157) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,157)-(215,167) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("position);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (217,9)-(217,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (217,15)-(217,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,16)-(217,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (217,24)-(217,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,25)-(217,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TResult");
            #line hidden
            #line (217,32)-(217,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,33)-(217,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Accept<TResult>(");
            #line hidden
            #line (217,50)-(217,54) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (217,55)-(217,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxVisitor<TResult>");
            #line hidden
            #line (217,85)-(217,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,86)-(217,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor)");
            #line hidden
            #line (217,94)-(217,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,95)-(217,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (217,97)-(217,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,98)-(217,137) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor.VisitSkippedTokensTrivia(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (219,9)-(219,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (219,15)-(219,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,16)-(219,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (219,24)-(219,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,25)-(219,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (219,29)-(219,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,30)-(219,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Accept(");
            #line hidden
            #line (219,38)-(219,42) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (219,43)-(219,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxVisitor");
            #line hidden
            #line (219,64)-(219,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,65)-(219,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor)");
            #line hidden
            #line (219,73)-(219,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,74)-(219,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (219,76)-(219,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,77)-(219,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor.VisitSkippedTokensTrivia(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (221,9)-(221,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (221,15)-(221,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,16)-(221,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSkippedTokensTriviaSyntax");
            #line hidden
            #line (221,46)-(221,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,47)-(221,131) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<__InternalSyntaxToken>");
            #line hidden
            #line (221,131)-(221,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,132)-(221,139) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("tokens)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (222,9)-(222,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (223,13)-(223,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (223,15)-(223,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,16)-(223,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(tokens");
            #line hidden
            #line (223,23)-(223,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,24)-(223,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (223,26)-(223,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,27)-(223,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.Tokens)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (224,13)-(224,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (225,17)-(225,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (225,20)-(225,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,21)-(225,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("newNode");
            #line hidden
            #line (225,28)-(225,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,29)-(225,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (225,30)-(225,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,31)-(225,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.InternalSyntaxFactory.SkippedTokensTrivia(tokens.Node);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (226,17)-(226,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (226,20)-(226,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (226,21)-(226,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diags");
            #line hidden
            #line (226,26)-(226,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (226,27)-(226,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (226,28)-(226,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (226,29)-(226,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (227,17)-(227,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (227,19)-(227,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,20)-(227,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(diags");
            #line hidden
            #line (227,26)-(227,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,27)-(227,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (227,29)-(227,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,30)-(227,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null");
            #line hidden
            #line (227,34)-(227,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,35)-(227,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (227,37)-(227,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,38)-(227,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diags.Length");
            #line hidden
            #line (227,50)-(227,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,51)-(227,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(">");
            #line hidden
            #line (227,52)-(227,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,53)-(227,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("0)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (228,21)-(228,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("newNode");
            #line hidden
            #line (228,28)-(228,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,29)-(228,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (228,30)-(228,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,31)-(228,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.GreenNodeExtensions.WithDiagnosticsGreen(newNode,");
            #line hidden
            #line (228,110)-(228,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,111)-(228,118) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diags);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (229,17)-(229,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (229,20)-(229,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,21)-(229,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations");
            #line hidden
            #line (229,32)-(229,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,33)-(229,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (229,34)-(229,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,35)-(229,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (230,17)-(230,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (230,19)-(230,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (230,20)-(230,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(annotations");
            #line hidden
            #line (230,32)-(230,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (230,33)-(230,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (230,35)-(230,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (230,36)-(230,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null");
            #line hidden
            #line (230,40)-(230,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (230,41)-(230,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (230,43)-(230,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (230,44)-(230,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations.Length");
            #line hidden
            #line (230,62)-(230,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (230,63)-(230,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(">");
            #line hidden
            #line (230,64)-(230,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (230,65)-(230,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("0)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (231,21)-(231,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("newNode");
            #line hidden
            #line (231,28)-(231,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,29)-(231,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (231,30)-(231,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,31)-(231,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.GreenNodeExtensions.WithAnnotationsGreen(newNode,");
            #line hidden
            #line (231,110)-(231,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,111)-(231,124) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (232,17)-(232,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (232,23)-(232,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,24)-(232,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(GreenSkippedTokensTriviaSyntax)newNode;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (233,13)-(233,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (234,13)-(234,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (234,19)-(234,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (234,20)-(234,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (235,9)-(235,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (237,3)-(237,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (237,9)-(237,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (237,10)-(237,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (237,18)-(237,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (237,19)-(237,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (237,39)-(237,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (237,40)-(237,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithDiagnostics(__DiagnosticInfo");
            #line hidden
            #line (237,73)-(237,77) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (237,78)-(237,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (237,79)-(237,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (238,3)-(238,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (239,4)-(239,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (239,10)-(239,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (239,11)-(239,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (239,14)-(239,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (239,15)-(239,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSkippedTokensTriviaSyntax(this.Kind,");
            #line hidden
            #line (239,56)-(239,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (239,57)-(239,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.tokens,");
            #line hidden
            #line (239,69)-(239,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (239,70)-(239,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (239,82)-(239,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (239,83)-(239,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (240,3)-(240,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (242,3)-(242,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (242,9)-(242,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (242,10)-(242,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (242,18)-(242,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (242,19)-(242,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (242,39)-(242,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (242,40)-(242,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithAnnotations(__SyntaxAnnotation");
            #line hidden
            #line (242,75)-(242,79) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (242,80)-(242,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (242,81)-(242,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (243,3)-(243,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (244,4)-(244,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (244,10)-(244,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (244,11)-(244,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (244,14)-(244,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (244,15)-(244,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSkippedTokensTriviaSyntax(this.Kind,");
            #line hidden
            #line (244,56)-(244,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (244,57)-(244,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.tokens,");
            #line hidden
            #line (244,69)-(244,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (244,70)-(244,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetDiagnostics(),");
            #line hidden
            #line (244,87)-(244,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (244,88)-(244,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (245,3)-(245,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (247,9)-(247,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (247,15)-(247,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,16)-(247,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (247,24)-(247,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,25)-(247,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (247,36)-(247,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,37)-(247,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Clone()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (248,9)-(248,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (249,4)-(249,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (249,10)-(249,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (249,11)-(249,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (249,14)-(249,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (249,15)-(249,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSkippedTokensTriviaSyntax(this.Kind,");
            #line hidden
            #line (249,56)-(249,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (249,57)-(249,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.tokens,");
            #line hidden
            #line (249,69)-(249,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (249,70)-(249,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetDiagnostics(),");
            #line hidden
            #line (249,87)-(249,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (249,88)-(249,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (250,3)-(250,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (251,5)-(251,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (253,2)-(253,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (253,10)-(253,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,11)-(253,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (253,18)-(253,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,19)-(253,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (253,24)-(253,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,25)-(253,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken");
            #line hidden
            #line (253,41)-(253,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,42)-(253,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (253,43)-(253,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,44)-(253,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (254,2)-(254,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (255,6)-(255,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("//====================");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (256,6)-(256,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (256,8)-(256,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,9)-(256,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Optimization:");
            #line hidden
            #line (256,22)-(256,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,23)-(256,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Normally,");
            #line hidden
            #line (256,32)-(256,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,33)-(256,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("we");
            #line hidden
            #line (256,35)-(256,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,36)-(256,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("wouldn't");
            #line hidden
            #line (256,44)-(256,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,45)-(256,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("accept");
            #line hidden
            #line (256,51)-(256,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,52)-(256,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this");
            #line hidden
            #line (256,56)-(256,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,57)-(256,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("much");
            #line hidden
            #line (256,61)-(256,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,62)-(256,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("duplicate");
            #line hidden
            #line (256,71)-(256,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,72)-(256,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("code,");
            #line hidden
            #line (256,77)-(256,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,78)-(256,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("but");
            #line hidden
            #line (256,81)-(256,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,82)-(256,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("these");
            #line hidden
            #line (256,87)-(256,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,88)-(256,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("constructors");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (257,6)-(257,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (257,8)-(257,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,9)-(257,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("are");
            #line hidden
            #line (257,12)-(257,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,13)-(257,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("called");
            #line hidden
            #line (257,19)-(257,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,20)-(257,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("A");
            #line hidden
            #line (257,21)-(257,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,22)-(257,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("LOT");
            #line hidden
            #line (257,25)-(257,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,26)-(257,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("and");
            #line hidden
            #line (257,29)-(257,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,30)-(257,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("we");
            #line hidden
            #line (257,32)-(257,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,33)-(257,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("want");
            #line hidden
            #line (257,37)-(257,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,38)-(257,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("to");
            #line hidden
            #line (257,40)-(257,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,41)-(257,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("keep");
            #line hidden
            #line (257,45)-(257,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,46)-(257,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("them");
            #line hidden
            #line (257,50)-(257,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,51)-(257,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("as");
            #line hidden
            #line (257,53)-(257,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,54)-(257,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("short");
            #line hidden
            #line (257,59)-(257,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,60)-(257,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("and");
            #line hidden
            #line (257,63)-(257,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,64)-(257,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("simple");
            #line hidden
            #line (257,70)-(257,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,71)-(257,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("as");
            #line hidden
            #line (257,73)-(257,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,74)-(257,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("possible");
            #line hidden
            #line (257,82)-(257,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,83)-(257,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("and");
            #line hidden
            #line (257,86)-(257,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,87)-(257,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("increase");
            #line hidden
            #line (257,95)-(257,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (257,96)-(257,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (258,6)-(258,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (258,8)-(258,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,9)-(258,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("likelihood");
            #line hidden
            #line (258,19)-(258,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,20)-(258,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("that");
            #line hidden
            #line (258,24)-(258,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,25)-(258,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("they");
            #line hidden
            #line (258,29)-(258,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,30)-(258,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("will");
            #line hidden
            #line (258,34)-(258,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,35)-(258,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("be");
            #line hidden
            #line (258,37)-(258,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,38)-(258,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("inlined.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (259,6)-(259,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (259,14)-(259,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,15)-(259,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken(");
            #line hidden
            #line (259,33)-(259,37) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (259,38)-(259,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (259,48)-(259,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,49)-(259,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (260,10)-(260,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (260,11)-(260,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (260,12)-(260,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (261,6)-(261,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (262,6)-(262,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (263,6)-(263,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (263,14)-(263,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,15)-(263,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken(");
            #line hidden
            #line (263,33)-(263,37) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (263,38)-(263,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (263,48)-(263,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,49)-(263,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (263,54)-(263,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,55)-(263,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (263,72)-(263,76) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (263,77)-(263,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,78)-(263,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (264,10)-(264,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (264,11)-(264,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,12)-(264,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind,");
            #line hidden
            #line (264,30)-(264,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,31)-(264,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (265,6)-(265,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (266,6)-(266,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (267,6)-(267,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (267,14)-(267,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,15)-(267,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken(");
            #line hidden
            #line (267,33)-(267,37) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (267,38)-(267,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (267,48)-(267,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,49)-(267,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (267,54)-(267,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,55)-(267,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (267,72)-(267,76) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (267,77)-(267,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,78)-(267,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (267,90)-(267,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,91)-(267,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (267,110)-(267,114) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (267,115)-(267,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,116)-(267,128) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (268,10)-(268,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (268,11)-(268,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,12)-(268,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind,");
            #line hidden
            #line (268,30)-(268,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,31)-(268,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (268,43)-(268,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,44)-(268,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (269,6)-(269,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (270,6)-(270,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (271,6)-(271,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (271,14)-(271,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,15)-(271,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken(");
            #line hidden
            #line (271,33)-(271,37) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (271,38)-(271,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (271,48)-(271,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,49)-(271,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (271,54)-(271,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,55)-(271,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (271,58)-(271,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,59)-(271,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("fullWidth)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (272,10)-(272,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (272,11)-(272,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,12)-(272,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind,");
            #line hidden
            #line (272,30)-(272,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,31)-(272,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("fullWidth)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (273,6)-(273,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (274,6)-(274,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (275,6)-(275,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (275,14)-(275,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,15)-(275,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken(");
            #line hidden
            #line (275,33)-(275,37) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (275,38)-(275,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (275,48)-(275,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,49)-(275,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (275,54)-(275,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,55)-(275,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (275,58)-(275,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,59)-(275,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("fullWidth,");
            #line hidden
            #line (275,69)-(275,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,70)-(275,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (275,87)-(275,91) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (275,92)-(275,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,93)-(275,105) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (276,10)-(276,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (276,11)-(276,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,12)-(276,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind,");
            #line hidden
            #line (276,30)-(276,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,31)-(276,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("fullWidth,");
            #line hidden
            #line (276,41)-(276,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,42)-(276,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (277,6)-(277,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (278,6)-(278,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (279,6)-(279,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (279,14)-(279,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,15)-(279,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken(");
            #line hidden
            #line (279,33)-(279,37) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (279,38)-(279,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (279,48)-(279,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,49)-(279,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (279,54)-(279,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,55)-(279,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (279,58)-(279,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,59)-(279,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("fullWidth,");
            #line hidden
            #line (279,69)-(279,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,70)-(279,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (279,87)-(279,91) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (279,92)-(279,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,93)-(279,105) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (279,105)-(279,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,106)-(279,124) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (279,125)-(279,129) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (279,130)-(279,131) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,131)-(279,143) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (280,10)-(280,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (280,11)-(280,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (280,12)-(280,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((ushort)kind,");
            #line hidden
            #line (280,30)-(280,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (280,31)-(280,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("fullWidth,");
            #line hidden
            #line (280,41)-(280,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (280,42)-(280,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (280,54)-(280,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (280,55)-(280,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (281,6)-(281,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (282,6)-(282,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (284,6)-(284,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (284,12)-(284,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (284,13)-(284,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (284,21)-(284,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (284,22)-(284,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Language");
            #line hidden
            #line (284,32)-(284,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (284,33)-(284,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language");
            #line hidden
            #line (284,41)-(284,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (284,42)-(284,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (284,44)-(284,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (284,46)-(284,50) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (284,51)-(284,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (285,6)-(285,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (285,12)-(285,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (285,14)-(285,18) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (285,19)-(285,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (285,29)-(285,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (285,30)-(285,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Kind");
            #line hidden
            #line (285,34)-(285,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (285,35)-(285,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (285,37)-(285,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (285,38)-(285,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (285,40)-(285,44) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (285,45)-(285,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)this.RawKind;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (286,3)-(286,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (286,9)-(286,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,10)-(286,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (286,18)-(286,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,19)-(286,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (286,25)-(286,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,26)-(286,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("KindText");
            #line hidden
            #line (286,34)-(286,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,35)-(286,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (286,37)-(286,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,39)-(286,43) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (286,44)-(286,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.SyntaxFacts.GetKindText(Kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (288,3)-(288,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("//====================");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (289,3)-(289,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (289,11)-(289,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,12)-(289,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (289,18)-(289,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,19)-(289,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken");
            #line hidden
            #line (289,35)-(289,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,36)-(289,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Create(");
            #line hidden
            #line (289,44)-(289,48) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (289,49)-(289,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (289,59)-(289,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,60)-(289,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (290,6)-(290,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (291,10)-(291,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (291,12)-(291,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,13)-(291,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(kind");
            #line hidden
            #line (291,18)-(291,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,19)-(291,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(">");
            #line hidden
            #line (291,20)-(291,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,21)-(291,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("LastTokenWithWellKnownText)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (292,10)-(292,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (293,14)-(293,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (293,16)-(293,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (293,17)-(293,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(!");
            #line hidden
            #line (293,20)-(293,24) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (293,25)-(293,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.SyntaxFacts.IsToken(kind))");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (294,14)-(294,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (295,18)-(295,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("throw");
            #line hidden
            #line (295,23)-(295,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,24)-(295,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (295,27)-(295,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,28)-(295,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__ArgumentNullException(string.Format(\"Invalid");
            #line hidden
            #line (295,74)-(295,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,76)-(295,80) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (295,81)-(295,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind:");
            #line hidden
            #line (295,92)-(295,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,93)-(295,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{0}.");
            #line hidden
            #line (295,97)-(295,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,98)-(295,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("This");
            #line hidden
            #line (295,102)-(295,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,103)-(295,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("method");
            #line hidden
            #line (295,109)-(295,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,110)-(295,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("can");
            #line hidden
            #line (295,113)-(295,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,114)-(295,118) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("only");
            #line hidden
            #line (295,118)-(295,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,119)-(295,121) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("be");
            #line hidden
            #line (295,121)-(295,122) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,122)-(295,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("used");
            #line hidden
            #line (295,126)-(295,127) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,127)-(295,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("to");
            #line hidden
            #line (295,129)-(295,130) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,130)-(295,136) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("create");
            #line hidden
            #line (295,136)-(295,137) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,137)-(295,146) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("tokens.\",");
            #line hidden
            #line (295,146)-(295,147) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,147)-(295,153) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind),");
            #line hidden
            #line (295,153)-(295,154) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,154)-(295,168) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("nameof(kind));");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (296,14)-(296,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (297,14)-(297,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (297,20)-(297,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,21)-(297,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("CreateMissing(kind,");
            #line hidden
            #line (297,40)-(297,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,41)-(297,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (297,46)-(297,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,47)-(297,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (298,10)-(298,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (299,10)-(299,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (299,16)-(299,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,17)-(299,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithNoTrivia");
            #line hidden
            #line (299,38)-(299,41) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (299,42)-(299,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)kind");
            #line hidden
            #line (299,52)-(299,55) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (299,56)-(299,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Value;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (300,6)-(300,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (301,6)-(301,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (301,14)-(301,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,15)-(301,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (301,21)-(301,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,22)-(301,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken");
            #line hidden
            #line (301,38)-(301,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,39)-(301,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Create(");
            #line hidden
            #line (301,47)-(301,51) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (301,52)-(301,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (301,62)-(301,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,63)-(301,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (301,68)-(301,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,69)-(301,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (301,81)-(301,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,82)-(301,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (301,90)-(301,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,91)-(301,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (301,103)-(301,104) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,104)-(301,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (302,6)-(302,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (303,10)-(303,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (303,12)-(303,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,13)-(303,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(kind");
            #line hidden
            #line (303,18)-(303,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,19)-(303,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(">");
            #line hidden
            #line (303,20)-(303,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,21)-(303,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("LastTokenWithWellKnownText)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (304,10)-(304,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (305,14)-(305,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (305,16)-(305,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,17)-(305,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(!");
            #line hidden
            #line (305,20)-(305,24) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (305,25)-(305,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.SyntaxFacts.IsToken(kind))");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (306,14)-(306,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (307,18)-(307,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("throw");
            #line hidden
            #line (307,23)-(307,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,24)-(307,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (307,27)-(307,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,28)-(307,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__ArgumentNullException(string.Format(\"Invalid");
            #line hidden
            #line (307,74)-(307,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,76)-(307,80) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (307,81)-(307,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind:");
            #line hidden
            #line (307,92)-(307,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,93)-(307,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{0}.");
            #line hidden
            #line (307,97)-(307,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,98)-(307,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("This");
            #line hidden
            #line (307,102)-(307,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,103)-(307,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("method");
            #line hidden
            #line (307,109)-(307,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,110)-(307,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("can");
            #line hidden
            #line (307,113)-(307,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,114)-(307,118) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("only");
            #line hidden
            #line (307,118)-(307,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,119)-(307,121) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("be");
            #line hidden
            #line (307,121)-(307,122) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,122)-(307,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("used");
            #line hidden
            #line (307,126)-(307,127) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,127)-(307,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("to");
            #line hidden
            #line (307,129)-(307,130) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,130)-(307,136) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("create");
            #line hidden
            #line (307,136)-(307,137) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,137)-(307,146) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("tokens.\",");
            #line hidden
            #line (307,146)-(307,147) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,147)-(307,153) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind),");
            #line hidden
            #line (307,153)-(307,154) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,154)-(307,168) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("nameof(kind));");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (308,14)-(308,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (309,14)-(309,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (309,20)-(309,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,21)-(309,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("CreateMissing(kind,");
            #line hidden
            #line (309,40)-(309,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,41)-(309,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (309,49)-(309,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,50)-(309,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (310,10)-(310,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (311,10)-(311,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (311,12)-(311,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (311,13)-(311,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(leading");
            #line hidden
            #line (311,21)-(311,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (311,22)-(311,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (311,24)-(311,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (311,25)-(311,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (312,10)-(312,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (313,14)-(313,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (313,16)-(313,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (313,17)-(313,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing");
            #line hidden
            #line (313,26)-(313,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (313,27)-(313,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (313,29)-(313,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (313,30)-(313,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (314,14)-(314,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (315,18)-(315,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (315,24)-(315,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (315,25)-(315,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithNoTrivia");
            #line hidden
            #line (315,46)-(315,49) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (315,50)-(315,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)kind");
            #line hidden
            #line (315,60)-(315,63) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (315,64)-(315,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Value;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (316,14)-(316,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (317,14)-(317,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("else");
            #line hidden
            #line (317,18)-(317,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,19)-(317,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (317,21)-(317,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,22)-(317,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing");
            #line hidden
            #line (317,31)-(317,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,32)-(317,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (317,34)-(317,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,36)-(317,40) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (317,41)-(317,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.InternalSyntaxFactory.Space)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (318,14)-(318,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (319,18)-(319,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (319,24)-(319,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (319,25)-(319,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithSingleTrailingSpace");
            #line hidden
            #line (319,57)-(319,60) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (319,61)-(319,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)kind");
            #line hidden
            #line (319,71)-(319,74) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (319,75)-(319,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Value;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (320,14)-(320,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (321,14)-(321,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("else");
            #line hidden
            #line (321,18)-(321,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (321,19)-(321,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (321,21)-(321,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (321,22)-(321,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing");
            #line hidden
            #line (321,31)-(321,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (321,32)-(321,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (321,34)-(321,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (321,36)-(321,40) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (321,41)-(321,104) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.InternalSyntaxFactory.CarriageReturnLineFeed)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (322,14)-(322,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (323,18)-(323,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (323,24)-(323,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,25)-(323,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithSingleTrailingCRLF");
            #line hidden
            #line (323,56)-(323,59) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (323,60)-(323,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)kind");
            #line hidden
            #line (323,70)-(323,73) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (323,74)-(323,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Value;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (324,14)-(324,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (325,10)-(325,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (326,10)-(326,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (326,12)-(326,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,13)-(326,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(leading");
            #line hidden
            #line (326,21)-(326,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,22)-(326,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (326,24)-(326,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,26)-(326,30) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (326,31)-(326,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.InternalSyntaxFactory.ElasticZeroSpace");
            #line hidden
            #line (326,87)-(326,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,88)-(326,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (326,90)-(326,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,91)-(326,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing");
            #line hidden
            #line (326,99)-(326,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,100)-(326,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (326,102)-(326,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,104)-(326,108) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (326,109)-(326,166) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.InternalSyntaxFactory.ElasticZeroSpace)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (327,10)-(327,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (328,14)-(328,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (328,20)-(328,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,21)-(328,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithElasticTrivia");
            #line hidden
            #line (328,47)-(328,50) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (328,51)-(328,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)kind");
            #line hidden
            #line (328,61)-(328,64) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (328,65)-(328,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Value;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (329,10)-(329,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (330,10)-(330,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (330,16)-(330,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,17)-(330,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (330,20)-(330,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,21)-(330,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia(kind,");
            #line hidden
            #line (330,48)-(330,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,49)-(330,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (330,57)-(330,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,58)-(330,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (331,6)-(331,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (332,6)-(332,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (332,14)-(332,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,15)-(332,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (332,21)-(332,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,22)-(332,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken");
            #line hidden
            #line (332,38)-(332,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,39)-(332,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("CreateMissing(");
            #line hidden
            #line (332,54)-(332,58) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (332,59)-(332,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (332,69)-(332,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,70)-(332,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (332,75)-(332,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,76)-(332,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (332,88)-(332,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,89)-(332,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (332,97)-(332,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,98)-(332,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (332,110)-(332,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,111)-(332,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (333,6)-(333,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (334,10)-(334,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (334,16)-(334,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (334,17)-(334,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (334,20)-(334,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (334,21)-(334,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingTokenWithTrivia(kind,");
            #line hidden
            #line (334,49)-(334,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (334,50)-(334,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (334,58)-(334,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (334,59)-(334,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (335,6)-(335,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (336,6)-(336,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (336,14)-(336,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (336,15)-(336,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (336,21)-(336,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (336,22)-(336,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (336,30)-(336,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (336,32)-(336,36) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (336,37)-(336,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (336,47)-(336,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (336,48)-(336,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("FirstTokenWithWellKnownText;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (337,6)-(337,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (337,14)-(337,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (337,15)-(337,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (337,21)-(337,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (337,22)-(337,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (337,30)-(337,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (337,32)-(337,36) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (337,37)-(337,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (337,47)-(337,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (337,48)-(337,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("LastTokenWithWellKnownText;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (338,6)-(338,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (338,8)-(338,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (338,9)-(338,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TODO:");
            #line hidden
            #line (338,14)-(338,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (338,15)-(338,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("eliminate");
            #line hidden
            #line (338,24)-(338,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (338,25)-(338,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (338,28)-(338,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (338,29)-(338,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("blank");
            #line hidden
            #line (338,34)-(338,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (338,35)-(338,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("space");
            #line hidden
            #line (338,40)-(338,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (338,41)-(338,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("before");
            #line hidden
            #line (338,47)-(338,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (338,48)-(338,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (338,51)-(338,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (338,52)-(338,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("first");
            #line hidden
            #line (338,57)-(338,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (338,58)-(338,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("interesting");
            #line hidden
            #line (338,69)-(338,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (338,70)-(338,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("element?");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (339,6)-(339,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (339,13)-(339,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,14)-(339,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (339,20)-(339,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,21)-(339,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (339,29)-(339,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,30)-(339,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>");
            #line hidden
            #line (339,91)-(339,95) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (339,96)-(339,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,97)-(339,118) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithNoTrivia;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (340,6)-(340,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (340,13)-(340,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (340,14)-(340,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (340,20)-(340,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (340,21)-(340,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (340,29)-(340,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (340,30)-(340,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>");
            #line hidden
            #line (340,91)-(340,95) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (340,96)-(340,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (340,97)-(340,123) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithElasticTrivia;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (341,6)-(341,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (341,13)-(341,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (341,14)-(341,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (341,20)-(341,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (341,21)-(341,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (341,29)-(341,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (341,30)-(341,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>");
            #line hidden
            #line (341,91)-(341,95) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (341,96)-(341,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (341,97)-(341,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithSingleTrailingSpace;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (342,6)-(342,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (342,13)-(342,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,14)-(342,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (342,20)-(342,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,21)-(342,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (342,29)-(342,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,30)-(342,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>");
            #line hidden
            #line (342,91)-(342,95) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (342,96)-(342,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,97)-(342,128) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithSingleTrailingCRLF;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (343,6)-(343,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (343,12)-(343,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (343,13)-(343,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (344,6)-(344,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (345,10)-(345,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("FirstTokenWithWellKnownText");
            #line hidden
            #line (345,37)-(345,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (345,38)-(345,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (345,39)-(345,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (345,41)-(345,45) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (345,46)-(345,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.__FirstFixedToken;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (346,10)-(346,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("LastTokenWithWellKnownText");
            #line hidden
            #line (346,36)-(346,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (346,37)-(346,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (346,38)-(346,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (346,40)-(346,44) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (346,45)-(346,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.__LastFixedToken;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (347,10)-(347,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithNoTrivia");
            #line hidden
            #line (347,30)-(347,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,31)-(347,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (347,32)-(347,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,33)-(347,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (347,36)-(347,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,37)-(347,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>");
            #line hidden
            #line (347,98)-(347,101) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (347,102)-(347,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)LastTokenWithWellKnownText");
            #line hidden
            #line (347,133)-(347,134) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,134)-(347,135) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("+");
            #line hidden
            #line (347,135)-(347,136) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,136)-(347,137) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("1");
            #line hidden
            #line (347,138)-(347,141) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (347,142)-(347,143) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (348,10)-(348,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithElasticTrivia");
            #line hidden
            #line (348,35)-(348,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (348,36)-(348,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (348,37)-(348,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (348,38)-(348,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (348,41)-(348,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (348,42)-(348,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>");
            #line hidden
            #line (348,103)-(348,106) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (348,107)-(348,138) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)LastTokenWithWellKnownText");
            #line hidden
            #line (348,138)-(348,139) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (348,139)-(348,140) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("+");
            #line hidden
            #line (348,140)-(348,141) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (348,141)-(348,142) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("1");
            #line hidden
            #line (348,143)-(348,146) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (348,147)-(348,148) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (349,10)-(349,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithSingleTrailingSpace");
            #line hidden
            #line (349,41)-(349,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (349,42)-(349,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (349,43)-(349,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (349,44)-(349,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (349,47)-(349,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (349,48)-(349,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>");
            #line hidden
            #line (349,109)-(349,112) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (349,113)-(349,144) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)LastTokenWithWellKnownText");
            #line hidden
            #line (349,144)-(349,145) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (349,145)-(349,146) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("+");
            #line hidden
            #line (349,146)-(349,147) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (349,147)-(349,148) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("1");
            #line hidden
            #line (349,149)-(349,152) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (349,153)-(349,154) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (350,10)-(350,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithSingleTrailingCRLF");
            #line hidden
            #line (350,40)-(350,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,41)-(350,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (350,42)-(350,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,43)-(350,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (350,46)-(350,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,47)-(350,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>");
            #line hidden
            #line (350,108)-(350,111) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (350,112)-(350,143) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)LastTokenWithWellKnownText");
            #line hidden
            #line (350,143)-(350,144) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,144)-(350,145) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("+");
            #line hidden
            #line (350,145)-(350,146) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,146)-(350,147) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("1");
            #line hidden
            #line (350,148)-(350,151) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (350,152)-(350,153) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (351,4)-(351,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (351,7)-(351,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (351,8)-(351,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("factory");
            #line hidden
            #line (351,15)-(351,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (351,16)-(351,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (351,17)-(351,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (351,19)-(351,23) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (351,24)-(351,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.InternalSyntaxFactory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (352,10)-(352,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (352,13)-(352,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (352,14)-(352,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (352,16)-(352,20) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (352,21)-(352,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (352,31)-(352,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (352,32)-(352,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind");
            #line hidden
            #line (352,36)-(352,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (352,37)-(352,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (352,38)-(352,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (352,39)-(352,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("FirstTokenWithWellKnownText;");
            #line hidden
            #line (352,67)-(352,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (352,68)-(352,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind");
            #line hidden
            #line (352,72)-(352,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (352,73)-(352,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("<=");
            #line hidden
            #line (352,75)-(352,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (352,76)-(352,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("LastTokenWithWellKnownText;");
            #line hidden
            #line (352,103)-(352,104) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (352,104)-(352,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind++)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (353,10)-(353,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (354,14)-(354,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithNoTrivia");
            #line hidden
            #line (354,35)-(354,38) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (354,39)-(354,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)kind");
            #line hidden
            #line (354,49)-(354,52) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (354,53)-(354,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Value");
            #line hidden
            #line (354,59)-(354,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (354,60)-(354,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (354,61)-(354,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (354,62)-(354,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (354,65)-(354,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (354,66)-(354,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken((");
            #line hidden
            #line (354,85)-(354,89) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (354,90)-(354,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (355,14)-(355,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithElasticTrivia");
            #line hidden
            #line (355,40)-(355,43) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (355,44)-(355,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)kind");
            #line hidden
            #line (355,54)-(355,57) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (355,58)-(355,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Value");
            #line hidden
            #line (355,64)-(355,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,65)-(355,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (355,66)-(355,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,67)-(355,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (355,70)-(355,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,71)-(355,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia((");
            #line hidden
            #line (355,95)-(355,99) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (355,100)-(355,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)kind,");
            #line hidden
            #line (355,116)-(355,117) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,117)-(355,142) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("factory.ElasticZeroSpace,");
            #line hidden
            #line (355,142)-(355,143) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,143)-(355,169) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("factory.ElasticZeroSpace);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (356,14)-(356,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithSingleTrailingSpace");
            #line hidden
            #line (356,46)-(356,49) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (356,50)-(356,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)kind");
            #line hidden
            #line (356,60)-(356,63) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (356,64)-(356,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Value");
            #line hidden
            #line (356,70)-(356,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,71)-(356,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (356,72)-(356,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,73)-(356,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (356,76)-(356,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,77)-(356,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia((");
            #line hidden
            #line (356,101)-(356,105) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (356,106)-(356,122) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)kind,");
            #line hidden
            #line (356,122)-(356,123) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,123)-(356,128) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (356,128)-(356,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,129)-(356,144) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("factory.Space);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (357,14)-(357,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithSingleTrailingCRLF");
            #line hidden
            #line (357,45)-(357,48) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (357,49)-(357,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)kind");
            #line hidden
            #line (357,59)-(357,62) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (357,63)-(357,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Value");
            #line hidden
            #line (357,69)-(357,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (357,70)-(357,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (357,71)-(357,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (357,72)-(357,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (357,75)-(357,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (357,76)-(357,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia((");
            #line hidden
            #line (357,100)-(357,104) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (357,105)-(357,121) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)kind,");
            #line hidden
            #line (357,121)-(357,122) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (357,122)-(357,127) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (357,127)-(357,128) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (357,128)-(357,160) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("factory.CarriageReturnLineFeed);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (358,10)-(358,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (359,6)-(359,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (360,6)-(360,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (360,14)-(360,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,15)-(360,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (360,21)-(360,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,22)-(360,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.Collections.Generic.IEnumerable<GreenSyntaxToken>");
            #line hidden
            #line (360,86)-(360,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,87)-(360,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetWellKnownTokens()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (361,6)-(361,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (362,10)-(362,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("foreach");
            #line hidden
            #line (362,17)-(362,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,18)-(362,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (362,22)-(362,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,23)-(362,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("element");
            #line hidden
            #line (362,30)-(362,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,31)-(362,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("in");
            #line hidden
            #line (362,33)-(362,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,34)-(362,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithNoTrivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (363,10)-(363,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (364,14)-(364,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (364,16)-(364,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (364,17)-(364,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(element.Value");
            #line hidden
            #line (364,31)-(364,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (364,32)-(364,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (364,34)-(364,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (364,35)-(364,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (365,14)-(365,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (366,18)-(366,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("yield");
            #line hidden
            #line (366,23)-(366,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (366,24)-(366,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (366,30)-(366,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (366,31)-(366,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("element.Value;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (367,14)-(367,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (368,10)-(368,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (369,10)-(369,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("foreach");
            #line hidden
            #line (369,17)-(369,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,18)-(369,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (369,22)-(369,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,23)-(369,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("element");
            #line hidden
            #line (369,30)-(369,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,31)-(369,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("in");
            #line hidden
            #line (369,33)-(369,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,34)-(369,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithElasticTrivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (370,10)-(370,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (371,14)-(371,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (371,16)-(371,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,17)-(371,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(element.Value");
            #line hidden
            #line (371,31)-(371,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,32)-(371,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (371,34)-(371,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,35)-(371,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (372,14)-(372,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (373,18)-(373,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("yield");
            #line hidden
            #line (373,23)-(373,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (373,24)-(373,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (373,30)-(373,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (373,31)-(373,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("element.Value;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (374,14)-(374,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (375,10)-(375,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (376,10)-(376,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("foreach");
            #line hidden
            #line (376,17)-(376,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,18)-(376,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (376,22)-(376,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,23)-(376,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("element");
            #line hidden
            #line (376,30)-(376,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,31)-(376,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("in");
            #line hidden
            #line (376,33)-(376,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,34)-(376,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithSingleTrailingSpace)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (377,10)-(377,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (378,14)-(378,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (378,16)-(378,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,17)-(378,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(element.Value");
            #line hidden
            #line (378,31)-(378,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,32)-(378,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (378,34)-(378,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,35)-(378,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (379,14)-(379,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (380,18)-(380,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("yield");
            #line hidden
            #line (380,23)-(380,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (380,24)-(380,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (380,30)-(380,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (380,31)-(380,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("element.Value;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (381,14)-(381,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (382,10)-(382,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (383,10)-(383,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("foreach");
            #line hidden
            #line (383,17)-(383,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,18)-(383,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (383,22)-(383,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,23)-(383,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("element");
            #line hidden
            #line (383,30)-(383,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,31)-(383,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("in");
            #line hidden
            #line (383,33)-(383,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,34)-(383,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("s_tokensWithSingleTrailingCRLF)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (384,10)-(384,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (385,14)-(385,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (385,16)-(385,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,17)-(385,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(element.Value");
            #line hidden
            #line (385,31)-(385,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,32)-(385,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (385,34)-(385,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,35)-(385,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (386,14)-(386,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (387,18)-(387,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("yield");
            #line hidden
            #line (387,23)-(387,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,24)-(387,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (387,30)-(387,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,31)-(387,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("element.Value;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (388,14)-(388,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (389,10)-(389,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (390,6)-(390,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (391,6)-(391,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (391,14)-(391,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,15)-(391,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (391,21)-(391,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,22)-(391,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken");
            #line hidden
            #line (391,38)-(391,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,39)-(391,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Identifier(");
            #line hidden
            #line (391,51)-(391,55) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (391,56)-(391,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (391,66)-(391,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,67)-(391,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (391,72)-(391,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,73)-(391,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (391,79)-(391,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,80)-(391,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (392,6)-(392,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (393,10)-(393,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (393,16)-(393,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (393,17)-(393,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (393,20)-(393,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (393,21)-(393,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifier(kind,");
            #line hidden
            #line (393,43)-(393,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (393,44)-(393,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (394,6)-(394,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (395,6)-(395,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (395,14)-(395,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,15)-(395,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (395,21)-(395,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,22)-(395,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken");
            #line hidden
            #line (395,38)-(395,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,39)-(395,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Identifier(");
            #line hidden
            #line (395,51)-(395,55) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (395,56)-(395,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (395,66)-(395,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,67)-(395,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (395,72)-(395,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,73)-(395,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (395,84)-(395,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,85)-(395,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (395,93)-(395,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,94)-(395,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (395,100)-(395,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,101)-(395,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (395,106)-(395,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,107)-(395,118) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (395,118)-(395,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,119)-(395,128) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (396,6)-(396,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (397,10)-(397,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (397,12)-(397,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,13)-(397,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(leading");
            #line hidden
            #line (397,21)-(397,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,22)-(397,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (397,24)-(397,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,25)-(397,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (398,10)-(398,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (399,14)-(399,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (399,16)-(399,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (399,17)-(399,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing");
            #line hidden
            #line (399,26)-(399,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (399,27)-(399,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (399,29)-(399,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (399,30)-(399,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (400,14)-(400,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (401,18)-(401,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (401,24)-(401,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (401,25)-(401,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Identifier(kind,");
            #line hidden
            #line (401,41)-(401,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (401,42)-(401,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (402,14)-(402,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (403,14)-(403,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("else");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (404,14)-(404,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (405,18)-(405,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (405,24)-(405,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,25)-(405,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (405,28)-(405,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,29)-(405,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrailingTrivia(kind,");
            #line hidden
            #line (405,69)-(405,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,70)-(405,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (405,75)-(405,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,76)-(405,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (406,14)-(406,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (407,10)-(407,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (408,10)-(408,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (408,16)-(408,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (408,17)-(408,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (408,20)-(408,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (408,21)-(408,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(kind,");
            #line hidden
            #line (408,53)-(408,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (408,54)-(408,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (408,59)-(408,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (408,60)-(408,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (408,65)-(408,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (408,66)-(408,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (408,71)-(408,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (408,72)-(408,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (408,80)-(408,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (408,81)-(408,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (409,6)-(409,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (410,6)-(410,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (410,14)-(410,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,15)-(410,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (410,21)-(410,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,22)-(410,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken");
            #line hidden
            #line (410,38)-(410,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,39)-(410,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Identifier(");
            #line hidden
            #line (410,51)-(410,55) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (410,56)-(410,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (410,66)-(410,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,67)-(410,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (410,72)-(410,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,74)-(410,78) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (410,79)-(410,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (410,89)-(410,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,90)-(410,105) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("contextualKind,");
            #line hidden
            #line (410,105)-(410,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,106)-(410,117) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (410,117)-(410,118) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,118)-(410,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (410,126)-(410,127) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,127)-(410,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (410,133)-(410,134) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,134)-(410,139) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (410,139)-(410,140) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,140)-(410,146) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (410,146)-(410,147) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,147)-(410,157) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText,");
            #line hidden
            #line (410,157)-(410,158) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,158)-(410,169) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (410,169)-(410,170) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,170)-(410,179) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (411,6)-(411,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (412,10)-(412,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (412,12)-(412,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (412,13)-(412,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(contextualKind");
            #line hidden
            #line (412,28)-(412,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (412,29)-(412,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (412,31)-(412,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (412,32)-(412,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind");
            #line hidden
            #line (412,36)-(412,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (412,37)-(412,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (412,39)-(412,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (412,40)-(412,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText");
            #line hidden
            #line (412,49)-(412,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (412,50)-(412,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (412,52)-(412,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (412,53)-(412,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (413,10)-(413,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (414,14)-(414,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (414,20)-(414,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (414,21)-(414,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Identifier(kind,");
            #line hidden
            #line (414,37)-(414,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (414,38)-(414,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (414,46)-(414,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (414,47)-(414,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (414,52)-(414,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (414,53)-(414,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (415,10)-(415,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (416,10)-(416,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (416,16)-(416,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,17)-(416,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (416,20)-(416,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,21)-(416,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(kind,");
            #line hidden
            #line (416,53)-(416,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,54)-(416,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("contextualKind,");
            #line hidden
            #line (416,69)-(416,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,70)-(416,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (416,75)-(416,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,76)-(416,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText,");
            #line hidden
            #line (416,86)-(416,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,87)-(416,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (416,95)-(416,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,96)-(416,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (417,6)-(417,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (418,6)-(418,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (418,14)-(418,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,15)-(418,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (418,21)-(418,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,22)-(418,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken");
            #line hidden
            #line (418,38)-(418,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,39)-(418,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithValue<T>(");
            #line hidden
            #line (418,53)-(418,57) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (418,58)-(418,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (418,68)-(418,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,69)-(418,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (418,74)-(418,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,75)-(418,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (418,81)-(418,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,82)-(418,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (418,87)-(418,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,88)-(418,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("T");
            #line hidden
            #line (418,89)-(418,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,90)-(418,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (419,6)-(419,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (420,10)-(420,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (420,16)-(420,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (420,17)-(420,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (420,20)-(420,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (420,21)-(420,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValue<T>(kind,");
            #line hidden
            #line (420,50)-(420,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (420,51)-(420,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (420,56)-(420,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (420,57)-(420,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (421,6)-(421,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (422,6)-(422,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (422,14)-(422,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,15)-(422,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (422,21)-(422,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,22)-(422,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken");
            #line hidden
            #line (422,38)-(422,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,39)-(422,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithValue<T>(");
            #line hidden
            #line (422,53)-(422,57) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (422,58)-(422,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (422,68)-(422,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,69)-(422,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (422,74)-(422,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,75)-(422,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (422,87)-(422,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,88)-(422,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (422,96)-(422,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,97)-(422,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (422,103)-(422,104) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,104)-(422,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (422,109)-(422,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,110)-(422,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("T");
            #line hidden
            #line (422,111)-(422,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,112)-(422,118) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value,");
            #line hidden
            #line (422,118)-(422,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,119)-(422,131) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (422,131)-(422,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,132)-(422,141) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (423,6)-(423,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (424,10)-(424,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (424,16)-(424,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,17)-(424,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (424,20)-(424,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,21)-(424,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValueAndTrivia<T>(kind,");
            #line hidden
            #line (424,59)-(424,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,60)-(424,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (424,65)-(424,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,66)-(424,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value,");
            #line hidden
            #line (424,72)-(424,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,73)-(424,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (424,81)-(424,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,82)-(424,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (425,6)-(425,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (426,6)-(426,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (426,12)-(426,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,13)-(426,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (426,16)-(426,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,17)-(426,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (426,24)-(426,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,26)-(426,30) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (426,31)-(426,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (426,41)-(426,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,42)-(426,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("ContextualKind");
            #line hidden
            #line (426,56)-(426,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,57)-(426,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (426,59)-(426,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,60)-(426,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.Kind;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (427,6)-(427,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (427,12)-(427,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,13)-(427,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (427,21)-(427,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,22)-(427,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (427,25)-(427,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,26)-(427,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("RawContextualKind");
            #line hidden
            #line (427,43)-(427,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,44)-(427,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (427,46)-(427,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,47)-(427,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(int)this.ContextualKind;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (428,9)-(428,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (428,15)-(428,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,16)-(428,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (428,24)-(428,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,25)-(428,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (428,36)-(428,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,37)-(428,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithLeadingTrivia(__GreenNode?");
            #line hidden
            #line (428,67)-(428,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,68)-(428,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (429,9)-(429,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (430,13)-(430,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (430,19)-(430,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,20)-(430,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithLeadingTrivia(trivia);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (431,9)-(431,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (432,3)-(432,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (432,9)-(432,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,10)-(432,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (432,18)-(432,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,19)-(432,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (432,30)-(432,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,31)-(432,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithTrailingTrivia(__GreenNode?");
            #line hidden
            #line (432,62)-(432,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,63)-(432,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (433,3)-(433,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (434,4)-(434,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (434,10)-(434,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,11)-(434,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithTrailingTrivia(trivia);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (435,3)-(435,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (436,3)-(436,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (436,9)-(436,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,10)-(436,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (436,17)-(436,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,18)-(436,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (436,39)-(436,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,40)-(436,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithLeadingTrivia(__GreenNode?");
            #line hidden
            #line (436,75)-(436,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,76)-(436,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (437,6)-(437,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (438,10)-(438,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (438,16)-(438,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,17)-(438,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (438,20)-(438,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,21)-(438,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia(this.Kind,");
            #line hidden
            #line (438,53)-(438,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,54)-(438,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (438,61)-(438,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,62)-(438,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (438,67)-(438,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,68)-(438,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (438,90)-(438,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,91)-(438,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (439,6)-(439,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (440,6)-(440,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (440,12)-(440,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,13)-(440,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (440,20)-(440,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,21)-(440,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (440,42)-(440,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,43)-(440,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithTrailingTrivia(__GreenNode?");
            #line hidden
            #line (440,79)-(440,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,80)-(440,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (441,6)-(441,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (442,10)-(442,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (442,16)-(442,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (442,17)-(442,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (442,20)-(442,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (442,21)-(442,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia(this.Kind,");
            #line hidden
            #line (442,53)-(442,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (442,54)-(442,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (442,59)-(442,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (442,60)-(442,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (442,67)-(442,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (442,68)-(442,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (442,90)-(442,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (442,91)-(442,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (443,6)-(443,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (444,6)-(444,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (444,12)-(444,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,13)-(444,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (444,21)-(444,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,22)-(444,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (444,42)-(444,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,43)-(444,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithDiagnostics(__DiagnosticInfo");
            #line hidden
            #line (444,76)-(444,80) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (444,81)-(444,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,82)-(444,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (445,6)-(445,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (446,10)-(446,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Debug.Assert(this.GetType()");
            #line hidden
            #line (446,39)-(446,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,40)-(446,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (446,42)-(446,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,43)-(446,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("typeof(GreenSyntaxToken));");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (447,10)-(447,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (447,16)-(447,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (447,17)-(447,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (447,20)-(447,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (447,21)-(447,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken(this.Kind,");
            #line hidden
            #line (447,48)-(447,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (447,49)-(447,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.FullWidth,");
            #line hidden
            #line (447,64)-(447,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (447,65)-(447,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (447,77)-(447,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (447,78)-(447,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (448,6)-(448,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (449,6)-(449,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (449,12)-(449,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,13)-(449,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (449,21)-(449,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,22)-(449,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (449,42)-(449,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,43)-(449,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithAnnotations(__SyntaxAnnotation");
            #line hidden
            #line (449,78)-(449,82) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (449,83)-(449,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,84)-(449,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (450,6)-(450,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (451,10)-(451,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Debug.Assert(this.GetType()");
            #line hidden
            #line (451,39)-(451,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,40)-(451,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (451,42)-(451,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,43)-(451,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("typeof(GreenSyntaxToken));");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (452,10)-(452,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (452,16)-(452,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (452,17)-(452,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (452,20)-(452,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (452,21)-(452,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken(this.Kind,");
            #line hidden
            #line (452,48)-(452,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (452,49)-(452,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.FullWidth,");
            #line hidden
            #line (452,64)-(452,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (452,65)-(452,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (452,87)-(452,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (452,88)-(452,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (453,6)-(453,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (454,3)-(454,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (454,9)-(454,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (454,10)-(454,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (454,18)-(454,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (454,19)-(454,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (454,30)-(454,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (454,31)-(454,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Clone()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (455,3)-(455,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (456,10)-(456,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Debug.Assert(this.GetType()");
            #line hidden
            #line (456,39)-(456,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (456,40)-(456,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (456,42)-(456,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (456,43)-(456,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("typeof(GreenSyntaxToken));");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (457,4)-(457,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (457,10)-(457,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,11)-(457,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (457,14)-(457,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,15)-(457,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken(this.Kind,");
            #line hidden
            #line (457,42)-(457,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,43)-(457,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.FullWidth,");
            #line hidden
            #line (457,58)-(457,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,59)-(457,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetDiagnostics(),");
            #line hidden
            #line (457,76)-(457,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,77)-(457,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (458,3)-(458,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (459,6)-(459,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (459,12)-(459,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,13)-(459,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (459,21)-(459,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,22)-(459,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TResult");
            #line hidden
            #line (459,29)-(459,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,30)-(459,128) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Accept<TResult>(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor<TResult>");
            #line hidden
            #line (459,128)-(459,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,129)-(459,137) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (460,6)-(460,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (461,10)-(461,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (461,16)-(461,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (461,17)-(461,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor.VisitToken(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (462,6)-(462,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (463,6)-(463,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (463,12)-(463,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,13)-(463,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (463,21)-(463,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,22)-(463,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (463,26)-(463,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,27)-(463,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Accept(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor");
            #line hidden
            #line (463,107)-(463,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,108)-(463,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (464,6)-(464,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (465,10)-(465,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor.VisitToken(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (466,6)-(466,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (467,6)-(467,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (467,15)-(467,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,16)-(467,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (467,24)-(467,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,25)-(467,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (467,29)-(467,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,30)-(467,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WriteTokenTo(System.IO.TextWriter");
            #line hidden
            #line (467,63)-(467,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,64)-(467,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("writer,");
            #line hidden
            #line (467,71)-(467,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,72)-(467,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (467,76)-(467,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,77)-(467,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (467,85)-(467,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,86)-(467,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (467,90)-(467,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,91)-(467,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (468,6)-(468,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (469,10)-(469,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (469,12)-(469,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (469,13)-(469,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(leading)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (470,10)-(470,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (471,14)-(471,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (471,17)-(471,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (471,18)-(471,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia");
            #line hidden
            #line (471,24)-(471,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (471,25)-(471,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (471,26)-(471,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (471,27)-(471,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetLeadingTrivia();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (472,14)-(472,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (472,16)-(472,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (472,17)-(472,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trivia");
            #line hidden
            #line (472,24)-(472,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (472,25)-(472,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (472,27)-(472,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (472,28)-(472,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (473,14)-(473,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (474,18)-(474,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia.WriteTo(writer);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (475,14)-(475,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (476,10)-(476,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (477,10)-(477,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("writer.Write(this.Text);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (478,10)-(478,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (478,12)-(478,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (478,13)-(478,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (479,10)-(479,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (480,14)-(480,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (480,17)-(480,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (480,18)-(480,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia");
            #line hidden
            #line (480,24)-(480,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (480,25)-(480,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (480,26)-(480,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (480,27)-(480,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetTrailingTrivia();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (481,14)-(481,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (481,16)-(481,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (481,17)-(481,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trivia");
            #line hidden
            #line (481,24)-(481,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (481,25)-(481,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (481,27)-(481,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (481,28)-(481,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (482,14)-(482,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (483,18)-(483,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia.WriteTo(writer);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (484,14)-(484,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (485,10)-(485,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (486,6)-(486,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (488,6)-(488,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (488,14)-(488,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,15)-(488,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (488,20)-(488,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,21)-(488,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingTokenWithTrivia");
            #line hidden
            #line (488,43)-(488,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,44)-(488,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (488,45)-(488,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,46)-(488,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (489,6)-(489,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (490,10)-(490,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (490,18)-(490,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (490,19)-(490,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingTokenWithTrivia(");
            #line hidden
            #line (490,43)-(490,47) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (490,48)-(490,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (490,58)-(490,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (490,59)-(490,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (490,64)-(490,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (490,65)-(490,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (490,77)-(490,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (490,78)-(490,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (490,86)-(490,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (490,87)-(490,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (490,99)-(490,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (490,100)-(490,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (491,14)-(491,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (491,15)-(491,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (491,16)-(491,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (491,26)-(491,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (491,27)-(491,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (491,35)-(491,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (491,36)-(491,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (492,10)-(492,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (493,14)-(493,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.flags");
            #line hidden
            #line (493,24)-(493,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (493,25)-(493,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&=");
            #line hidden
            #line (493,27)-(493,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (493,28)-(493,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("~NodeFlags.IsNotMissing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (494,10)-(494,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (495,10)-(495,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (495,18)-(495,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,19)-(495,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingTokenWithTrivia(");
            #line hidden
            #line (495,43)-(495,47) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (495,48)-(495,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (495,58)-(495,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,59)-(495,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (495,64)-(495,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,65)-(495,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (495,77)-(495,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,78)-(495,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (495,86)-(495,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,87)-(495,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (495,99)-(495,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,100)-(495,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing,");
            #line hidden
            #line (495,109)-(495,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,110)-(495,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (495,127)-(495,131) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (495,132)-(495,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,133)-(495,145) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (495,145)-(495,146) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,146)-(495,164) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (495,165)-(495,169) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (495,170)-(495,171) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (495,171)-(495,183) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (496,14)-(496,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (496,15)-(496,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,16)-(496,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (496,26)-(496,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,27)-(496,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (496,35)-(496,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,36)-(496,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing,");
            #line hidden
            #line (496,45)-(496,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,46)-(496,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (496,58)-(496,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,59)-(496,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (497,10)-(497,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (498,14)-(498,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.flags");
            #line hidden
            #line (498,24)-(498,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,25)-(498,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&=");
            #line hidden
            #line (498,27)-(498,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,28)-(498,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("~NodeFlags.IsNotMissing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (499,10)-(499,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (500,10)-(500,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (500,16)-(500,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,17)-(500,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (500,25)-(500,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,26)-(500,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (500,32)-(500,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,33)-(500,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Text");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (501,10)-(501,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (502,14)-(502,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("get");
            #line hidden
            #line (502,17)-(502,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,18)-(502,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (502,19)-(502,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,20)-(502,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (502,26)-(502,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,27)-(502,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string.Empty;");
            #line hidden
            #line (502,40)-(502,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,41)-(502,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (503,10)-(503,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (504,10)-(504,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (504,16)-(504,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,17)-(504,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (504,25)-(504,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,26)-(504,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("object");
            #line hidden
            #line (504,32)-(504,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,33)-(504,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Value");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (505,10)-(505,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (506,14)-(506,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("get");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (507,14)-(507,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (508,18)-(508,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (508,20)-(508,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (508,21)-(508,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (508,23)-(508,27) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (508,28)-(508,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.SyntaxFacts.IsIdentifier(this.Kind))");
            #line hidden
            #line (508,82)-(508,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (508,83)-(508,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (508,89)-(508,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (508,90)-(508,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string.Empty;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (509,18)-(509,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("else");
            #line hidden
            #line (509,22)-(509,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,23)-(509,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (509,29)-(509,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,30)-(509,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (510,14)-(510,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (511,10)-(511,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (512,10)-(512,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (512,16)-(512,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (512,17)-(512,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (512,25)-(512,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (512,26)-(512,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (512,47)-(512,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (512,48)-(512,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithLeadingTrivia(__GreenNode?");
            #line hidden
            #line (512,83)-(512,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (512,84)-(512,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (513,10)-(513,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (514,14)-(514,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (514,20)-(514,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,21)-(514,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (514,24)-(514,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,25)-(514,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingTokenWithTrivia(this.Kind,");
            #line hidden
            #line (514,58)-(514,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,59)-(514,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (514,66)-(514,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,67)-(514,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TrailingField,");
            #line hidden
            #line (514,86)-(514,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,87)-(514,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (514,109)-(514,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (514,110)-(514,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (515,10)-(515,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (516,10)-(516,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (516,16)-(516,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (516,17)-(516,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (516,25)-(516,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (516,26)-(516,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (516,47)-(516,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (516,48)-(516,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithTrailingTrivia(__GreenNode?");
            #line hidden
            #line (516,84)-(516,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (516,85)-(516,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (517,10)-(517,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (518,14)-(518,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (518,20)-(518,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (518,21)-(518,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (518,24)-(518,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (518,25)-(518,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingTokenWithTrivia(this.Kind,");
            #line hidden
            #line (518,58)-(518,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (518,59)-(518,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.LeadingField,");
            #line hidden
            #line (518,77)-(518,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (518,78)-(518,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (518,85)-(518,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (518,86)-(518,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (518,108)-(518,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (518,109)-(518,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (519,10)-(519,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (520,10)-(520,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (520,16)-(520,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (520,17)-(520,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (520,25)-(520,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (520,26)-(520,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (520,46)-(520,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (520,47)-(520,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithDiagnostics(__DiagnosticInfo");
            #line hidden
            #line (520,80)-(520,84) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (520,85)-(520,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (520,86)-(520,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (521,10)-(521,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (522,14)-(522,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (522,20)-(522,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (522,21)-(522,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (522,24)-(522,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (522,25)-(522,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingTokenWithTrivia(this.Kind,");
            #line hidden
            #line (522,58)-(522,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (522,59)-(522,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.LeadingField,");
            #line hidden
            #line (522,77)-(522,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (522,78)-(522,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TrailingField,");
            #line hidden
            #line (522,97)-(522,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (522,98)-(522,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (522,110)-(522,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (522,111)-(522,134) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (523,10)-(523,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (524,10)-(524,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (524,16)-(524,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (524,17)-(524,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (524,25)-(524,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (524,26)-(524,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (524,46)-(524,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (524,47)-(524,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithAnnotations(__SyntaxAnnotation");
            #line hidden
            #line (524,82)-(524,86) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (524,87)-(524,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (524,88)-(524,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (525,10)-(525,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (526,14)-(526,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (526,20)-(526,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,21)-(526,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (526,24)-(526,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,25)-(526,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingTokenWithTrivia(this.Kind,");
            #line hidden
            #line (526,58)-(526,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,59)-(526,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.LeadingField,");
            #line hidden
            #line (526,77)-(526,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,78)-(526,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TrailingField,");
            #line hidden
            #line (526,97)-(526,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,98)-(526,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (526,120)-(526,121) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (526,121)-(526,134) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (527,10)-(527,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (528,7)-(528,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (528,13)-(528,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (528,14)-(528,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (528,22)-(528,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (528,23)-(528,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (528,34)-(528,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (528,35)-(528,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Clone()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (529,7)-(529,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t    ");
            #line (530,8)-(530,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (530,14)-(530,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (530,15)-(530,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (530,18)-(530,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (530,19)-(530,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingTokenWithTrivia(this.Kind,");
            #line hidden
            #line (530,52)-(530,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (530,53)-(530,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.LeadingField,");
            #line hidden
            #line (530,71)-(530,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (530,72)-(530,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TrailingField,");
            #line hidden
            #line (530,91)-(530,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (530,92)-(530,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (530,114)-(530,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (530,115)-(530,138) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (531,7)-(531,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (532,6)-(532,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (534,6)-(534,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (534,14)-(534,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (534,15)-(534,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (534,20)-(534,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (534,21)-(534,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifier");
            #line hidden
            #line (534,37)-(534,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (534,38)-(534,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (534,39)-(534,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (534,40)-(534,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (535,6)-(535,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (536,10)-(536,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (536,19)-(536,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (536,20)-(536,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (536,28)-(536,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (536,29)-(536,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (536,35)-(536,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (536,36)-(536,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TextField;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (537,10)-(537,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (537,18)-(537,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (537,19)-(537,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifier(");
            #line hidden
            #line (537,37)-(537,41) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (537,42)-(537,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (537,52)-(537,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (537,53)-(537,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (537,58)-(537,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (537,59)-(537,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (537,65)-(537,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (537,66)-(537,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (538,14)-(538,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (538,15)-(538,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (538,16)-(538,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (538,26)-(538,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (538,27)-(538,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text.Length)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (539,10)-(539,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (540,14)-(540,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField");
            #line hidden
            #line (540,28)-(540,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (540,29)-(540,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (540,30)-(540,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (540,31)-(540,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (541,10)-(541,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (542,10)-(542,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (542,18)-(542,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (542,19)-(542,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifier(");
            #line hidden
            #line (542,37)-(542,41) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (542,42)-(542,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (542,52)-(542,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (542,53)-(542,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (542,58)-(542,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (542,59)-(542,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (542,65)-(542,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (542,66)-(542,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (542,71)-(542,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (542,72)-(542,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (542,89)-(542,93) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (542,94)-(542,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (542,95)-(542,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (542,107)-(542,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (542,108)-(542,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (542,127)-(542,131) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (542,132)-(542,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (542,133)-(542,145) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (543,14)-(543,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (543,15)-(543,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (543,16)-(543,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (543,26)-(543,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (543,27)-(543,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text.Length,");
            #line hidden
            #line (543,39)-(543,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (543,40)-(543,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (543,52)-(543,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (543,53)-(543,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (544,10)-(544,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (545,14)-(545,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField");
            #line hidden
            #line (545,28)-(545,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (545,29)-(545,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (545,30)-(545,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (545,31)-(545,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (546,10)-(546,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (547,10)-(547,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (547,16)-(547,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (547,17)-(547,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (547,25)-(547,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (547,26)-(547,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (547,32)-(547,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (547,33)-(547,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Text");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (548,10)-(548,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (549,14)-(549,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("get");
            #line hidden
            #line (549,17)-(549,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (549,18)-(549,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (549,19)-(549,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (549,20)-(549,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (549,26)-(549,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (549,27)-(549,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField;");
            #line hidden
            #line (549,42)-(549,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (549,43)-(549,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (550,10)-(550,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (551,10)-(551,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (551,16)-(551,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (551,17)-(551,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (551,25)-(551,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (551,26)-(551,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("object");
            #line hidden
            #line (551,32)-(551,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (551,33)-(551,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Value");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (552,10)-(552,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (553,14)-(553,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("get");
            #line hidden
            #line (553,17)-(553,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (553,18)-(553,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (553,19)-(553,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (553,20)-(553,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (553,26)-(553,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (553,27)-(553,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField;");
            #line hidden
            #line (553,42)-(553,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (553,43)-(553,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (554,10)-(554,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (555,10)-(555,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (555,16)-(555,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (555,17)-(555,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (555,25)-(555,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (555,26)-(555,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (555,32)-(555,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (555,33)-(555,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("ValueText");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (556,10)-(556,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (557,14)-(557,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("get");
            #line hidden
            #line (557,17)-(557,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (557,18)-(557,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (557,19)-(557,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (557,20)-(557,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (557,26)-(557,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (557,27)-(557,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField;");
            #line hidden
            #line (557,42)-(557,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (557,43)-(557,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (558,10)-(558,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (559,10)-(559,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (559,16)-(559,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (559,17)-(559,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (559,25)-(559,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (559,26)-(559,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (559,47)-(559,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (559,48)-(559,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithLeadingTrivia(__GreenNode");
            #line hidden
            #line (559,82)-(559,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (559,83)-(559,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (560,10)-(560,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (561,14)-(561,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (561,20)-(561,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,21)-(561,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (561,24)-(561,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,25)-(561,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(this.Kind,");
            #line hidden
            #line (561,62)-(561,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,63)-(561,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ContextualKind,");
            #line hidden
            #line (561,83)-(561,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,84)-(561,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (561,99)-(561,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,100)-(561,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (561,115)-(561,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,116)-(561,123) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (561,123)-(561,124) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,124)-(561,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (561,129)-(561,130) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,130)-(561,152) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (561,152)-(561,153) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (561,153)-(561,176) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (562,10)-(562,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (563,10)-(563,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (563,16)-(563,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (563,17)-(563,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (563,25)-(563,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (563,26)-(563,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (563,47)-(563,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (563,48)-(563,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithTrailingTrivia(__GreenNode");
            #line hidden
            #line (563,83)-(563,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (563,84)-(563,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (564,10)-(564,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (565,14)-(565,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (565,20)-(565,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,21)-(565,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (565,24)-(565,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,25)-(565,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(this.Kind,");
            #line hidden
            #line (565,62)-(565,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,63)-(565,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ContextualKind,");
            #line hidden
            #line (565,83)-(565,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,84)-(565,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (565,99)-(565,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,100)-(565,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (565,115)-(565,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,116)-(565,121) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (565,121)-(565,122) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,122)-(565,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (565,129)-(565,130) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,130)-(565,152) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (565,152)-(565,153) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,153)-(565,176) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (566,10)-(566,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (567,10)-(567,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (567,16)-(567,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (567,17)-(567,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (567,25)-(567,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (567,26)-(567,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (567,46)-(567,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (567,47)-(567,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithDiagnostics(__DiagnosticInfo");
            #line hidden
            #line (567,80)-(567,84) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (567,85)-(567,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (567,86)-(567,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (568,10)-(568,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (569,14)-(569,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (569,20)-(569,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (569,21)-(569,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (569,24)-(569,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (569,25)-(569,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifier(this.Kind,");
            #line hidden
            #line (569,52)-(569,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (569,53)-(569,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.Text,");
            #line hidden
            #line (569,63)-(569,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (569,64)-(569,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (569,76)-(569,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (569,77)-(569,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (570,10)-(570,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (571,10)-(571,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (571,16)-(571,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (571,17)-(571,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (571,25)-(571,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (571,26)-(571,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (571,46)-(571,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (571,47)-(571,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithAnnotations(__SyntaxAnnotation");
            #line hidden
            #line (571,82)-(571,86) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (571,87)-(571,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (571,88)-(571,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (572,10)-(572,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (573,14)-(573,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (573,20)-(573,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (573,21)-(573,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (573,24)-(573,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (573,25)-(573,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifier(this.Kind,");
            #line hidden
            #line (573,52)-(573,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (573,53)-(573,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.Text,");
            #line hidden
            #line (573,63)-(573,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (573,64)-(573,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (573,86)-(573,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (573,87)-(573,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (574,10)-(574,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (575,7)-(575,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (575,13)-(575,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (575,14)-(575,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (575,22)-(575,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (575,23)-(575,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (575,34)-(575,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (575,35)-(575,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Clone()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (576,7)-(576,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t    ");
            #line (577,8)-(577,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (577,14)-(577,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (577,15)-(577,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (577,18)-(577,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (577,19)-(577,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifier(this.Kind,");
            #line hidden
            #line (577,46)-(577,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (577,47)-(577,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.Text,");
            #line hidden
            #line (577,57)-(577,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (577,58)-(577,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (577,80)-(577,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (577,81)-(577,104) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (578,7)-(578,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (579,6)-(579,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (581,6)-(581,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (581,14)-(581,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (581,15)-(581,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (581,20)-(581,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (581,21)-(581,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierExtended");
            #line hidden
            #line (581,45)-(581,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (581,46)-(581,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (581,47)-(581,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (581,48)-(581,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifier");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (582,6)-(582,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (583,10)-(583,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (583,19)-(583,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (583,20)-(583,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (583,28)-(583,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (583,30)-(583,34) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (583,35)-(583,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (583,45)-(583,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (583,46)-(583,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("contextualKind;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (584,10)-(584,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (584,19)-(584,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (584,20)-(584,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (584,28)-(584,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (584,29)-(584,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (584,35)-(584,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (584,36)-(584,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (585,10)-(585,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (585,18)-(585,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (585,19)-(585,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierExtended(");
            #line hidden
            #line (585,45)-(585,49) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (585,50)-(585,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (585,60)-(585,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (585,61)-(585,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (585,66)-(585,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (585,68)-(585,72) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (585,73)-(585,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (585,83)-(585,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (585,84)-(585,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("contextualKind,");
            #line hidden
            #line (585,99)-(585,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (585,100)-(585,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (585,106)-(585,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (585,107)-(585,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (585,112)-(585,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (585,113)-(585,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (585,119)-(585,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (585,120)-(585,130) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (586,14)-(586,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (586,15)-(586,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (586,16)-(586,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (586,26)-(586,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (586,27)-(586,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (587,10)-(587,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (588,14)-(588,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind");
            #line hidden
            #line (588,33)-(588,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (588,34)-(588,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (588,35)-(588,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (588,36)-(588,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("contextualKind;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (589,14)-(589,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText");
            #line hidden
            #line (589,28)-(589,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (589,29)-(589,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (589,30)-(589,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (589,31)-(589,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (590,10)-(590,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (591,10)-(591,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (591,18)-(591,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (591,19)-(591,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierExtended(");
            #line hidden
            #line (591,45)-(591,49) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (591,50)-(591,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (591,60)-(591,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (591,61)-(591,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (591,66)-(591,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (591,68)-(591,72) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (591,73)-(591,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (591,83)-(591,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (591,84)-(591,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("contextualKind,");
            #line hidden
            #line (591,99)-(591,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (591,100)-(591,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (591,106)-(591,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (591,107)-(591,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (591,112)-(591,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (591,113)-(591,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (591,119)-(591,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (591,120)-(591,130) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText,");
            #line hidden
            #line (591,130)-(591,131) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (591,131)-(591,147) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (591,148)-(591,152) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (591,153)-(591,154) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (591,154)-(591,166) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (591,166)-(591,167) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (591,167)-(591,185) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (591,186)-(591,190) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (591,191)-(591,192) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (591,192)-(591,204) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (592,14)-(592,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (592,15)-(592,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (592,16)-(592,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (592,26)-(592,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (592,27)-(592,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (592,32)-(592,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (592,33)-(592,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (592,45)-(592,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (592,46)-(592,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (593,10)-(593,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (594,14)-(594,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind");
            #line hidden
            #line (594,33)-(594,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (594,34)-(594,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (594,35)-(594,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (594,36)-(594,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("contextualKind;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (595,14)-(595,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText");
            #line hidden
            #line (595,28)-(595,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (595,29)-(595,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (595,30)-(595,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (595,31)-(595,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (596,10)-(596,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (597,10)-(597,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (597,16)-(597,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (597,17)-(597,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (597,25)-(597,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (597,27)-(597,31) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (597,32)-(597,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (597,42)-(597,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (597,43)-(597,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("ContextualKind");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (598,10)-(598,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (599,14)-(599,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("get");
            #line hidden
            #line (599,17)-(599,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (599,18)-(599,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (599,19)-(599,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (599,20)-(599,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (599,26)-(599,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (599,27)-(599,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind;");
            #line hidden
            #line (599,47)-(599,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (599,48)-(599,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (600,10)-(600,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (601,10)-(601,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (601,16)-(601,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (601,17)-(601,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (601,25)-(601,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (601,26)-(601,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (601,32)-(601,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (601,33)-(601,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("ValueText");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (602,10)-(602,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (603,14)-(603,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("get");
            #line hidden
            #line (603,17)-(603,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (603,18)-(603,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (603,19)-(603,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (603,20)-(603,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (603,26)-(603,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (603,27)-(603,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText;");
            #line hidden
            #line (603,42)-(603,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (603,43)-(603,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (604,10)-(604,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (605,10)-(605,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (605,16)-(605,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (605,17)-(605,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (605,25)-(605,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (605,26)-(605,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("object");
            #line hidden
            #line (605,32)-(605,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (605,33)-(605,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Value");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (606,10)-(606,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (607,14)-(607,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("get");
            #line hidden
            #line (607,17)-(607,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (607,18)-(607,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (607,19)-(607,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (607,20)-(607,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (607,26)-(607,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (607,27)-(607,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText;");
            #line hidden
            #line (607,42)-(607,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (607,43)-(607,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (608,10)-(608,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (609,10)-(609,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (609,16)-(609,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (609,17)-(609,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (609,25)-(609,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (609,26)-(609,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (609,47)-(609,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (609,48)-(609,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithLeadingTrivia(__GreenNode");
            #line hidden
            #line (609,82)-(609,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (609,83)-(609,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (610,10)-(610,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (611,14)-(611,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (611,20)-(611,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (611,21)-(611,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (611,24)-(611,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (611,25)-(611,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(this.Kind,");
            #line hidden
            #line (611,62)-(611,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (611,63)-(611,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind,");
            #line hidden
            #line (611,83)-(611,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (611,84)-(611,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (611,99)-(611,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (611,100)-(611,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText,");
            #line hidden
            #line (611,115)-(611,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (611,116)-(611,123) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (611,123)-(611,124) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (611,124)-(611,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (611,129)-(611,130) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (611,130)-(611,152) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (611,152)-(611,153) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (611,153)-(611,176) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (612,10)-(612,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (613,10)-(613,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (613,16)-(613,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (613,17)-(613,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (613,25)-(613,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (613,26)-(613,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (613,47)-(613,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (613,48)-(613,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithTrailingTrivia(__GreenNode");
            #line hidden
            #line (613,83)-(613,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (613,84)-(613,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (614,10)-(614,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (615,14)-(615,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (615,20)-(615,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (615,21)-(615,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (615,24)-(615,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (615,25)-(615,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(this.Kind,");
            #line hidden
            #line (615,62)-(615,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (615,63)-(615,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind,");
            #line hidden
            #line (615,83)-(615,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (615,84)-(615,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (615,99)-(615,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (615,100)-(615,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText,");
            #line hidden
            #line (615,115)-(615,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (615,116)-(615,121) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (615,121)-(615,122) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (615,122)-(615,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (615,129)-(615,130) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (615,130)-(615,152) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (615,152)-(615,153) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (615,153)-(615,176) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (616,10)-(616,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (617,10)-(617,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (617,16)-(617,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (617,17)-(617,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (617,25)-(617,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (617,26)-(617,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (617,46)-(617,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (617,47)-(617,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithDiagnostics(__DiagnosticInfo");
            #line hidden
            #line (617,80)-(617,84) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (617,85)-(617,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (617,86)-(617,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (618,10)-(618,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (619,14)-(619,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (619,20)-(619,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (619,21)-(619,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (619,24)-(619,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (619,25)-(619,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierExtended(this.Kind,");
            #line hidden
            #line (619,60)-(619,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (619,61)-(619,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind,");
            #line hidden
            #line (619,81)-(619,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (619,82)-(619,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (619,97)-(619,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (619,98)-(619,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText,");
            #line hidden
            #line (619,113)-(619,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (619,114)-(619,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (619,126)-(619,127) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (619,127)-(619,150) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (620,10)-(620,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (621,10)-(621,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (621,16)-(621,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (621,17)-(621,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (621,25)-(621,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (621,26)-(621,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (621,46)-(621,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (621,47)-(621,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithAnnotations(__SyntaxAnnotation");
            #line hidden
            #line (621,82)-(621,86) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (621,87)-(621,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (621,88)-(621,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (622,10)-(622,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (623,14)-(623,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (623,20)-(623,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (623,21)-(623,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (623,24)-(623,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (623,25)-(623,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierExtended(this.Kind,");
            #line hidden
            #line (623,60)-(623,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (623,61)-(623,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind,");
            #line hidden
            #line (623,81)-(623,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (623,82)-(623,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (623,97)-(623,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (623,98)-(623,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText,");
            #line hidden
            #line (623,113)-(623,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (623,114)-(623,136) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (623,136)-(623,137) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (623,137)-(623,150) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (624,10)-(624,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (625,7)-(625,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (625,13)-(625,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (625,14)-(625,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (625,22)-(625,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (625,23)-(625,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (625,34)-(625,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (625,35)-(625,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Clone()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (626,7)-(626,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t    ");
            #line (627,8)-(627,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (627,14)-(627,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (627,15)-(627,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (627,18)-(627,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (627,19)-(627,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierExtended(this.Kind,");
            #line hidden
            #line (627,54)-(627,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (627,55)-(627,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind,");
            #line hidden
            #line (627,75)-(627,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (627,76)-(627,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (627,91)-(627,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (627,92)-(627,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText,");
            #line hidden
            #line (627,107)-(627,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (627,108)-(627,130) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (627,130)-(627,131) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (627,131)-(627,154) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (628,7)-(628,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (629,6)-(629,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (631,3)-(631,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (631,11)-(631,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (631,12)-(631,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (631,17)-(631,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (631,18)-(631,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrailingTrivia");
            #line hidden
            #line (631,52)-(631,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (631,53)-(631,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (631,54)-(631,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (631,55)-(631,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifier");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (632,6)-(632,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (633,10)-(633,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (633,17)-(633,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (633,18)-(633,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (633,26)-(633,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (633,27)-(633,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (633,39)-(633,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (633,40)-(633,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (634,10)-(634,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (634,18)-(634,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (634,19)-(634,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrailingTrivia(");
            #line hidden
            #line (634,55)-(634,59) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (634,60)-(634,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (634,70)-(634,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (634,71)-(634,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (634,76)-(634,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (634,77)-(634,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (634,83)-(634,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (634,84)-(634,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (634,89)-(634,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (634,90)-(634,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (634,102)-(634,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (634,103)-(634,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (635,14)-(635,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (635,15)-(635,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (635,16)-(635,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (635,26)-(635,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (635,27)-(635,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (636,10)-(636,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (637,14)-(637,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (637,16)-(637,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (637,17)-(637,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing");
            #line hidden
            #line (637,26)-(637,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (637,27)-(637,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (637,29)-(637,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (637,30)-(637,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (638,14)-(638,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (639,18)-(639,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (640,18)-(640,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing");
            #line hidden
            #line (640,27)-(640,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (640,28)-(640,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (640,29)-(640,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (640,30)-(640,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (641,14)-(641,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (642,10)-(642,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (643,10)-(643,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (643,18)-(643,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (643,19)-(643,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrailingTrivia(");
            #line hidden
            #line (643,55)-(643,59) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (643,60)-(643,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (643,70)-(643,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (643,71)-(643,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (643,76)-(643,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (643,77)-(643,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (643,83)-(643,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (643,84)-(643,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (643,89)-(643,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (643,90)-(643,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (643,102)-(643,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (643,103)-(643,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing,");
            #line hidden
            #line (643,112)-(643,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (643,113)-(643,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (643,130)-(643,134) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (643,135)-(643,136) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (643,136)-(643,148) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (643,148)-(643,149) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (643,149)-(643,167) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (643,168)-(643,172) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (643,173)-(643,174) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (643,174)-(643,186) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (644,14)-(644,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (644,15)-(644,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (644,16)-(644,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (644,26)-(644,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (644,27)-(644,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (644,32)-(644,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (644,33)-(644,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (644,45)-(644,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (644,46)-(644,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (645,10)-(645,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (646,14)-(646,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (646,16)-(646,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (646,17)-(646,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing");
            #line hidden
            #line (646,26)-(646,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (646,27)-(646,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (646,29)-(646,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (646,30)-(646,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (647,14)-(647,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (648,18)-(648,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (649,18)-(649,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing");
            #line hidden
            #line (649,27)-(649,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (649,28)-(649,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (649,29)-(649,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (649,30)-(649,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (650,14)-(650,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (651,10)-(651,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (652,10)-(652,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (652,16)-(652,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (652,17)-(652,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (652,25)-(652,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (652,26)-(652,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (652,38)-(652,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (652,39)-(652,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetTrailingTrivia()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (653,10)-(653,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (654,14)-(654,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (654,20)-(654,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (654,21)-(654,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (655,10)-(655,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (656,10)-(656,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (656,16)-(656,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (656,17)-(656,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (656,25)-(656,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (656,26)-(656,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (656,47)-(656,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (656,48)-(656,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithLeadingTrivia(__GreenNode?");
            #line hidden
            #line (656,83)-(656,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (656,84)-(656,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (657,10)-(657,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (658,14)-(658,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (658,20)-(658,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (658,21)-(658,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (658,24)-(658,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (658,25)-(658,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(this.Kind,");
            #line hidden
            #line (658,62)-(658,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (658,63)-(658,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ContextualKind,");
            #line hidden
            #line (658,83)-(658,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (658,84)-(658,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (658,99)-(658,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (658,100)-(658,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (658,115)-(658,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (658,116)-(658,123) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (658,123)-(658,124) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (658,124)-(658,134) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing,");
            #line hidden
            #line (658,134)-(658,135) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (658,135)-(658,157) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (658,157)-(658,158) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (658,158)-(658,181) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (659,10)-(659,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (660,10)-(660,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (660,16)-(660,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (660,17)-(660,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (660,25)-(660,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (660,26)-(660,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (660,47)-(660,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (660,48)-(660,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithTrailingTrivia(__GreenNode?");
            #line hidden
            #line (660,84)-(660,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (660,85)-(660,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (661,10)-(661,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (662,14)-(662,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (662,20)-(662,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (662,21)-(662,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (662,24)-(662,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (662,25)-(662,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrailingTrivia(this.Kind,");
            #line hidden
            #line (662,70)-(662,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (662,71)-(662,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (662,86)-(662,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (662,87)-(662,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (662,94)-(662,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (662,95)-(662,117) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (662,117)-(662,118) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (662,118)-(662,141) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (663,10)-(663,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (664,10)-(664,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (664,16)-(664,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (664,17)-(664,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (664,25)-(664,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (664,26)-(664,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (664,46)-(664,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (664,47)-(664,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithDiagnostics(__DiagnosticInfo");
            #line hidden
            #line (664,80)-(664,84) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (664,85)-(664,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (664,86)-(664,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (665,10)-(665,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (666,14)-(666,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (666,20)-(666,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (666,21)-(666,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (666,24)-(666,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (666,25)-(666,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrailingTrivia(this.Kind,");
            #line hidden
            #line (666,70)-(666,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (666,71)-(666,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (666,86)-(666,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (666,87)-(666,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing,");
            #line hidden
            #line (666,97)-(666,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (666,98)-(666,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (666,110)-(666,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (666,111)-(666,134) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (667,10)-(667,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (668,10)-(668,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (668,16)-(668,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (668,17)-(668,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (668,25)-(668,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (668,26)-(668,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (668,46)-(668,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (668,47)-(668,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithAnnotations(__SyntaxAnnotation");
            #line hidden
            #line (668,82)-(668,86) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (668,87)-(668,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (668,88)-(668,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (669,10)-(669,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (670,14)-(670,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (670,20)-(670,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (670,21)-(670,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (670,24)-(670,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (670,25)-(670,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrailingTrivia(this.Kind,");
            #line hidden
            #line (670,70)-(670,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (670,71)-(670,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (670,86)-(670,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (670,87)-(670,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing,");
            #line hidden
            #line (670,97)-(670,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (670,98)-(670,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (670,120)-(670,121) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (670,121)-(670,134) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (671,10)-(671,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (672,7)-(672,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (672,13)-(672,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (672,14)-(672,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (672,22)-(672,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (672,23)-(672,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (672,34)-(672,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (672,35)-(672,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Clone()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (673,7)-(673,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t    ");
            #line (674,8)-(674,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (674,14)-(674,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (674,15)-(674,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (674,18)-(674,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (674,19)-(674,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrailingTrivia(this.Kind,");
            #line hidden
            #line (674,64)-(674,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (674,65)-(674,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (674,80)-(674,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (674,81)-(674,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing,");
            #line hidden
            #line (674,91)-(674,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (674,92)-(674,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (674,114)-(674,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (674,115)-(674,138) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (675,7)-(675,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (676,6)-(676,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (678,6)-(678,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (678,14)-(678,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (678,15)-(678,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (678,20)-(678,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (678,21)-(678,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia");
            #line hidden
            #line (678,47)-(678,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (678,48)-(678,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (678,49)-(678,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (678,50)-(678,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierExtended");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (679,6)-(679,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (680,10)-(680,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (680,17)-(680,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (680,18)-(680,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (680,26)-(680,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (680,27)-(680,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (680,39)-(680,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (680,40)-(680,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (681,10)-(681,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (681,17)-(681,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (681,18)-(681,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (681,26)-(681,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (681,27)-(681,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (681,39)-(681,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (681,40)-(681,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (682,10)-(682,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (682,18)-(682,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (682,19)-(682,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (683,15)-(683,19) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (683,20)-(683,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (683,30)-(683,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (683,31)-(683,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (684,15)-(684,19) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (684,20)-(684,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (684,30)-(684,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (684,31)-(684,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("contextualKind,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (685,14)-(685,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (685,20)-(685,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (685,21)-(685,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (686,14)-(686,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (686,20)-(686,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (686,21)-(686,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (687,14)-(687,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (687,26)-(687,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (687,27)-(687,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (688,14)-(688,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (688,26)-(688,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (688,27)-(688,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (689,14)-(689,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (689,15)-(689,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (689,16)-(689,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (689,26)-(689,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (689,27)-(689,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("contextualKind,");
            #line hidden
            #line (689,42)-(689,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (689,43)-(689,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (689,48)-(689,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (689,49)-(689,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (690,10)-(690,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (691,14)-(691,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (691,16)-(691,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (691,17)-(691,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(leading");
            #line hidden
            #line (691,25)-(691,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (691,26)-(691,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (691,28)-(691,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (691,29)-(691,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (692,14)-(692,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (693,18)-(693,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(leading);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (694,18)-(694,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading");
            #line hidden
            #line (694,26)-(694,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (694,27)-(694,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (694,28)-(694,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (694,29)-(694,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (695,14)-(695,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (696,14)-(696,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (696,16)-(696,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (696,17)-(696,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing");
            #line hidden
            #line (696,26)-(696,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (696,27)-(696,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (696,29)-(696,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (696,30)-(696,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (697,14)-(697,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (698,18)-(698,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (699,18)-(699,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing");
            #line hidden
            #line (699,27)-(699,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (699,28)-(699,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (699,29)-(699,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (699,30)-(699,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (700,14)-(700,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (701,10)-(701,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (702,10)-(702,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (702,18)-(702,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (702,19)-(702,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (703,15)-(703,19) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (703,20)-(703,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (703,30)-(703,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (703,31)-(703,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (704,15)-(704,19) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (704,20)-(704,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (704,30)-(704,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (704,31)-(704,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("contextualKind,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (705,14)-(705,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (705,20)-(705,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (705,21)-(705,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (706,14)-(706,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (706,20)-(706,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (706,21)-(706,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (707,14)-(707,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (707,26)-(707,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (707,27)-(707,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (708,14)-(708,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (708,26)-(708,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (708,27)-(708,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (709,14)-(709,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (709,31)-(709,35) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (709,36)-(709,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (709,37)-(709,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (710,14)-(710,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (710,33)-(710,37) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (710,38)-(710,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (710,39)-(710,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (711,14)-(711,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (711,15)-(711,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (711,16)-(711,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (711,26)-(711,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (711,27)-(711,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("contextualKind,");
            #line hidden
            #line (711,42)-(711,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (711,43)-(711,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (711,48)-(711,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (711,49)-(711,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText,");
            #line hidden
            #line (711,59)-(711,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (711,60)-(711,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (711,72)-(711,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (711,73)-(711,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (712,10)-(712,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (713,14)-(713,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (713,16)-(713,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (713,17)-(713,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(leading");
            #line hidden
            #line (713,25)-(713,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (713,26)-(713,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (713,28)-(713,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (713,29)-(713,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (714,14)-(714,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (715,18)-(715,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(leading);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (716,18)-(716,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading");
            #line hidden
            #line (716,26)-(716,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (716,27)-(716,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (716,28)-(716,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (716,29)-(716,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (717,14)-(717,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (718,14)-(718,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (718,16)-(718,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (718,17)-(718,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing");
            #line hidden
            #line (718,26)-(718,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (718,27)-(718,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (718,29)-(718,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (718,30)-(718,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (719,14)-(719,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (720,18)-(720,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (721,18)-(721,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing");
            #line hidden
            #line (721,27)-(721,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (721,28)-(721,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (721,29)-(721,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (721,30)-(721,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (722,14)-(722,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (723,10)-(723,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (724,10)-(724,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (724,16)-(724,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (724,17)-(724,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (724,25)-(724,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (724,26)-(724,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (724,38)-(724,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (724,39)-(724,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetLeadingTrivia()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (725,10)-(725,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (726,14)-(726,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (726,20)-(726,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (726,21)-(726,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (727,10)-(727,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (728,10)-(728,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (728,16)-(728,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (728,17)-(728,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (728,25)-(728,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (728,26)-(728,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (728,38)-(728,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (728,39)-(728,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetTrailingTrivia()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (729,10)-(729,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (730,14)-(730,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (730,20)-(730,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (730,21)-(730,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (731,10)-(731,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (732,10)-(732,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (732,16)-(732,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (732,17)-(732,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (732,25)-(732,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (732,26)-(732,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (732,47)-(732,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (732,48)-(732,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithLeadingTrivia(__GreenNode?");
            #line hidden
            #line (732,83)-(732,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (732,84)-(732,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (733,10)-(733,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (734,14)-(734,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (734,20)-(734,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (734,21)-(734,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (734,24)-(734,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (734,25)-(734,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(this.Kind,");
            #line hidden
            #line (734,62)-(734,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (734,63)-(734,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind,");
            #line hidden
            #line (734,83)-(734,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (734,84)-(734,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (734,99)-(734,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (734,100)-(734,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText,");
            #line hidden
            #line (734,115)-(734,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (734,116)-(734,123) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (734,123)-(734,124) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (734,124)-(734,134) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing,");
            #line hidden
            #line (734,134)-(734,135) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (734,135)-(734,157) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (734,157)-(734,158) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (734,158)-(734,181) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (735,10)-(735,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (736,10)-(736,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (736,16)-(736,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (736,17)-(736,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (736,25)-(736,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (736,26)-(736,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (736,47)-(736,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (736,48)-(736,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithTrailingTrivia(__GreenNode?");
            #line hidden
            #line (736,84)-(736,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (736,85)-(736,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (737,10)-(737,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (738,14)-(738,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (738,20)-(738,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (738,21)-(738,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (738,24)-(738,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (738,25)-(738,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(this.Kind,");
            #line hidden
            #line (738,62)-(738,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (738,63)-(738,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind,");
            #line hidden
            #line (738,83)-(738,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (738,84)-(738,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (738,99)-(738,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (738,100)-(738,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText,");
            #line hidden
            #line (738,115)-(738,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (738,116)-(738,125) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading,");
            #line hidden
            #line (738,125)-(738,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (738,126)-(738,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (738,133)-(738,134) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (738,134)-(738,156) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (738,156)-(738,157) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (738,157)-(738,180) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (739,10)-(739,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (740,10)-(740,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (740,16)-(740,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (740,17)-(740,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (740,25)-(740,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (740,26)-(740,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (740,46)-(740,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (740,47)-(740,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithDiagnostics(__DiagnosticInfo");
            #line hidden
            #line (740,80)-(740,84) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (740,85)-(740,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (740,86)-(740,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (741,10)-(741,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (742,14)-(742,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (742,20)-(742,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (742,21)-(742,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (742,24)-(742,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (742,25)-(742,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(this.Kind,");
            #line hidden
            #line (742,62)-(742,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (742,63)-(742,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind,");
            #line hidden
            #line (742,83)-(742,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (742,84)-(742,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (742,99)-(742,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (742,100)-(742,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText,");
            #line hidden
            #line (742,115)-(742,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (742,116)-(742,125) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading,");
            #line hidden
            #line (742,125)-(742,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (742,126)-(742,136) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing,");
            #line hidden
            #line (742,136)-(742,137) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (742,137)-(742,149) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (742,149)-(742,150) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (742,150)-(742,173) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (743,10)-(743,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (744,10)-(744,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (744,16)-(744,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (744,17)-(744,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (744,25)-(744,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (744,26)-(744,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (744,46)-(744,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (744,47)-(744,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithAnnotations(__SyntaxAnnotation");
            #line hidden
            #line (744,82)-(744,86) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (744,87)-(744,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (744,88)-(744,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (745,10)-(745,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (746,14)-(746,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (746,20)-(746,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (746,21)-(746,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (746,24)-(746,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (746,25)-(746,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(this.Kind,");
            #line hidden
            #line (746,62)-(746,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (746,63)-(746,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind,");
            #line hidden
            #line (746,83)-(746,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (746,84)-(746,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (746,99)-(746,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (746,100)-(746,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText,");
            #line hidden
            #line (746,115)-(746,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (746,116)-(746,125) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading,");
            #line hidden
            #line (746,125)-(746,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (746,126)-(746,136) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing,");
            #line hidden
            #line (746,136)-(746,137) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (746,137)-(746,159) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (746,159)-(746,160) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (746,160)-(746,173) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (747,10)-(747,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (748,7)-(748,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (748,13)-(748,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (748,14)-(748,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (748,22)-(748,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (748,23)-(748,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (748,34)-(748,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (748,35)-(748,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Clone()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (749,7)-(749,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t    ");
            #line (750,8)-(750,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (750,14)-(750,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (750,15)-(750,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (750,18)-(750,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (750,19)-(750,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxIdentifierWithTrivia(this.Kind,");
            #line hidden
            #line (750,56)-(750,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (750,57)-(750,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.contextualKind,");
            #line hidden
            #line (750,77)-(750,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (750,78)-(750,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (750,93)-(750,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (750,94)-(750,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.valueText,");
            #line hidden
            #line (750,109)-(750,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (750,110)-(750,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading,");
            #line hidden
            #line (750,119)-(750,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (750,120)-(750,130) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing,");
            #line hidden
            #line (750,130)-(750,131) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (750,131)-(750,153) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (750,153)-(750,154) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (750,154)-(750,177) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (751,7)-(751,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (752,6)-(752,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (754,6)-(754,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (754,14)-(754,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (754,15)-(754,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (754,20)-(754,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (754,21)-(754,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValue<T>");
            #line hidden
            #line (754,44)-(754,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (754,45)-(754,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (754,46)-(754,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (754,47)-(754,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (755,6)-(755,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (756,10)-(756,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (756,19)-(756,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (756,20)-(756,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (756,28)-(756,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (756,29)-(756,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (756,35)-(756,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (756,36)-(756,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TextField;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (757,10)-(757,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (757,19)-(757,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (757,20)-(757,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (757,28)-(757,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (757,29)-(757,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("T");
            #line hidden
            #line (757,30)-(757,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (757,31)-(757,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("ValueField;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (758,10)-(758,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (758,18)-(758,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (758,19)-(758,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValue(");
            #line hidden
            #line (758,41)-(758,45) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (758,46)-(758,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (758,56)-(758,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (758,57)-(758,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (758,62)-(758,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (758,63)-(758,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (758,69)-(758,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (758,70)-(758,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (758,75)-(758,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (758,76)-(758,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("T");
            #line hidden
            #line (758,77)-(758,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (758,78)-(758,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (759,14)-(759,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (759,15)-(759,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (759,16)-(759,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (759,26)-(759,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (759,27)-(759,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text.Length)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (760,10)-(760,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (761,14)-(761,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField");
            #line hidden
            #line (761,28)-(761,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (761,29)-(761,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (761,30)-(761,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (761,31)-(761,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (762,14)-(762,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField");
            #line hidden
            #line (762,29)-(762,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (762,30)-(762,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (762,31)-(762,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (762,32)-(762,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (763,10)-(763,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (764,10)-(764,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (764,18)-(764,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (764,19)-(764,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValue(");
            #line hidden
            #line (764,41)-(764,45) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (764,46)-(764,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (764,56)-(764,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (764,57)-(764,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (764,62)-(764,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (764,63)-(764,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (764,69)-(764,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (764,70)-(764,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (764,75)-(764,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (764,76)-(764,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("T");
            #line hidden
            #line (764,77)-(764,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (764,78)-(764,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value,");
            #line hidden
            #line (764,84)-(764,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (764,85)-(764,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (764,102)-(764,106) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (764,107)-(764,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (764,108)-(764,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (764,120)-(764,121) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (764,121)-(764,139) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (764,140)-(764,144) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (764,145)-(764,146) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (764,146)-(764,158) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (765,14)-(765,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (765,15)-(765,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (765,16)-(765,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (765,26)-(765,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (765,27)-(765,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text.Length,");
            #line hidden
            #line (765,39)-(765,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (765,40)-(765,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (765,52)-(765,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (765,53)-(765,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (766,10)-(766,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (767,14)-(767,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField");
            #line hidden
            #line (767,28)-(767,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (767,29)-(767,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (767,30)-(767,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (767,31)-(767,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (768,14)-(768,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField");
            #line hidden
            #line (768,29)-(768,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (768,30)-(768,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (768,31)-(768,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (768,32)-(768,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (769,10)-(769,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (770,10)-(770,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (770,16)-(770,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (770,17)-(770,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (770,25)-(770,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (770,26)-(770,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (770,32)-(770,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (770,33)-(770,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Text");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (771,10)-(771,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (772,14)-(772,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("get");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (773,14)-(773,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (774,18)-(774,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (774,24)-(774,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (774,25)-(774,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (775,14)-(775,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (776,10)-(776,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (777,10)-(777,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (777,16)-(777,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (777,17)-(777,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (777,25)-(777,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (777,26)-(777,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("object");
            #line hidden
            #line (777,32)-(777,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (777,33)-(777,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Value");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (778,10)-(778,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (779,14)-(779,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("get");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (780,14)-(780,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (781,18)-(781,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (781,24)-(781,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (781,25)-(781,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (782,14)-(782,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (783,10)-(783,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (784,10)-(784,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (784,16)-(784,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (784,17)-(784,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (784,25)-(784,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (784,26)-(784,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (784,32)-(784,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (784,33)-(784,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("ValueText");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (785,10)-(785,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (786,14)-(786,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("get");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (787,14)-(787,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (788,18)-(788,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (788,24)-(788,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (788,25)-(788,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.Convert.ToString(this.ValueField,");
            #line hidden
            #line (788,73)-(788,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (788,74)-(788,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.Globalization.CultureInfo.InvariantCulture);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (789,14)-(789,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (790,10)-(790,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (791,10)-(791,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (791,16)-(791,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (791,17)-(791,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (791,25)-(791,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (791,26)-(791,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (791,47)-(791,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (791,48)-(791,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithLeadingTrivia(__GreenNode");
            #line hidden
            #line (791,82)-(791,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (791,83)-(791,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (792,10)-(792,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (793,14)-(793,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (793,20)-(793,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (793,21)-(793,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (793,24)-(793,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (793,25)-(793,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValueAndTrivia<T>(this.Kind,");
            #line hidden
            #line (793,68)-(793,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (793,69)-(793,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (793,84)-(793,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (793,85)-(793,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField,");
            #line hidden
            #line (793,101)-(793,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (793,102)-(793,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (793,109)-(793,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (793,110)-(793,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (793,115)-(793,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (793,116)-(793,138) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (793,138)-(793,139) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (793,139)-(793,162) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (794,10)-(794,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (795,10)-(795,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (795,16)-(795,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (795,17)-(795,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (795,25)-(795,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (795,26)-(795,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (795,47)-(795,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (795,48)-(795,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithTrailingTrivia(__GreenNode");
            #line hidden
            #line (795,83)-(795,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (795,84)-(795,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (796,10)-(796,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (797,14)-(797,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (797,20)-(797,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (797,21)-(797,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (797,24)-(797,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (797,25)-(797,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValueAndTrivia<T>(this.Kind,");
            #line hidden
            #line (797,68)-(797,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (797,69)-(797,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (797,84)-(797,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (797,85)-(797,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField,");
            #line hidden
            #line (797,101)-(797,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (797,102)-(797,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (797,107)-(797,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (797,108)-(797,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (797,115)-(797,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (797,116)-(797,138) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (797,138)-(797,139) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (797,139)-(797,162) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (798,10)-(798,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (799,10)-(799,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (799,16)-(799,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (799,17)-(799,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (799,25)-(799,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (799,26)-(799,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (799,46)-(799,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (799,47)-(799,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithDiagnostics(__DiagnosticInfo");
            #line hidden
            #line (799,80)-(799,84) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (799,85)-(799,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (799,86)-(799,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (800,10)-(800,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (801,14)-(801,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (801,20)-(801,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (801,21)-(801,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (801,24)-(801,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (801,25)-(801,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValue<T>(this.Kind,");
            #line hidden
            #line (801,59)-(801,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (801,60)-(801,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (801,75)-(801,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (801,76)-(801,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField,");
            #line hidden
            #line (801,92)-(801,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (801,93)-(801,105) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (801,105)-(801,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (801,106)-(801,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (802,10)-(802,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (803,10)-(803,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (803,16)-(803,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (803,17)-(803,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (803,25)-(803,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (803,26)-(803,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (803,46)-(803,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (803,47)-(803,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithAnnotations(__SyntaxAnnotation");
            #line hidden
            #line (803,82)-(803,86) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (803,87)-(803,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (803,88)-(803,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (804,10)-(804,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (805,14)-(805,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (805,20)-(805,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (805,21)-(805,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (805,24)-(805,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (805,25)-(805,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValue<T>(this.Kind,");
            #line hidden
            #line (805,59)-(805,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (805,60)-(805,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (805,75)-(805,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (805,76)-(805,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField,");
            #line hidden
            #line (805,92)-(805,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (805,93)-(805,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (805,115)-(805,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (805,116)-(805,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (806,10)-(806,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (807,7)-(807,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (807,13)-(807,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (807,14)-(807,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (807,22)-(807,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (807,23)-(807,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (807,34)-(807,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (807,35)-(807,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Clone()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (808,7)-(808,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t    ");
            #line (809,8)-(809,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (809,14)-(809,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (809,15)-(809,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (809,18)-(809,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (809,19)-(809,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValue<T>(this.Kind,");
            #line hidden
            #line (809,53)-(809,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (809,54)-(809,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (809,69)-(809,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (809,70)-(809,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField,");
            #line hidden
            #line (809,86)-(809,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (809,87)-(809,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (809,109)-(809,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (809,110)-(809,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (810,7)-(810,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (811,6)-(811,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (813,6)-(813,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (813,14)-(813,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (813,15)-(813,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (813,20)-(813,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (813,21)-(813,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValueAndTrivia<T>");
            #line hidden
            #line (813,53)-(813,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (813,54)-(813,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (813,55)-(813,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (813,56)-(813,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValue<T>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (814,6)-(814,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (815,10)-(815,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (815,17)-(815,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (815,18)-(815,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (815,26)-(815,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (815,27)-(815,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (815,39)-(815,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (815,40)-(815,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (816,10)-(816,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (816,17)-(816,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (816,18)-(816,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (816,26)-(816,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (816,27)-(816,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (816,39)-(816,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (816,40)-(816,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (817,10)-(817,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (817,18)-(817,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (817,19)-(817,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValueAndTrivia(");
            #line hidden
            #line (817,50)-(817,54) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (817,55)-(817,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (817,65)-(817,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (817,66)-(817,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (817,71)-(817,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (817,72)-(817,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (817,78)-(817,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (817,79)-(817,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (817,84)-(817,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (817,85)-(817,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("T");
            #line hidden
            #line (817,86)-(817,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (817,87)-(817,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value,");
            #line hidden
            #line (817,93)-(817,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (817,94)-(817,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (817,106)-(817,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (817,107)-(817,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (817,115)-(817,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (817,116)-(817,128) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (817,128)-(817,129) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (817,129)-(817,138) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (818,14)-(818,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (818,15)-(818,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (818,16)-(818,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (818,26)-(818,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (818,27)-(818,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (818,32)-(818,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (818,33)-(818,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (819,10)-(819,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (820,14)-(820,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (820,16)-(820,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (820,17)-(820,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(leading");
            #line hidden
            #line (820,25)-(820,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (820,26)-(820,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (820,28)-(820,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (820,29)-(820,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (821,14)-(821,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (822,18)-(822,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(leading);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (823,18)-(823,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading");
            #line hidden
            #line (823,26)-(823,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (823,27)-(823,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (823,28)-(823,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (823,29)-(823,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (824,14)-(824,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (825,14)-(825,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (825,16)-(825,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (825,17)-(825,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing");
            #line hidden
            #line (825,26)-(825,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (825,27)-(825,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (825,29)-(825,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (825,30)-(825,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (826,14)-(826,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (827,18)-(827,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (828,18)-(828,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing");
            #line hidden
            #line (828,27)-(828,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (828,28)-(828,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (828,29)-(828,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (828,30)-(828,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (829,14)-(829,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (830,10)-(830,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (831,10)-(831,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (831,18)-(831,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (831,19)-(831,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValueAndTrivia(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (832,15)-(832,19) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (832,20)-(832,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (832,30)-(832,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (832,31)-(832,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (833,14)-(833,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (833,20)-(833,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (833,21)-(833,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (834,14)-(834,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("T");
            #line hidden
            #line (834,15)-(834,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (834,16)-(834,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (835,14)-(835,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (835,26)-(835,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (835,27)-(835,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (836,14)-(836,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (836,26)-(836,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (836,27)-(836,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (837,14)-(837,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (837,31)-(837,35) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (837,36)-(837,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (837,37)-(837,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (838,14)-(838,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (838,33)-(838,37) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (838,38)-(838,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (838,39)-(838,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (839,14)-(839,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (839,15)-(839,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (839,16)-(839,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (839,26)-(839,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (839,27)-(839,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (839,32)-(839,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (839,33)-(839,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value,");
            #line hidden
            #line (839,39)-(839,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (839,40)-(839,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (839,52)-(839,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (839,53)-(839,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (840,10)-(840,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (841,14)-(841,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (841,16)-(841,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (841,17)-(841,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(leading");
            #line hidden
            #line (841,25)-(841,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (841,26)-(841,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (841,28)-(841,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (841,29)-(841,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (842,14)-(842,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (843,18)-(843,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(leading);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (844,18)-(844,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading");
            #line hidden
            #line (844,26)-(844,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (844,27)-(844,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (844,28)-(844,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (844,29)-(844,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (845,14)-(845,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (846,14)-(846,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (846,16)-(846,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (846,17)-(846,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing");
            #line hidden
            #line (846,26)-(846,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (846,27)-(846,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (846,29)-(846,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (846,30)-(846,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (847,14)-(847,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (848,18)-(848,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (849,18)-(849,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing");
            #line hidden
            #line (849,27)-(849,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (849,28)-(849,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (849,29)-(849,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (849,30)-(849,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (850,14)-(850,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (851,10)-(851,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (852,10)-(852,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (852,16)-(852,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (852,17)-(852,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (852,25)-(852,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (852,26)-(852,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (852,38)-(852,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (852,39)-(852,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetLeadingTrivia()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (853,10)-(853,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (854,14)-(854,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (854,20)-(854,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (854,21)-(854,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (855,10)-(855,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (856,10)-(856,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (856,16)-(856,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (856,17)-(856,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (856,25)-(856,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (856,26)-(856,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (856,38)-(856,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (856,39)-(856,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetTrailingTrivia()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (857,10)-(857,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (858,14)-(858,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (858,20)-(858,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (858,21)-(858,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (859,10)-(859,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (860,10)-(860,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (860,16)-(860,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (860,17)-(860,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (860,25)-(860,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (860,26)-(860,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (860,47)-(860,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (860,48)-(860,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithLeadingTrivia(__GreenNode?");
            #line hidden
            #line (860,83)-(860,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (860,84)-(860,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (861,10)-(861,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (862,14)-(862,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (862,20)-(862,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (862,21)-(862,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (862,24)-(862,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (862,25)-(862,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValueAndTrivia<T>(this.Kind,");
            #line hidden
            #line (862,68)-(862,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (862,69)-(862,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (862,84)-(862,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (862,85)-(862,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField,");
            #line hidden
            #line (862,101)-(862,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (862,102)-(862,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (862,109)-(862,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (862,110)-(862,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing,");
            #line hidden
            #line (862,120)-(862,121) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (862,121)-(862,143) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (862,143)-(862,144) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (862,144)-(862,167) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (863,10)-(863,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (864,10)-(864,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (864,16)-(864,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (864,17)-(864,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (864,25)-(864,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (864,26)-(864,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (864,47)-(864,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (864,48)-(864,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithTrailingTrivia(__GreenNode?");
            #line hidden
            #line (864,84)-(864,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (864,85)-(864,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (865,10)-(865,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (866,14)-(866,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (866,20)-(866,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (866,21)-(866,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (866,24)-(866,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (866,25)-(866,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValueAndTrivia<T>(this.Kind,");
            #line hidden
            #line (866,68)-(866,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (866,69)-(866,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (866,84)-(866,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (866,85)-(866,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField,");
            #line hidden
            #line (866,101)-(866,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (866,102)-(866,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading,");
            #line hidden
            #line (866,111)-(866,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (866,112)-(866,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (866,119)-(866,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (866,120)-(866,142) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (866,142)-(866,143) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (866,143)-(866,166) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (867,10)-(867,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (868,10)-(868,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (868,16)-(868,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (868,17)-(868,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (868,25)-(868,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (868,26)-(868,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (868,46)-(868,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (868,47)-(868,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithDiagnostics(__DiagnosticInfo");
            #line hidden
            #line (868,80)-(868,84) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (868,85)-(868,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (868,86)-(868,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (869,10)-(869,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (870,14)-(870,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (870,20)-(870,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (870,21)-(870,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (870,24)-(870,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (870,25)-(870,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValueAndTrivia<T>(this.Kind,");
            #line hidden
            #line (870,68)-(870,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (870,69)-(870,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (870,84)-(870,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (870,85)-(870,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField,");
            #line hidden
            #line (870,101)-(870,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (870,102)-(870,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading,");
            #line hidden
            #line (870,111)-(870,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (870,112)-(870,122) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing,");
            #line hidden
            #line (870,122)-(870,123) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (870,123)-(870,135) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (870,135)-(870,136) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (870,136)-(870,159) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (871,10)-(871,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (872,10)-(872,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (872,16)-(872,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (872,17)-(872,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (872,25)-(872,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (872,26)-(872,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (872,46)-(872,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (872,47)-(872,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithAnnotations(__SyntaxAnnotation");
            #line hidden
            #line (872,82)-(872,86) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (872,87)-(872,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (872,88)-(872,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (873,10)-(873,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (874,14)-(874,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (874,20)-(874,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (874,21)-(874,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (874,24)-(874,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (874,25)-(874,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValueAndTrivia<T>(this.Kind,");
            #line hidden
            #line (874,68)-(874,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (874,69)-(874,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (874,84)-(874,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (874,85)-(874,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField,");
            #line hidden
            #line (874,101)-(874,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (874,102)-(874,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading,");
            #line hidden
            #line (874,111)-(874,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (874,112)-(874,122) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing,");
            #line hidden
            #line (874,122)-(874,123) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (874,123)-(874,145) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (874,145)-(874,146) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (874,146)-(874,159) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (875,10)-(875,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (876,7)-(876,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (876,13)-(876,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (876,14)-(876,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (876,22)-(876,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (876,23)-(876,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (876,34)-(876,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (876,35)-(876,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Clone()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (877,7)-(877,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t    ");
            #line (878,8)-(878,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (878,14)-(878,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (878,15)-(878,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (878,18)-(878,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (878,19)-(878,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithValueAndTrivia<T>(this.Kind,");
            #line hidden
            #line (878,62)-(878,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (878,63)-(878,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TextField,");
            #line hidden
            #line (878,78)-(878,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (878,79)-(878,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.ValueField,");
            #line hidden
            #line (878,95)-(878,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (878,96)-(878,105) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_leading,");
            #line hidden
            #line (878,105)-(878,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (878,106)-(878,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("_trailing,");
            #line hidden
            #line (878,116)-(878,117) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (878,117)-(878,139) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (878,139)-(878,140) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (878,140)-(878,163) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (879,7)-(879,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (880,6)-(880,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (882,6)-(882,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (882,14)-(882,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (882,15)-(882,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (882,20)-(882,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (882,21)-(882,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia");
            #line hidden
            #line (882,42)-(882,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (882,43)-(882,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (882,44)-(882,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (882,45)-(882,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (883,6)-(883,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (884,10)-(884,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (884,19)-(884,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (884,20)-(884,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (884,28)-(884,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (884,29)-(884,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (884,41)-(884,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (884,42)-(884,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("LeadingField;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (885,10)-(885,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (885,19)-(885,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (885,20)-(885,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (885,28)-(885,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (885,29)-(885,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (885,41)-(885,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (885,42)-(885,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TrailingField;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (886,10)-(886,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (886,18)-(886,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (886,19)-(886,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia(");
            #line hidden
            #line (886,42)-(886,46) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (886,47)-(886,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (886,57)-(886,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (886,58)-(886,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (886,63)-(886,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (886,64)-(886,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (886,76)-(886,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (886,77)-(886,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (886,85)-(886,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (886,86)-(886,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (886,98)-(886,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (886,99)-(886,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (887,14)-(887,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (887,15)-(887,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (887,16)-(887,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (888,10)-(888,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (889,14)-(889,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (889,16)-(889,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (889,17)-(889,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(leading");
            #line hidden
            #line (889,25)-(889,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (889,26)-(889,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (889,28)-(889,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (889,29)-(889,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (890,14)-(890,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (891,18)-(891,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(leading);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (892,18)-(892,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.LeadingField");
            #line hidden
            #line (892,35)-(892,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (892,36)-(892,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (892,37)-(892,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (892,38)-(892,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (893,14)-(893,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (894,14)-(894,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (894,16)-(894,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (894,17)-(894,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing");
            #line hidden
            #line (894,26)-(894,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (894,27)-(894,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (894,29)-(894,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (894,30)-(894,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (895,14)-(895,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (896,18)-(896,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (897,18)-(897,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TrailingField");
            #line hidden
            #line (897,36)-(897,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (897,37)-(897,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (897,38)-(897,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (897,39)-(897,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (898,14)-(898,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (899,10)-(899,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (900,10)-(900,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (900,18)-(900,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (900,19)-(900,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia(");
            #line hidden
            #line (900,42)-(900,46) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (900,47)-(900,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (900,57)-(900,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (900,58)-(900,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (900,63)-(900,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (900,64)-(900,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (900,76)-(900,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (900,77)-(900,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (900,85)-(900,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (900,86)-(900,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (900,98)-(900,99) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (900,99)-(900,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing,");
            #line hidden
            #line (900,108)-(900,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (900,109)-(900,125) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (900,126)-(900,130) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (900,131)-(900,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (900,132)-(900,144) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (900,144)-(900,145) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (900,145)-(900,163) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (900,164)-(900,168) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (900,169)-(900,170) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (900,170)-(900,182) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (901,14)-(901,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (901,15)-(901,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (901,16)-(901,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (901,26)-(901,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (901,27)-(901,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (901,39)-(901,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (901,40)-(901,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (902,10)-(902,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (903,14)-(903,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (903,16)-(903,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (903,17)-(903,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(leading");
            #line hidden
            #line (903,25)-(903,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (903,26)-(903,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (903,28)-(903,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (903,29)-(903,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (904,14)-(904,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (905,18)-(905,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(leading);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (906,18)-(906,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.LeadingField");
            #line hidden
            #line (906,35)-(906,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (906,36)-(906,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (906,37)-(906,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (906,38)-(906,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (907,14)-(907,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (908,14)-(908,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (908,16)-(908,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (908,17)-(908,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(trailing");
            #line hidden
            #line (908,26)-(908,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (908,27)-(908,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (908,29)-(908,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (908,30)-(908,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (909,14)-(909,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (910,18)-(910,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.AdjustFlagsAndWidth(trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t                ");
            #line (911,18)-(911,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TrailingField");
            #line hidden
            #line (911,36)-(911,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (911,37)-(911,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (911,38)-(911,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (911,39)-(911,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (912,14)-(912,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (913,10)-(913,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (914,10)-(914,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (914,16)-(914,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (914,17)-(914,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (914,25)-(914,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (914,26)-(914,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (914,38)-(914,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (914,39)-(914,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetLeadingTrivia()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (915,10)-(915,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (916,14)-(916,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (916,20)-(916,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (916,21)-(916,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.LeadingField;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (917,10)-(917,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (918,10)-(918,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (918,16)-(918,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (918,17)-(918,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (918,25)-(918,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (918,26)-(918,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (918,38)-(918,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (918,39)-(918,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetTrailingTrivia()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (919,10)-(919,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (920,14)-(920,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (920,20)-(920,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (920,21)-(920,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TrailingField;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (921,10)-(921,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (922,10)-(922,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (922,16)-(922,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (922,17)-(922,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (922,25)-(922,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (922,26)-(922,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (922,47)-(922,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (922,48)-(922,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithLeadingTrivia(__GreenNode?");
            #line hidden
            #line (922,83)-(922,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (922,84)-(922,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (923,10)-(923,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (924,14)-(924,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (924,20)-(924,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (924,21)-(924,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (924,24)-(924,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (924,25)-(924,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia(this.Kind,");
            #line hidden
            #line (924,57)-(924,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (924,58)-(924,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (924,65)-(924,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (924,66)-(924,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TrailingField,");
            #line hidden
            #line (924,85)-(924,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (924,86)-(924,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (924,108)-(924,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (924,109)-(924,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (925,10)-(925,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (926,10)-(926,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (926,16)-(926,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (926,17)-(926,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (926,25)-(926,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (926,26)-(926,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (926,47)-(926,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (926,48)-(926,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TokenWithTrailingTrivia(__GreenNode?");
            #line hidden
            #line (926,84)-(926,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (926,85)-(926,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (927,10)-(927,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (928,14)-(928,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (928,20)-(928,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (928,21)-(928,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (928,24)-(928,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (928,25)-(928,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia(this.Kind,");
            #line hidden
            #line (928,57)-(928,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (928,58)-(928,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.LeadingField,");
            #line hidden
            #line (928,76)-(928,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (928,77)-(928,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia,");
            #line hidden
            #line (928,84)-(928,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (928,85)-(928,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (928,107)-(928,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (928,108)-(928,131) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (929,10)-(929,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (930,10)-(930,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (930,16)-(930,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (930,17)-(930,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (930,25)-(930,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (930,26)-(930,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (930,46)-(930,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (930,47)-(930,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithDiagnostics(__DiagnosticInfo");
            #line hidden
            #line (930,80)-(930,84) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (930,85)-(930,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (930,86)-(930,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (931,10)-(931,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (932,14)-(932,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (932,20)-(932,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (932,21)-(932,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (932,24)-(932,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (932,25)-(932,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia(this.Kind,");
            #line hidden
            #line (932,57)-(932,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (932,58)-(932,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.LeadingField,");
            #line hidden
            #line (932,76)-(932,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (932,77)-(932,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TrailingField,");
            #line hidden
            #line (932,96)-(932,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (932,97)-(932,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (932,109)-(932,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (932,110)-(932,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (933,10)-(933,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (934,10)-(934,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (934,16)-(934,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (934,17)-(934,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (934,25)-(934,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (934,26)-(934,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (934,46)-(934,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (934,47)-(934,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithAnnotations(__SyntaxAnnotation");
            #line hidden
            #line (934,82)-(934,86) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (934,87)-(934,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (934,88)-(934,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (935,10)-(935,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (936,14)-(936,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (936,20)-(936,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (936,21)-(936,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (936,24)-(936,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (936,25)-(936,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia(this.Kind,");
            #line hidden
            #line (936,57)-(936,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (936,58)-(936,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.LeadingField,");
            #line hidden
            #line (936,76)-(936,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (936,77)-(936,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TrailingField,");
            #line hidden
            #line (936,96)-(936,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (936,97)-(936,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (936,119)-(936,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (936,120)-(936,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (937,10)-(937,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (938,7)-(938,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (938,13)-(938,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (938,14)-(938,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (938,22)-(938,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (938,23)-(938,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (938,34)-(938,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (938,35)-(938,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Clone()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (939,7)-(939,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t    ");
            #line (940,8)-(940,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (940,14)-(940,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (940,15)-(940,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (940,18)-(940,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (940,19)-(940,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxTokenWithTrivia(this.Kind,");
            #line hidden
            #line (940,51)-(940,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (940,52)-(940,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.LeadingField,");
            #line hidden
            #line (940,70)-(940,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (940,71)-(940,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.TrailingField,");
            #line hidden
            #line (940,90)-(940,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (940,91)-(940,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (940,113)-(940,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (940,114)-(940,137) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (941,7)-(941,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (942,6)-(942,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (943,2)-(943,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first48 = true;
            #line (945,3)-(945,30) 13 "InternalSyntaxGenerator.mxg"
            foreach (var rule in Rules)
            #line hidden
            
            {
                if (__first48)
                {
                    __first48 = false;
                }
                __cb.Push("\t");
                #line (946,3)-(946,35) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(GenerateInternalSyntaxRule(rule));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first48) __cb.AppendLine();
            __cb.Push("");
            #line (948,1)-(948,2) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (951,9)-(951,47) 22 "InternalSyntaxGenerator.mxg"
        public string GenerateInternalSyntaxRule(Rule rule)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (952,2)-(952,38) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(GenerateInternalSyntaxRuleBase(rule));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first49 = true;
            #line (953,2)-(953,40) 13 "InternalSyntaxGenerator.mxg"
            foreach (var alt in rule.Alternatives)
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                __cb.Push("");
                #line (954,2)-(954,42) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(GenerateInternalSyntaxRuleAlt(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first49) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (958,9)-(958,51) 22 "InternalSyntaxGenerator.mxg"
        public string GenerateInternalSyntaxRuleBase(Rule rule)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first50 = true;
            #line (959,2)-(959,34) 13 "InternalSyntaxGenerator.mxg"
            if (rule.Alternatives.Count > 1)
            #line hidden
            
            {
                if (__first50)
                {
                    __first50 = false;
                }
                __cb.Push("");
                #line (960,1)-(960,9) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("internal");
                #line hidden
                #line (960,9)-(960,10) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (960,10)-(960,18) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("abstract");
                #line hidden
                #line (960,18)-(960,19) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (960,19)-(960,24) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("class");
                #line hidden
                #line (960,24)-(960,25) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (960,26)-(960,40) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(rule.GreenName);
                #line hidden
                #line (960,41)-(960,42) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (960,42)-(960,43) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (960,43)-(960,44) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (960,44)-(960,59) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("GreenSyntaxNode");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (961,1)-(961,2) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (962,3)-(962,38) 17 "InternalSyntaxGenerator.mxg"
                var firstAlt = rule.Alternatives[0];
                #line hidden
                
                __cb.Push("\t");
                #line (963,2)-(963,10) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("internal");
                #line hidden
                #line (963,10)-(963,11) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (963,11)-(963,17) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (963,17)-(963,18) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (963,18)-(963,26) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (963,26)-(963,27) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (963,28)-(963,42) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(rule.GreenName);
                #line hidden
                #line (963,43)-(963,44) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (963,44)-(963,53) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("__Missing");
                #line hidden
                #line (963,53)-(963,54) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (963,54)-(963,55) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (963,55)-(963,56) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (963,57)-(963,75) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(firstAlt.GreenName);
                #line hidden
                #line (963,76)-(963,87) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(".__Missing;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (965,5)-(965,14) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("protected");
                #line hidden
                #line (965,14)-(965,15) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (965,16)-(965,30) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(rule.GreenName);
                #line hidden
                #line (965,31)-(965,32) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (965,33)-(965,37) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (965,38)-(965,48) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind");
                #line hidden
                #line (965,48)-(965,49) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (965,49)-(965,54) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("kind,");
                #line hidden
                #line (965,54)-(965,55) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (965,55)-(965,71) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("__DiagnosticInfo");
                #line hidden
                #line (965,72)-(965,76) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write("[]");
                #line hidden
                #line (965,77)-(965,78) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (965,78)-(965,90) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("diagnostics,");
                #line hidden
                #line (965,90)-(965,91) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (965,91)-(965,109) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("__SyntaxAnnotation");
                #line hidden
                #line (965,110)-(965,114) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write("[]");
                #line hidden
                #line (965,115)-(965,116) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (965,116)-(965,128) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("annotations)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (966,9)-(966,10) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (966,10)-(966,11) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (966,11)-(966,21) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("base(kind,");
                #line hidden
                #line (966,21)-(966,22) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (966,22)-(966,34) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("diagnostics,");
                #line hidden
                #line (966,34)-(966,35) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (966,35)-(966,47) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("annotations)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (967,5)-(967,6) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (968,5)-(968,6) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (969,1)-(969,2) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first50) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (974,9)-(974,67) 22 "InternalSyntaxGenerator.mxg"
        public string GenerateInternalSyntaxRuleAlt(Rule rule, Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (975,1)-(975,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (975,9)-(975,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (975,10)-(975,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (975,15)-(975,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (975,17)-(975,30) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (975,31)-(975,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (975,32)-(975,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (975,33)-(975,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (975,35)-(975,100) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(rule.Alternatives.Count == 1 ? "GreenSyntaxNode" : rule.GreenName);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (976,1)-(976,2) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (977,2)-(977,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (977,10)-(977,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (977,11)-(977,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (977,17)-(977,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (977,18)-(977,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (977,21)-(977,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (977,22)-(977,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (977,30)-(977,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (977,32)-(977,45) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (977,46)-(977,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (977,47)-(977,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Missing");
            #line hidden
            #line (977,56)-(977,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (977,57)-(977,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (977,58)-(977,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (977,59)-(977,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (977,62)-(977,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (977,64)-(977,77) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (977,78)-(977,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first51 = true;
            #line (978,3)-(978,37) 13 "InternalSyntaxGenerator.mxg"
            foreach (var elem in alt.Elements)
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                __cb.Push("\t");
                #line (979,2)-(979,9) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (979,9)-(979,10) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (979,11)-(979,30) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.GreenFieldType);
                #line hidden
                #line (979,31)-(979,32) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (979,33)-(979,47) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.FieldName);
                #line hidden
                #line (979,48)-(979,49) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first51) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (982,2)-(982,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (982,8)-(982,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (982,10)-(982,23) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (982,24)-(982,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (982,26)-(982,30) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (982,31)-(982,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (982,41)-(982,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (982,42)-(982,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind");
            #line hidden
            #line (982,47)-(982,77) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenConstructorParameters);
            #line hidden
            #line (982,78)-(982,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (983,3)-(983,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (983,4)-(983,5) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (983,5)-(983,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (983,15)-(983,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (983,16)-(983,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (983,21)-(983,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (983,22)-(983,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (984,2)-(984,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (985,3)-(985,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SlotCount");
            #line hidden
            #line (985,12)-(985,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (985,13)-(985,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (985,14)-(985,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (985,16)-(985,34) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.Elements.Count);
            #line hidden
            #line (985,35)-(985,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first52 = true;
            #line (986,4)-(986,38) 13 "InternalSyntaxGenerator.mxg"
            foreach (var elem in alt.Elements)
            #line hidden
            
            {
                if (__first52)
                {
                    __first52 = false;
                }
                __cb.Push("\t\t");
                #line (987,3)-(987,5) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (987,5)-(987,6) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (987,6)-(987,7) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (987,8)-(987,26) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (987,27)-(987,28) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (987,28)-(987,30) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("!=");
                #line hidden
                #line (987,30)-(987,31) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (987,31)-(987,36) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t");
                #line (988,3)-(988,4) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (989,4)-(989,24) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("AdjustFlagsAndWidth(");
                #line hidden
                #line (989,25)-(989,43) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (989,44)-(989,46) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (990,5)-(990,19) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.FieldName);
                #line hidden
                #line (990,20)-(990,21) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (990,21)-(990,22) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (990,22)-(990,23) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (990,24)-(990,42) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (990,43)-(990,44) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t");
                #line (991,3)-(991,4) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first52) __cb.AppendLine();
            __cb.Push("\t");
            #line (993,2)-(993,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (995,2)-(995,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (995,8)-(995,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (995,10)-(995,23) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (995,24)-(995,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (995,26)-(995,30) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (995,31)-(995,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (995,41)-(995,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (995,42)-(995,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind");
            #line hidden
            #line (995,47)-(995,77) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenConstructorParameters);
            #line hidden
            #line (995,78)-(995,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (995,79)-(995,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (995,80)-(995,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (995,97)-(995,101) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (995,102)-(995,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (995,103)-(995,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (995,115)-(995,116) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (995,116)-(995,134) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (995,135)-(995,139) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (995,140)-(995,141) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (995,141)-(995,153) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (996,3)-(996,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (996,4)-(996,5) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (996,5)-(996,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(kind,");
            #line hidden
            #line (996,15)-(996,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (996,16)-(996,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (996,28)-(996,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (996,29)-(996,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (997,2)-(997,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (998,3)-(998,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SlotCount");
            #line hidden
            #line (998,12)-(998,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (998,13)-(998,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (998,14)-(998,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (998,16)-(998,34) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.Elements.Count);
            #line hidden
            #line (998,35)-(998,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first53 = true;
            #line (999,4)-(999,38) 13 "InternalSyntaxGenerator.mxg"
            foreach (var elem in alt.Elements)
            #line hidden
            
            {
                if (__first53)
                {
                    __first53 = false;
                }
                __cb.Push("\t\t");
                #line (1000,3)-(1000,5) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (1000,5)-(1000,6) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1000,6)-(1000,7) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (1000,8)-(1000,26) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (1000,27)-(1000,28) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1000,28)-(1000,30) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("!=");
                #line hidden
                #line (1000,30)-(1000,31) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1000,31)-(1000,36) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t");
                #line (1001,3)-(1001,4) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (1002,4)-(1002,24) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("AdjustFlagsAndWidth(");
                #line hidden
                #line (1002,25)-(1002,43) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (1002,44)-(1002,46) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (1003,5)-(1003,19) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.FieldName);
                #line hidden
                #line (1003,20)-(1003,21) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1003,21)-(1003,22) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (1003,22)-(1003,23) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1003,24)-(1003,42) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (1003,43)-(1003,44) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t");
                #line (1004,3)-(1004,4) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first53) __cb.AppendLine();
            __cb.Push("\t");
            #line (1006,2)-(1006,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1008,2)-(1008,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (1008,9)-(1008,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1008,11)-(1008,24) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (1008,25)-(1008,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1009,3)-(1009,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (1009,4)-(1009,5) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1009,5)-(1009,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base((");
            #line hidden
            #line (1009,12)-(1009,16) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1009,17)-(1009,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)");
            #line hidden
            #line (1009,29)-(1009,33) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1009,34)-(1009,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.");
            #line hidden
            #line (1009,46)-(1009,60) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.CSharpName);
            #line hidden
            #line (1009,61)-(1009,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (1009,62)-(1009,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1009,63)-(1009,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (1009,68)-(1009,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1009,69)-(1009,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1010,2)-(1010,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1011,3)-(1011,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.flags");
            #line hidden
            #line (1011,13)-(1011,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1011,14)-(1011,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&=");
            #line hidden
            #line (1011,16)-(1011,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1011,17)-(1011,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("~NodeFlags.IsNotMissing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1012,2)-(1012,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first54 = true;
            #line (1014,3)-(1014,37) 13 "InternalSyntaxGenerator.mxg"
            foreach (var elem in alt.Elements)
            #line hidden
            
            {
                if (__first54)
                {
                    __first54 = false;
                }
                __cb.Push("\t");
                #line (1015,2)-(1015,8) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (1015,8)-(1015,9) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1015,10)-(1015,32) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.GreenPropertyType);
                #line hidden
                #line (1015,33)-(1015,34) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1015,35)-(1015,52) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.PropertyName);
                #line hidden
                #line (1015,53)-(1015,54) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1015,54)-(1015,55) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (1015,55)-(1015,56) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1015,56)-(1015,59) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("get");
                #line hidden
                #line (1015,59)-(1015,60) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1015,60)-(1015,61) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (1015,61)-(1015,62) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1015,62)-(1015,68) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (1015,68)-(1015,69) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1015,70)-(1015,93) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.GreenPropertyValue);
                #line hidden
                #line (1015,94)-(1015,95) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(";");
                #line hidden
                #line (1015,95)-(1015,96) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1015,96)-(1015,97) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                #line (1015,97)-(1015,98) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1015,98)-(1015,99) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first54) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1018,2)-(1018,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (1018,11)-(1018,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1018,12)-(1018,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1018,20)-(1018,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1018,21)-(1018,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxNode");
            #line hidden
            #line (1018,33)-(1018,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1018,34)-(1018,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("CreateRed(__SyntaxNode");
            #line hidden
            #line (1018,56)-(1018,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1018,57)-(1018,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("parent,");
            #line hidden
            #line (1018,64)-(1018,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1018,65)-(1018,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (1018,68)-(1018,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1018,69)-(1018,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("position)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1019,2)-(1019,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1020,3)-(1020,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1020,9)-(1020,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1020,10)-(1020,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (1020,13)-(1020,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1020,14)-(1020,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::");
            #line hidden
            #line (1020,23)-(1020,32) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (1020,33)-(1020,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Syntax.");
            #line hidden
            #line (1020,42)-(1020,53) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.RedName);
            #line hidden
            #line (1020,54)-(1020,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(this,");
            #line hidden
            #line (1020,60)-(1020,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1020,61)-(1020,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (1020,63)-(1020,67) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1020,68)-(1020,86) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxNode)parent,");
            #line hidden
            #line (1020,86)-(1020,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1020,87)-(1020,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("position);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1021,2)-(1021,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1023,2)-(1023,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (1023,11)-(1023,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1023,12)-(1023,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1023,20)-(1023,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1023,21)-(1023,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (1023,32)-(1023,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1023,33)-(1023,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetSlot(int");
            #line hidden
            #line (1023,44)-(1023,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1023,45)-(1023,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("index)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1024,2)-(1024,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1025,3)-(1025,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (1025,9)-(1025,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1025,10)-(1025,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(index)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1026,3)-(1026,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (1027,5)-(1027,22) 13 "InternalSyntaxGenerator.mxg"
            var slotIndex = 0;
            #line hidden
            
            var __first55 = true;
            #line (1028,5)-(1028,39) 13 "InternalSyntaxGenerator.mxg"
            foreach (var elem in alt.Elements)
            #line hidden
            
            {
                if (__first55)
                {
                    __first55 = false;
                }
                __cb.Push("\t\t\t");
                #line (1029,4)-(1029,8) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("case");
                #line hidden
                #line (1029,8)-(1029,9) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1029,10)-(1029,21) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(slotIndex++);
                #line hidden
                #line (1029,22)-(1029,23) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (1029,23)-(1029,24) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1029,24)-(1029,30) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (1029,30)-(1029,31) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1029,32)-(1029,46) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.FieldName);
                #line hidden
                #line (1029,47)-(1029,48) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first55) __cb.AppendLine();
            __cb.Push("\t\t\t");
            #line (1031,4)-(1031,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            #line (1031,12)-(1031,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1031,13)-(1031,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1031,19)-(1031,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1031,20)-(1031,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1032,3)-(1032,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1033,2)-(1033,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1035,2)-(1035,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1035,8)-(1035,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1035,9)-(1035,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1035,17)-(1035,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1035,18)-(1035,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TResult");
            #line hidden
            #line (1035,25)-(1035,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1035,26)-(1035,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Accept<TResult>(");
            #line hidden
            #line (1035,43)-(1035,47) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1035,48)-(1035,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxVisitor<TResult>");
            #line hidden
            #line (1035,78)-(1035,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1035,79)-(1035,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor)");
            #line hidden
            #line (1035,87)-(1035,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1035,88)-(1035,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (1035,90)-(1035,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1035,91)-(1035,104) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor.Visit");
            #line hidden
            #line (1035,105)-(1035,118) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (1035,119)-(1035,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1037,2)-(1037,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1037,8)-(1037,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1037,9)-(1037,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1037,17)-(1037,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1037,18)-(1037,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (1037,22)-(1037,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1037,23)-(1037,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Accept(");
            #line hidden
            #line (1037,31)-(1037,35) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1037,36)-(1037,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxVisitor");
            #line hidden
            #line (1037,57)-(1037,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1037,58)-(1037,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor)");
            #line hidden
            #line (1037,66)-(1037,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1037,67)-(1037,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (1037,69)-(1037,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1037,70)-(1037,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("visitor.Visit");
            #line hidden
            #line (1037,84)-(1037,97) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (1037,98)-(1037,105) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1039,2)-(1039,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1039,8)-(1039,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1039,9)-(1039,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1039,17)-(1039,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1039,18)-(1039,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (1039,38)-(1039,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1039,39)-(1039,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithDiagnostics(__DiagnosticInfo");
            #line hidden
            #line (1039,72)-(1039,76) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (1039,77)-(1039,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1039,78)-(1039,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1040,2)-(1040,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1041,3)-(1041,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1041,9)-(1041,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1041,10)-(1041,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (1041,13)-(1041,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1041,15)-(1041,28) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (1041,29)-(1041,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(this.Kind");
            #line hidden
            #line (1041,40)-(1041,69) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenConstructorArguments);
            #line hidden
            #line (1041,70)-(1041,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (1041,71)-(1041,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1041,72)-(1041,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (1041,84)-(1041,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1041,85)-(1041,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1042,2)-(1042,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1044,2)-(1044,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1044,8)-(1044,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1044,9)-(1044,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1044,17)-(1044,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1044,18)-(1044,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (1044,38)-(1044,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1044,39)-(1044,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("WithAnnotations(__SyntaxAnnotation");
            #line hidden
            #line (1044,74)-(1044,78) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (1044,79)-(1044,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1044,80)-(1044,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1045,2)-(1045,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1046,3)-(1046,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1046,9)-(1046,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1046,10)-(1046,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (1046,13)-(1046,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1046,15)-(1046,28) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (1046,29)-(1046,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(this.Kind");
            #line hidden
            #line (1046,40)-(1046,69) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenConstructorArguments);
            #line hidden
            #line (1046,70)-(1046,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (1046,71)-(1046,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1046,72)-(1046,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (1046,94)-(1046,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1046,95)-(1046,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1047,2)-(1047,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1049,2)-(1049,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1049,8)-(1049,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1049,9)-(1049,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1049,17)-(1049,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1049,18)-(1049,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (1049,29)-(1049,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1049,30)-(1049,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Clone()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1050,2)-(1050,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1051,3)-(1051,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1051,9)-(1051,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1051,10)-(1051,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (1051,13)-(1051,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1051,15)-(1051,28) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (1051,29)-(1051,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(this.Kind");
            #line hidden
            #line (1051,40)-(1051,69) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenConstructorArguments);
            #line hidden
            #line (1051,70)-(1051,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (1051,71)-(1051,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1051,72)-(1051,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics(),");
            #line hidden
            #line (1051,94)-(1051,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1051,95)-(1051,118) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1052,2)-(1052,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1055,2)-(1055,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1055,8)-(1055,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1055,10)-(1055,23) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (1055,24)-(1055,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1055,25)-(1055,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Update(");
            #line hidden
            #line (1055,33)-(1055,58) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenUpdateParameters);
            #line hidden
            #line (1055,59)-(1055,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1056,2)-(1056,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1057,3)-(1057,5) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (1057,5)-(1057,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1057,6)-(1057,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            var __first56 = true;
            #line (1057,8)-(1057,43) 13 "InternalSyntaxGenerator.mxg"
            foreach (var elem in alt.Elements) 
            #line hidden
            
            {
                if (__first56)
                {
                    __first56 = false;
                }
                else
                {
                    __cb.Push("\t\t");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (1057,53)-(1057,59) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" || ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (1057,61)-(1057,75) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.FieldName);
                #line hidden
                #line (1057,76)-(1057,77) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1057,77)-(1057,79) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("!=");
                #line hidden
                #line (1057,79)-(1057,80) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1057,81)-(1057,105) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(elem.GreenParameterValue);
                #line hidden
            }
            #line (1057,119)-(1057,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1058,3)-(1058,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1059,4)-(1059,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (1059,24)-(1059,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1059,25)-(1059,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("newNode");
            #line hidden
            #line (1059,32)-(1059,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1059,33)-(1059,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1059,34)-(1059,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1059,36)-(1059,40) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1059,41)-(1059,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.InternalSyntaxFactory.");
            #line hidden
            #line (1059,82)-(1059,96) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.CSharpName);
            #line hidden
            #line (1059,97)-(1059,98) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (1059,99)-(1059,123) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenUpdateArguments);
            #line hidden
            #line (1059,124)-(1059,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1060,4)-(1060,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (1060,7)-(1060,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1060,8)-(1060,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diags");
            #line hidden
            #line (1060,13)-(1060,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1060,14)-(1060,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1060,15)-(1060,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1060,16)-(1060,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetDiagnostics();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1061,4)-(1061,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (1061,6)-(1061,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1061,7)-(1061,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(diags");
            #line hidden
            #line (1061,13)-(1061,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1061,14)-(1061,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (1061,16)-(1061,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1061,17)-(1061,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null");
            #line hidden
            #line (1061,21)-(1061,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1061,22)-(1061,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (1061,24)-(1061,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1061,25)-(1061,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("diags.Length");
            #line hidden
            #line (1061,37)-(1061,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1061,38)-(1061,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(">");
            #line hidden
            #line (1061,39)-(1061,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1061,40)-(1061,42) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("0)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (1062,5)-(1062,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("newNode");
            #line hidden
            #line (1062,12)-(1062,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1062,13)-(1062,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1062,14)-(1062,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1062,15)-(1062,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("newNode.WithDiagnostics(diags);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1063,4)-(1063,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (1063,7)-(1063,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1063,8)-(1063,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations");
            #line hidden
            #line (1063,19)-(1063,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1063,20)-(1063,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1063,21)-(1063,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1063,22)-(1063,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.GetAnnotations();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1064,4)-(1064,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (1064,6)-(1064,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1064,7)-(1064,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(annotations");
            #line hidden
            #line (1064,19)-(1064,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1064,20)-(1064,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (1064,22)-(1064,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1064,23)-(1064,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null");
            #line hidden
            #line (1064,27)-(1064,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1064,28)-(1064,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (1064,30)-(1064,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1064,31)-(1064,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("annotations.Length");
            #line hidden
            #line (1064,49)-(1064,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1064,50)-(1064,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(">");
            #line hidden
            #line (1064,51)-(1064,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1064,52)-(1064,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("0)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (1065,5)-(1065,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("newNode");
            #line hidden
            #line (1065,12)-(1065,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1065,13)-(1065,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1065,14)-(1065,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1065,15)-(1065,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("newNode.WithAnnotations(annotations);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1066,4)-(1066,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1066,10)-(1066,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1066,11)-(1066,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (1066,13)-(1066,26) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (1066,27)-(1066,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(")newNode;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1067,3)-(1067,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1068,3)-(1068,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1068,9)-(1068,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1068,10)-(1068,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1069,2)-(1069,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (1070,1)-(1070,2) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (1074,9)-(1074,41) 22 "InternalSyntaxGenerator.mxg"
        public string GenerateInternalSyntaxVisitor()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (1075,1)-(1075,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (1075,10)-(1075,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1075,11)-(1075,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (1077,1)-(1077,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (1077,10)-(1077,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1077,12)-(1077,21) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (1077,22)-(1077,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Syntax.InternalSyntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (1078,1)-(1078,2) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1079,2)-(1079,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (1079,10)-(1079,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1079,11)-(1079,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (1079,16)-(1079,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1079,18)-(1079,22) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1079,23)-(1079,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxVisitor");
            #line hidden
            #line (1079,44)-(1079,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1079,45)-(1079,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (1079,46)-(1079,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1079,47)-(1079,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1080,2)-(1080,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1081,3)-(1081,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1081,9)-(1081,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1081,10)-(1081,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (1081,17)-(1081,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1081,18)-(1081,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (1081,22)-(1081,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1081,23)-(1081,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax");
            #line hidden
            #line (1081,78)-(1081,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1081,79)-(1081,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            #line (1081,84)-(1081,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1081,85)-(1081,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (1081,87)-(1081,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1081,88)-(1081,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.DefaultVisit(node);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first57 = true;
            #line (1082,4)-(1082,31) 13 "InternalSyntaxGenerator.mxg"
            foreach (var rule in Rules)
            #line hidden
            
            {
                if (__first57)
                {
                    __first57 = false;
                }
                var __first58 = true;
                #line (1083,5)-(1083,43) 17 "InternalSyntaxGenerator.mxg"
                foreach (var alt in rule.Alternatives)
                #line hidden
                
                {
                    if (__first58)
                    {
                        __first58 = false;
                    }
                    __cb.Push("\t\t");
                    #line (1084,3)-(1084,9) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (1084,9)-(1084,10) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1084,10)-(1084,17) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("virtual");
                    #line hidden
                    #line (1084,17)-(1084,18) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1084,18)-(1084,22) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (1084,22)-(1084,23) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1084,23)-(1084,28) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("Visit");
                    #line hidden
                    #line (1084,29)-(1084,42) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(alt.GreenName);
                    #line hidden
                    #line (1084,43)-(1084,44) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (1084,45)-(1084,58) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(alt.GreenName);
                    #line hidden
                    #line (1084,59)-(1084,60) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1084,60)-(1084,65) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("node)");
                    #line hidden
                    #line (1084,65)-(1084,66) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1084,66)-(1084,68) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (1084,68)-(1084,69) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1084,69)-(1084,93) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("this.DefaultVisit(node);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first58) __cb.AppendLine();
            }
            if (!__first57) __cb.AppendLine();
            __cb.Push("\t");
            #line (1087,2)-(1087,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1089,2)-(1089,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (1089,10)-(1089,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1089,11)-(1089,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (1089,16)-(1089,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1089,18)-(1089,22) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1089,23)-(1089,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxVisitor<TResult>");
            #line hidden
            #line (1089,53)-(1089,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1089,54)-(1089,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (1089,55)-(1089,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1089,56)-(1089,138) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor<TResult>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1090,2)-(1090,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1091,3)-(1091,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1091,9)-(1091,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1091,10)-(1091,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (1091,17)-(1091,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1091,18)-(1091,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("TResult");
            #line hidden
            #line (1091,25)-(1091,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1091,26)-(1091,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax");
            #line hidden
            #line (1091,81)-(1091,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1091,82)-(1091,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            #line (1091,87)-(1091,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1091,88)-(1091,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (1091,90)-(1091,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1091,91)-(1091,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("this.DefaultVisit(node);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first59 = true;
            #line (1092,4)-(1092,31) 13 "InternalSyntaxGenerator.mxg"
            foreach (var rule in Rules)
            #line hidden
            
            {
                if (__first59)
                {
                    __first59 = false;
                }
                var __first60 = true;
                #line (1093,5)-(1093,43) 17 "InternalSyntaxGenerator.mxg"
                foreach (var alt in rule.Alternatives)
                #line hidden
                
                {
                    if (__first60)
                    {
                        __first60 = false;
                    }
                    __cb.Push("\t\t");
                    #line (1094,3)-(1094,9) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (1094,9)-(1094,10) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1094,10)-(1094,17) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("virtual");
                    #line hidden
                    #line (1094,17)-(1094,18) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1094,18)-(1094,25) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("TResult");
                    #line hidden
                    #line (1094,25)-(1094,26) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1094,26)-(1094,31) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("Visit");
                    #line hidden
                    #line (1094,32)-(1094,45) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(alt.GreenName);
                    #line hidden
                    #line (1094,46)-(1094,47) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (1094,48)-(1094,61) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(alt.GreenName);
                    #line hidden
                    #line (1094,62)-(1094,63) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1094,63)-(1094,68) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("node)");
                    #line hidden
                    #line (1094,68)-(1094,69) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1094,69)-(1094,71) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (1094,71)-(1094,72) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1094,72)-(1094,96) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("this.DefaultVisit(node);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first60) __cb.AppendLine();
            }
            if (!__first59) __cb.AppendLine();
            __cb.Push("\t");
            #line (1097,2)-(1097,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (1098,1)-(1098,2) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (1101,9)-(1101,41) 22 "InternalSyntaxGenerator.mxg"
        public string GenerateInternalSyntaxFactory()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (1102,1)-(1102,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (1102,10)-(1102,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1102,11)-(1102,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (1104,1)-(1104,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (1104,10)-(1104,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1104,12)-(1104,21) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (1104,22)-(1104,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(".Syntax.InternalSyntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (1105,1)-(1105,2) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1106,2)-(1106,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1106,7)-(1106,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1106,8)-(1106,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Debug");
            #line hidden
            #line (1106,15)-(1106,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1106,16)-(1106,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1106,17)-(1106,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1106,18)-(1106,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("System.Diagnostics.Debug;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1107,2)-(1107,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1107,7)-(1107,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1107,8)-(1107,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Language");
            #line hidden
            #line (1107,18)-(1107,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1107,19)-(1107,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1107,20)-(1107,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1107,21)-(1107,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Language;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1108,2)-(1108,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1108,7)-(1108,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1108,8)-(1108,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__ParseOptions");
            #line hidden
            #line (1108,22)-(1108,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1108,23)-(1108,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1108,24)-(1108,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1108,25)-(1108,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.ParseOptions;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1109,2)-(1109,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1109,7)-(1109,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1109,8)-(1109,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__DiagnosticInfo");
            #line hidden
            #line (1109,24)-(1109,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1109,25)-(1109,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1109,26)-(1109,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1109,27)-(1109,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticInfo;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1110,2)-(1110,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1110,7)-(1110,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1110,8)-(1110,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation");
            #line hidden
            #line (1110,26)-(1110,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1110,27)-(1110,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1110,28)-(1110,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1110,29)-(1110,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SyntaxAnnotation;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1111,2)-(1111,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1111,7)-(1111,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1111,8)-(1111,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode");
            #line hidden
            #line (1111,19)-(1111,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1111,20)-(1111,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1111,21)-(1111,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1111,22)-(1111,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.GreenNode;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1112,2)-(1112,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1112,7)-(1112,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1112,8)-(1112,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxNodeCache");
            #line hidden
            #line (1112,25)-(1112,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1112,26)-(1112,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1112,27)-(1112,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1112,28)-(1112,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxNodeCache;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1113,2)-(1113,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1113,7)-(1113,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1113,8)-(1113,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxKind");
            #line hidden
            #line (1113,28)-(1113,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1113,29)-(1113,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1113,30)-(1113,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1113,31)-(1113,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxKind;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1114,2)-(1114,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1114,7)-(1114,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1114,8)-(1114,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1114,29)-(1114,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1114,30)-(1114,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1114,31)-(1114,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1114,32)-(1114,104) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxToken;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1115,2)-(1115,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1115,7)-(1115,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1115,8)-(1115,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxTrivia");
            #line hidden
            #line (1115,30)-(1115,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1115,31)-(1115,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1115,32)-(1115,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1115,33)-(1115,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxTrivia;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1116,2)-(1116,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1116,7)-(1116,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1116,8)-(1116,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (1116,28)-(1116,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1116,29)-(1116,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1116,30)-(1116,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1116,31)-(1116,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxNode;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1117,2)-(1117,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1117,7)-(1117,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1117,8)-(1117,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__IncrementalParseData");
            #line hidden
            #line (1117,30)-(1117,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1117,31)-(1117,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1117,32)-(1117,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1117,33)-(1117,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.IncrementalParseData;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1118,2)-(1118,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1118,7)-(1118,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1118,8)-(1118,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxLexer");
            #line hidden
            #line (1118,21)-(1118,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1118,22)-(1118,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1118,23)-(1118,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1118,24)-(1118,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxLexer;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1119,2)-(1119,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1119,7)-(1119,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1119,8)-(1119,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxParser");
            #line hidden
            #line (1119,22)-(1119,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1119,23)-(1119,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1119,24)-(1119,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1119,25)-(1119,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxParser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1120,2)-(1120,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1120,7)-(1120,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1120,8)-(1120,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxFacts");
            #line hidden
            #line (1120,21)-(1120,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1120,22)-(1120,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1120,23)-(1120,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1120,24)-(1120,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.SyntaxFacts;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1121,2)-(1121,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1121,7)-(1121,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1121,8)-(1121,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxToken");
            #line hidden
            #line (1121,21)-(1121,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1121,22)-(1121,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1121,23)-(1121,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1121,24)-(1121,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SyntaxToken;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1122,2)-(1122,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1122,7)-(1122,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1122,8)-(1122,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxTrivia");
            #line hidden
            #line (1122,22)-(1122,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1122,23)-(1122,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1122,24)-(1122,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1122,25)-(1122,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SyntaxTrivia;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1123,2)-(1123,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1123,7)-(1123,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1123,8)-(1123,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxNode");
            #line hidden
            #line (1123,20)-(1123,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1123,21)-(1123,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1123,22)-(1123,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1123,23)-(1123,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SyntaxNode;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1124,2)-(1124,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1124,7)-(1124,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1124,8)-(1124,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SourceText");
            #line hidden
            #line (1124,20)-(1124,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1124,21)-(1124,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1124,22)-(1124,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1124,23)-(1124,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Text.SourceText;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1125,2)-(1125,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1125,7)-(1125,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1125,8)-(1125,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__TextChangeRange");
            #line hidden
            #line (1125,25)-(1125,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1125,26)-(1125,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1125,27)-(1125,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1125,28)-(1125,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Text.TextChangeRange;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1126,2)-(1126,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1126,7)-(1126,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1126,8)-(1126,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (1126,27)-(1126,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1126,28)-(1126,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1126,29)-(1126,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1126,30)-(1126,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1127,2)-(1127,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1127,7)-(1127,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1127,8)-(1127,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__ArgumentNullException");
            #line hidden
            #line (1127,31)-(1127,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1127,32)-(1127,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1127,33)-(1127,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1127,34)-(1127,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.ArgumentNullException;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (1128,5)-(1128,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (1128,10)-(1128,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1128,11)-(1128,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__ArgumentException");
            #line hidden
            #line (1128,30)-(1128,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1128,31)-(1128,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1128,32)-(1128,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1128,33)-(1128,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.ArgumentException;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1130,2)-(1130,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1130,8)-(1130,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1130,9)-(1130,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (1130,16)-(1130,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1130,17)-(1130,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (1130,22)-(1130,23) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1130,24)-(1130,28) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1130,29)-(1130,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (1130,50)-(1130,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1130,51)-(1130,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (1130,52)-(1130,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1130,53)-(1130,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (1131,2)-(1131,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1132,3)-(1132,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1132,9)-(1132,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1132,11)-(1132,15) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1132,16)-(1132,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxFactory(__SyntaxFacts");
            #line hidden
            #line (1132,51)-(1132,52) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1132,52)-(1132,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("syntaxFacts)");
            #line hidden
            #line (1132,64)-(1132,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t    ");
            #line (1133,7)-(1133,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (1133,8)-(1133,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1133,9)-(1133,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("base(syntaxFacts)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1134,3)-(1134,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1135,3)-(1135,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1137,3)-(1137,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1137,9)-(1137,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1137,10)-(1137,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1137,18)-(1137,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1137,19)-(1137,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxLexer");
            #line hidden
            #line (1137,32)-(1137,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1137,33)-(1137,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("CreateLexer(__SourceText");
            #line hidden
            #line (1137,57)-(1137,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1137,58)-(1137,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1137,63)-(1137,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1137,64)-(1137,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__ParseOptions?");
            #line hidden
            #line (1137,79)-(1137,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1137,80)-(1137,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("options)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1138,3)-(1138,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1139,4)-(1139,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1139,10)-(1139,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1139,11)-(1139,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (1139,14)-(1139,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1139,16)-(1139,20) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1139,21)-(1139,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxLexer(text,");
            #line hidden
            #line (1139,38)-(1139,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1139,39)-(1139,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (1139,41)-(1139,45) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1139,46)-(1139,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("ParseOptions)(options");
            #line hidden
            #line (1139,67)-(1139,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1139,68)-(1139,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("??");
            #line hidden
            #line (1139,70)-(1139,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1139,72)-(1139,76) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1139,77)-(1139,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("ParseOptions.Default));");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1140,3)-(1140,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1142,3)-(1142,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1142,9)-(1142,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1142,10)-(1142,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1142,18)-(1142,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1142,19)-(1142,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxParser");
            #line hidden
            #line (1142,33)-(1142,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1142,34)-(1142,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("CreateParser(__SyntaxLexer");
            #line hidden
            #line (1142,60)-(1142,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1142,61)-(1142,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("lexer,");
            #line hidden
            #line (1142,67)-(1142,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1142,68)-(1142,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__IncrementalParseData?");
            #line hidden
            #line (1142,91)-(1142,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1142,92)-(1142,105) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("oldParseData,");
            #line hidden
            #line (1142,105)-(1142,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1142,106)-(1142,172) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.Collections.Generic.IEnumerable<__TextChangeRange>?");
            #line hidden
            #line (1142,172)-(1142,173) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1142,173)-(1142,181) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("changes,");
            #line hidden
            #line (1142,181)-(1142,182) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1142,182)-(1142,201) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (1142,201)-(1142,202) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1142,202)-(1142,219) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("cancellationToken");
            #line hidden
            #line (1142,219)-(1142,220) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1142,220)-(1142,221) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1142,221)-(1142,222) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1142,222)-(1142,230) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("default)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1143,9)-(1143,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1144,4)-(1144,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1144,10)-(1144,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1144,11)-(1144,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (1144,14)-(1144,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1144,16)-(1144,20) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1144,21)-(1144,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxParser((");
            #line hidden
            #line (1144,36)-(1144,40) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1144,41)-(1144,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxLexer)lexer,");
            #line hidden
            #line (1144,59)-(1144,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1144,60)-(1144,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("oldParseData,");
            #line hidden
            #line (1144,73)-(1144,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1144,74)-(1144,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("changes,");
            #line hidden
            #line (1144,82)-(1144,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1144,83)-(1144,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("cancellationToken);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1145,3)-(1145,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1147,3)-(1147,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1147,9)-(1147,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1147,10)-(1147,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxTrivia");
            #line hidden
            #line (1147,32)-(1147,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1147,33)-(1147,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Trivia(");
            #line hidden
            #line (1147,41)-(1147,45) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1147,46)-(1147,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (1147,56)-(1147,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1147,57)-(1147,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1147,62)-(1147,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1147,63)-(1147,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1147,69)-(1147,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1147,70)-(1147,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1147,75)-(1147,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1147,76)-(1147,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (1147,80)-(1147,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1147,81)-(1147,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("elastic");
            #line hidden
            #line (1147,88)-(1147,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1147,89)-(1147,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1147,90)-(1147,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1147,91)-(1147,97) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("false)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1148,9)-(1148,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1149,4)-(1149,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (1149,7)-(1149,8) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1149,8)-(1149,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia");
            #line hidden
            #line (1149,14)-(1149,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1149,15)-(1149,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1149,16)-(1149,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1149,17)-(1149,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxTrivia.Create(kind,");
            #line hidden
            #line (1149,47)-(1149,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1149,48)-(1149,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1150,4)-(1150,6) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (1150,6)-(1150,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1150,7)-(1150,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(!elastic)");
            #line hidden
            #line (1150,17)-(1150,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1150,18)-(1150,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1150,24)-(1150,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1150,25)-(1150,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trivia;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1151,4)-(1151,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1151,10)-(1151,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1151,11)-(1151,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.GreenNodeExtensions.WithAnnotationsGreen(trivia,");
            #line hidden
            #line (1151,89)-(1151,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1151,90)-(1151,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (1151,94)-(1151,98) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (1151,99)-(1151,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1151,100)-(1151,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (1151,101)-(1151,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1151,102)-(1151,138) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__SyntaxAnnotation.ElasticAnnotation");
            #line hidden
            #line (1151,138)-(1151,139) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1151,139)-(1151,142) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("});");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1152,3)-(1152,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1154,3)-(1154,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (1154,12)-(1154,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1154,13)-(1154,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1154,21)-(1154,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1154,22)-(1154,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxTrivia");
            #line hidden
            #line (1154,44)-(1154,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1154,45)-(1154,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Trivia(int");
            #line hidden
            #line (1154,55)-(1154,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1154,56)-(1154,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1154,61)-(1154,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1154,62)-(1154,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1154,68)-(1154,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1154,69)-(1154,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1154,74)-(1154,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1154,75)-(1154,79) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (1154,79)-(1154,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1154,80)-(1154,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("elastic");
            #line hidden
            #line (1154,87)-(1154,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1154,88)-(1154,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1154,89)-(1154,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1154,90)-(1154,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("false)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1155,6)-(1155,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1156,10)-(1156,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1156,16)-(1156,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1156,17)-(1156,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Trivia((");
            #line hidden
            #line (1156,26)-(1156,30) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1156,31)-(1156,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)kind,");
            #line hidden
            #line (1156,47)-(1156,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1156,48)-(1156,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1156,53)-(1156,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1156,54)-(1156,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("elastic);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1157,6)-(1157,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1159,3)-(1159,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1159,9)-(1159,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1159,10)-(1159,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1159,18)-(1159,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1159,19)-(1159,39) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxNode");
            #line hidden
            #line (1159,39)-(1159,40) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1159,40)-(1159,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SkippedTokensTrivia(__GreenNode");
            #line hidden
            #line (1159,71)-(1159,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1159,72)-(1159,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("token)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1160,3)-(1160,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1161,4)-(1161,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1161,10)-(1161,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1161,11)-(1161,14) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (1161,14)-(1161,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1161,15)-(1161,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSkippedTokensTriviaSyntax((");
            #line hidden
            #line (1161,48)-(1161,52) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1161,53)-(1161,105) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)__InternalSyntaxKind.SkippedTokensTrivia,");
            #line hidden
            #line (1161,105)-(1161,106) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1161,106)-(1161,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("token);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1162,3)-(1162,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1164,6)-(1164,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1164,12)-(1164,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1164,13)-(1164,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1164,34)-(1164,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1164,35)-(1164,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(");
            #line hidden
            #line (1164,42)-(1164,46) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1164,47)-(1164,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (1164,57)-(1164,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1164,58)-(1164,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1165,6)-(1165,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1166,10)-(1166,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1166,16)-(1166,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1166,17)-(1166,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.Create(kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1167,6)-(1167,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1169,9)-(1169,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (1169,18)-(1169,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1169,19)-(1169,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1169,27)-(1169,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1169,28)-(1169,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1169,49)-(1169,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1169,50)-(1169,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(int");
            #line hidden
            #line (1169,59)-(1169,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1169,60)-(1169,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1170,9)-(1170,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1171,4)-(1171,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1171,10)-(1171,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1171,11)-(1171,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token((");
            #line hidden
            #line (1171,19)-(1171,23) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1171,24)-(1171,41) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1172,9)-(1172,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1174,9)-(1174,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1174,15)-(1174,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1174,16)-(1174,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1174,37)-(1174,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1174,38)-(1174,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(__GreenNode?");
            #line hidden
            #line (1174,56)-(1174,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1174,57)-(1174,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1174,65)-(1174,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1174,67)-(1174,71) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1174,72)-(1174,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (1174,82)-(1174,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1174,83)-(1174,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1174,88)-(1174,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1174,89)-(1174,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (1174,101)-(1174,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1174,102)-(1174,111) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1175,6)-(1175,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1176,10)-(1176,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1176,16)-(1176,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1176,17)-(1176,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.Create(kind,");
            #line hidden
            #line (1176,46)-(1176,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1176,47)-(1176,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1176,55)-(1176,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1176,56)-(1176,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1177,6)-(1177,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1179,9)-(1179,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (1179,18)-(1179,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1179,19)-(1179,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1179,27)-(1179,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1179,28)-(1179,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1179,49)-(1179,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1179,50)-(1179,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(__GreenNode?");
            #line hidden
            #line (1179,68)-(1179,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1179,69)-(1179,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1179,77)-(1179,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1179,78)-(1179,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (1179,81)-(1179,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1179,82)-(1179,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1179,87)-(1179,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1179,88)-(1179,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (1179,100)-(1179,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1179,101)-(1179,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1180,9)-(1180,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1181,4)-(1181,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1181,10)-(1181,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1181,11)-(1181,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(leading,");
            #line hidden
            #line (1181,25)-(1181,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1181,26)-(1181,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (1181,28)-(1181,32) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1181,33)-(1181,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)kind,");
            #line hidden
            #line (1181,49)-(1181,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1181,50)-(1181,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1182,9)-(1182,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1184,9)-(1184,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1184,15)-(1184,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1184,16)-(1184,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1184,37)-(1184,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1184,38)-(1184,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(__GreenNode?");
            #line hidden
            #line (1184,56)-(1184,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1184,57)-(1184,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1184,65)-(1184,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1184,67)-(1184,71) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1184,72)-(1184,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (1184,82)-(1184,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1184,83)-(1184,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1184,88)-(1184,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1184,89)-(1184,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1184,95)-(1184,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1184,96)-(1184,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1184,101)-(1184,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1184,102)-(1184,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (1184,114)-(1184,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1184,115)-(1184,124) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1185,6)-(1185,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1186,10)-(1186,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Debug.Assert(");
            #line hidden
            #line (1186,26)-(1186,30) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1186,31)-(1186,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.SyntaxFacts.IsToken(kind));");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1187,10)-(1187,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1187,16)-(1187,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1187,17)-(1187,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("defaultText");
            #line hidden
            #line (1187,28)-(1187,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1187,29)-(1187,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1187,30)-(1187,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1187,32)-(1187,36) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1187,37)-(1187,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.SyntaxFacts.GetText(kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1188,10)-(1188,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1188,16)-(1188,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1188,17)-(1188,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind");
            #line hidden
            #line (1188,21)-(1188,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1188,22)-(1188,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(">=");
            #line hidden
            #line (1188,24)-(1188,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1188,25)-(1188,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.FirstTokenWithWellKnownText");
            #line hidden
            #line (1188,69)-(1188,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1188,70)-(1188,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (1188,72)-(1188,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1188,73)-(1188,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind");
            #line hidden
            #line (1188,77)-(1188,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1188,78)-(1188,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("<=");
            #line hidden
            #line (1188,80)-(1188,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1188,81)-(1188,124) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.LastTokenWithWellKnownText");
            #line hidden
            #line (1188,124)-(1188,125) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1188,125)-(1188,127) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (1188,127)-(1188,128) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1188,128)-(1188,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text");
            #line hidden
            #line (1188,132)-(1188,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1188,133)-(1188,135) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (1188,135)-(1188,136) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1188,136)-(1188,147) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("defaultText");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (1189,14)-(1189,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("?");
            #line hidden
            #line (1189,15)-(1189,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1189,16)-(1189,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(leading,");
            #line hidden
            #line (1189,30)-(1189,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1189,31)-(1189,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1189,36)-(1189,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1189,37)-(1189,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (1190,14)-(1190,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (1190,15)-(1190,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1190,16)-(1190,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.Identifier(kind,");
            #line hidden
            #line (1190,49)-(1190,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1190,50)-(1190,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1190,58)-(1190,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1190,59)-(1190,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1190,64)-(1190,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1190,65)-(1190,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1191,6)-(1191,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1193,9)-(1193,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (1193,18)-(1193,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1193,19)-(1193,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1193,27)-(1193,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1193,28)-(1193,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1193,49)-(1193,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1193,50)-(1193,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(__GreenNode?");
            #line hidden
            #line (1193,68)-(1193,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1193,69)-(1193,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1193,77)-(1193,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1193,78)-(1193,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (1193,81)-(1193,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1193,82)-(1193,87) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1193,87)-(1193,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1193,88)-(1193,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1193,94)-(1193,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1193,95)-(1193,100) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1193,100)-(1193,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1193,101)-(1193,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (1193,113)-(1193,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1193,114)-(1193,123) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1194,9)-(1194,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (1195,13)-(1195,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1195,19)-(1195,20) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1195,20)-(1195,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(leading,");
            #line hidden
            #line (1195,34)-(1195,35) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1195,35)-(1195,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (1195,37)-(1195,41) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1195,42)-(1195,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)kind,");
            #line hidden
            #line (1195,58)-(1195,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1195,59)-(1195,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1195,64)-(1195,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1195,65)-(1195,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1196,9)-(1196,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1198,9)-(1198,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1198,15)-(1198,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1198,16)-(1198,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1198,37)-(1198,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1198,38)-(1198,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(__GreenNode?");
            #line hidden
            #line (1198,56)-(1198,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1198,57)-(1198,65) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1198,65)-(1198,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1198,67)-(1198,71) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1198,72)-(1198,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (1198,82)-(1198,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1198,83)-(1198,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1198,88)-(1198,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1198,89)-(1198,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1198,95)-(1198,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1198,96)-(1198,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1198,101)-(1198,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1198,102)-(1198,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1198,108)-(1198,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1198,109)-(1198,119) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText,");
            #line hidden
            #line (1198,119)-(1198,120) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1198,120)-(1198,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (1198,132)-(1198,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1198,133)-(1198,142) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1199,6)-(1199,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1200,10)-(1200,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Debug.Assert(");
            #line hidden
            #line (1200,26)-(1200,30) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1200,31)-(1200,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.SyntaxFacts.IsToken(kind));");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1201,10)-(1201,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1201,16)-(1201,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1201,17)-(1201,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("defaultText");
            #line hidden
            #line (1201,28)-(1201,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1201,29)-(1201,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1201,30)-(1201,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1201,32)-(1201,36) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1201,37)-(1201,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.SyntaxFacts.GetText(kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1202,10)-(1202,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1202,16)-(1202,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,17)-(1202,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind");
            #line hidden
            #line (1202,21)-(1202,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,22)-(1202,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(">=");
            #line hidden
            #line (1202,24)-(1202,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,25)-(1202,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.FirstTokenWithWellKnownText");
            #line hidden
            #line (1202,69)-(1202,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,70)-(1202,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (1202,72)-(1202,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,73)-(1202,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind");
            #line hidden
            #line (1202,77)-(1202,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,78)-(1202,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("<=");
            #line hidden
            #line (1202,80)-(1202,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,81)-(1202,124) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.LastTokenWithWellKnownText");
            #line hidden
            #line (1202,124)-(1202,125) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,125)-(1202,127) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (1202,127)-(1202,128) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,128)-(1202,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text");
            #line hidden
            #line (1202,132)-(1202,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,133)-(1202,135) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (1202,135)-(1202,136) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,136)-(1202,147) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("defaultText");
            #line hidden
            #line (1202,147)-(1202,148) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,148)-(1202,150) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (1202,150)-(1202,151) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,151)-(1202,160) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText");
            #line hidden
            #line (1202,160)-(1202,161) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,161)-(1202,163) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (1202,163)-(1202,164) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1202,164)-(1202,175) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("defaultText");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (1203,14)-(1203,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("?");
            #line hidden
            #line (1203,15)-(1203,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1203,16)-(1203,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(leading,");
            #line hidden
            #line (1203,30)-(1203,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1203,31)-(1203,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1203,36)-(1203,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1203,37)-(1203,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (1204,14)-(1204,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (1204,15)-(1204,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1204,16)-(1204,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.WithValue(kind,");
            #line hidden
            #line (1204,48)-(1204,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1204,49)-(1204,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1204,57)-(1204,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1204,58)-(1204,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1204,63)-(1204,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1204,64)-(1204,74) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText,");
            #line hidden
            #line (1204,74)-(1204,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1204,75)-(1204,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1205,6)-(1205,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1207,3)-(1207,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (1207,12)-(1207,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1207,13)-(1207,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1207,21)-(1207,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1207,22)-(1207,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1207,43)-(1207,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1207,44)-(1207,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(__GreenNode?");
            #line hidden
            #line (1207,62)-(1207,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1207,63)-(1207,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1207,71)-(1207,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1207,72)-(1207,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (1207,75)-(1207,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1207,76)-(1207,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1207,81)-(1207,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1207,82)-(1207,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1207,88)-(1207,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1207,89)-(1207,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1207,94)-(1207,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1207,95)-(1207,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1207,101)-(1207,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1207,102)-(1207,112) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText,");
            #line hidden
            #line (1207,112)-(1207,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1207,113)-(1207,125) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (1207,125)-(1207,126) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1207,126)-(1207,135) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1208,3)-(1208,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1209,4)-(1209,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1209,10)-(1209,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1209,11)-(1209,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(leading,");
            #line hidden
            #line (1209,25)-(1209,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1209,26)-(1209,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (1209,28)-(1209,32) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1209,33)-(1209,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)kind,");
            #line hidden
            #line (1209,49)-(1209,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1209,50)-(1209,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1209,55)-(1209,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1209,56)-(1209,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("valueText,");
            #line hidden
            #line (1209,66)-(1209,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1209,67)-(1209,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1210,3)-(1210,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1212,3)-(1212,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1212,9)-(1212,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1212,10)-(1212,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1212,31)-(1212,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1212,32)-(1212,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(__GreenNode?");
            #line hidden
            #line (1212,50)-(1212,51) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1212,51)-(1212,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1212,59)-(1212,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1212,61)-(1212,65) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1212,66)-(1212,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (1212,76)-(1212,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1212,77)-(1212,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1212,82)-(1212,83) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1212,83)-(1212,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1212,89)-(1212,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1212,90)-(1212,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1212,95)-(1212,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1212,96)-(1212,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("object");
            #line hidden
            #line (1212,102)-(1212,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1212,103)-(1212,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value,");
            #line hidden
            #line (1212,109)-(1212,110) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1212,110)-(1212,122) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (1212,122)-(1212,123) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1212,123)-(1212,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1213,6)-(1213,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1214,10)-(1214,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__Debug.Assert(");
            #line hidden
            #line (1214,26)-(1214,30) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1214,31)-(1214,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.SyntaxFacts.IsToken(kind));");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1215,10)-(1215,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1215,16)-(1215,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1215,17)-(1215,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("defaultText");
            #line hidden
            #line (1215,28)-(1215,29) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1215,29)-(1215,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (1215,30)-(1215,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1215,32)-(1215,36) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1215,37)-(1215,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Language.Instance.SyntaxFacts.GetText(kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1216,10)-(1216,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1216,16)-(1216,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,17)-(1216,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind");
            #line hidden
            #line (1216,21)-(1216,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,22)-(1216,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(">=");
            #line hidden
            #line (1216,24)-(1216,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,25)-(1216,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.FirstTokenWithWellKnownText");
            #line hidden
            #line (1216,69)-(1216,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,70)-(1216,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (1216,72)-(1216,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,73)-(1216,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind");
            #line hidden
            #line (1216,77)-(1216,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,78)-(1216,80) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("<=");
            #line hidden
            #line (1216,80)-(1216,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,81)-(1216,124) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.LastTokenWithWellKnownText");
            #line hidden
            #line (1216,124)-(1216,125) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,125)-(1216,127) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (1216,127)-(1216,128) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,128)-(1216,132) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text");
            #line hidden
            #line (1216,132)-(1216,133) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,133)-(1216,135) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (1216,135)-(1216,136) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,136)-(1216,147) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("defaultText");
            #line hidden
            #line (1216,147)-(1216,148) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,148)-(1216,150) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (1216,150)-(1216,151) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1216,151)-(1216,176) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("defaultText.Equals(value)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (1217,14)-(1217,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("?");
            #line hidden
            #line (1217,15)-(1217,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1217,16)-(1217,30) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(leading,");
            #line hidden
            #line (1217,30)-(1217,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1217,31)-(1217,36) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1217,36)-(1217,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1217,37)-(1217,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t            ");
            #line (1218,14)-(1218,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (1218,15)-(1218,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1218,16)-(1218,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.WithValue(kind,");
            #line hidden
            #line (1218,48)-(1218,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1218,49)-(1218,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1218,57)-(1218,58) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1218,58)-(1218,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1218,63)-(1218,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1218,64)-(1218,70) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value,");
            #line hidden
            #line (1218,70)-(1218,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1218,71)-(1218,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1219,6)-(1219,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1221,3)-(1221,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (1221,12)-(1221,13) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1221,13)-(1221,21) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1221,21)-(1221,22) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1221,22)-(1221,43) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1221,43)-(1221,44) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1221,44)-(1221,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(__GreenNode?");
            #line hidden
            #line (1221,62)-(1221,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1221,63)-(1221,71) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1221,71)-(1221,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1221,72)-(1221,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (1221,75)-(1221,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1221,76)-(1221,81) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1221,81)-(1221,82) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1221,82)-(1221,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1221,88)-(1221,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1221,89)-(1221,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1221,94)-(1221,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1221,95)-(1221,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("object");
            #line hidden
            #line (1221,101)-(1221,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1221,102)-(1221,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value,");
            #line hidden
            #line (1221,108)-(1221,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1221,109)-(1221,121) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (1221,121)-(1221,122) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1221,122)-(1221,131) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1222,3)-(1222,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1223,4)-(1223,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1223,10)-(1223,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1223,11)-(1223,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("Token(leading,");
            #line hidden
            #line (1223,25)-(1223,26) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1223,26)-(1223,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (1223,28)-(1223,32) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1223,33)-(1223,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)kind,");
            #line hidden
            #line (1223,49)-(1223,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1223,50)-(1223,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1223,55)-(1223,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1223,56)-(1223,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("value,");
            #line hidden
            #line (1223,62)-(1223,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1223,63)-(1223,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1224,3)-(1224,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (1226,3)-(1226,9) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1226,9)-(1226,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1226,10)-(1226,31) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1226,31)-(1226,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1226,32)-(1226,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingToken(");
            #line hidden
            #line (1226,46)-(1226,50) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1226,51)-(1226,61) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (1226,61)-(1226,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1226,62)-(1226,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1227,6)-(1227,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1228,10)-(1228,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1228,16)-(1228,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1228,17)-(1228,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.CreateMissing(kind,");
            #line hidden
            #line (1228,53)-(1228,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1228,54)-(1228,59) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (1228,59)-(1228,60) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1228,60)-(1228,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("null);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1229,6)-(1229,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1231,9)-(1231,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (1231,18)-(1231,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1231,19)-(1231,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1231,27)-(1231,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1231,28)-(1231,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1231,49)-(1231,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1231,50)-(1231,66) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingToken(int");
            #line hidden
            #line (1231,66)-(1231,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1231,67)-(1231,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1232,9)-(1232,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1233,4)-(1233,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1233,10)-(1233,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1233,11)-(1233,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingToken((");
            #line hidden
            #line (1233,26)-(1233,30) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1233,31)-(1233,48) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1234,9)-(1234,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1236,9)-(1236,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1236,15)-(1236,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1236,16)-(1236,37) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1236,37)-(1236,38) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1236,38)-(1236,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingToken(__GreenNode?");
            #line hidden
            #line (1236,63)-(1236,64) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1236,64)-(1236,72) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1236,72)-(1236,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1236,74)-(1236,78) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1236,79)-(1236,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (1236,89)-(1236,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1236,90)-(1236,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1236,95)-(1236,96) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1236,96)-(1236,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (1236,108)-(1236,109) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1236,109)-(1236,118) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1237,6)-(1237,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1238,10)-(1238,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1238,16)-(1238,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1238,17)-(1238,53) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.CreateMissing(kind,");
            #line hidden
            #line (1238,53)-(1238,54) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1238,54)-(1238,62) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1238,62)-(1238,63) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1238,63)-(1238,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1239,6)-(1239,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1241,9)-(1241,18) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (1241,18)-(1241,19) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1241,19)-(1241,27) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1241,27)-(1241,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1241,28)-(1241,49) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1241,49)-(1241,50) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1241,50)-(1241,75) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingToken(__GreenNode?");
            #line hidden
            #line (1241,75)-(1241,76) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1241,76)-(1241,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1241,84)-(1241,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1241,85)-(1241,88) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("int");
            #line hidden
            #line (1241,88)-(1241,89) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1241,89)-(1241,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("kind,");
            #line hidden
            #line (1241,94)-(1241,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1241,95)-(1241,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (1241,107)-(1241,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1241,108)-(1241,117) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1242,9)-(1242,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (1243,4)-(1243,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1243,10)-(1243,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1243,11)-(1243,32) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("MissingToken(leading,");
            #line hidden
            #line (1243,32)-(1243,33) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1243,33)-(1243,34) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (1243,35)-(1243,39) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1243,40)-(1243,56) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)kind,");
            #line hidden
            #line (1243,56)-(1243,57) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1243,57)-(1243,67) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1244,9)-(1244,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1246,9)-(1246,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1246,15)-(1246,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1246,16)-(1246,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1246,24)-(1246,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1246,25)-(1246,46) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__InternalSyntaxToken");
            #line hidden
            #line (1246,46)-(1246,47) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1246,47)-(1246,68) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("BadToken(__GreenNode?");
            #line hidden
            #line (1246,68)-(1246,69) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1246,69)-(1246,77) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1246,77)-(1246,78) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1246,78)-(1246,84) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (1246,84)-(1246,85) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1246,85)-(1246,90) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1246,90)-(1246,91) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1246,91)-(1246,103) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("__GreenNode?");
            #line hidden
            #line (1246,103)-(1246,104) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1246,104)-(1246,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1247,6)-(1247,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1248,10)-(1248,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1248,16)-(1248,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1248,17)-(1248,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.WithValue((");
            #line hidden
            #line (1248,46)-(1248,50) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (1248,51)-(1248,92) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind)__InternalSyntaxKind.BadToken,");
            #line hidden
            #line (1248,92)-(1248,93) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1248,93)-(1248,101) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("leading,");
            #line hidden
            #line (1248,101)-(1248,102) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1248,102)-(1248,107) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1248,107)-(1248,108) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1248,108)-(1248,113) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (1248,113)-(1248,114) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1248,114)-(1248,124) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("trailing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1249,6)-(1249,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (1251,9)-(1251,15) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (1251,15)-(1251,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1251,16)-(1251,24) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (1251,24)-(1251,25) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1251,25)-(1251,94) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("global::System.Collections.Generic.IEnumerable<__InternalSyntaxToken>");
            #line hidden
            #line (1251,94)-(1251,95) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1251,95)-(1251,115) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GetWellKnownTokens()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1252,6)-(1252,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (1253,10)-(1253,16) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (1253,16)-(1253,17) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1253,17)-(1253,55) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("GreenSyntaxToken.GetWellKnownTokens();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (1254,6)-(1254,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first61 = true;
            #line (1256,4)-(1256,55) 13 "InternalSyntaxGenerator.mxg"
            foreach (var rule in Tokens.Where(t => !t.IsFixed))
            #line hidden
            
            {
                if (__first61)
                {
                    __first61 = false;
                }
                __cb.Push("\t\t");
                #line (1257,3)-(1257,9) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (1257,9)-(1257,10) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1257,10)-(1257,31) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("__InternalSyntaxToken");
                #line hidden
                #line (1257,31)-(1257,32) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1257,33)-(1257,48) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(rule.CSharpName);
                #line hidden
                #line (1257,49)-(1257,56) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("(string");
                #line hidden
                #line (1257,56)-(1257,57) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1257,57)-(1257,62) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("text)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t");
                #line (1258,3)-(1258,4) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (1259,4)-(1259,10) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (1259,10)-(1259,11) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1259,11)-(1259,22) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("Token(null,");
                #line hidden
                #line (1259,22)-(1259,23) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1259,24)-(1259,28) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (1259,29)-(1259,40) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (1259,41)-(1259,56) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(rule.CSharpName);
                #line hidden
                #line (1259,57)-(1259,58) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (1259,58)-(1259,59) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1259,59)-(1259,64) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("text,");
                #line hidden
                #line (1259,64)-(1259,65) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1259,65)-(1259,71) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("null);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t");
                #line (1260,3)-(1260,4) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t");
                #line (1262,3)-(1262,9) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (1262,9)-(1262,10) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1262,10)-(1262,31) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("__InternalSyntaxToken");
                #line hidden
                #line (1262,31)-(1262,32) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1262,33)-(1262,48) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(rule.CSharpName);
                #line hidden
                #line (1262,49)-(1262,56) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("(string");
                #line hidden
                #line (1262,56)-(1262,57) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1262,57)-(1262,62) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("text,");
                #line hidden
                #line (1262,62)-(1262,63) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1262,63)-(1262,69) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("object");
                #line hidden
                #line (1262,69)-(1262,70) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1262,70)-(1262,76) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("value)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t");
                #line (1263,3)-(1263,4) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (1264,4)-(1264,10) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (1264,10)-(1264,11) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1264,11)-(1264,22) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("Token(null,");
                #line hidden
                #line (1264,22)-(1264,23) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1264,24)-(1264,28) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (1264,29)-(1264,40) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (1264,41)-(1264,56) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(rule.CSharpName);
                #line hidden
                #line (1264,57)-(1264,58) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (1264,58)-(1264,59) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1264,59)-(1264,64) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("text,");
                #line hidden
                #line (1264,64)-(1264,65) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1264,65)-(1264,71) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("value,");
                #line hidden
                #line (1264,71)-(1264,72) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1264,72)-(1264,78) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("null);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t");
                #line (1265,3)-(1265,4) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first61) __cb.AppendLine();
            var __first62 = true;
            #line (1268,4)-(1268,31) 13 "InternalSyntaxGenerator.mxg"
            foreach (var rule in Rules)
            #line hidden
            
            {
                if (__first62)
                {
                    __first62 = false;
                }
                var __first63 = true;
                #line (1269,5)-(1269,43) 17 "InternalSyntaxGenerator.mxg"
                foreach (var alt in rule.Alternatives)
                #line hidden
                
                {
                    if (__first63)
                    {
                        __first63 = false;
                    }
                    __cb.Push("");
                    #line (1270,2)-(1270,42) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(GenerateInternalSyntaxFactoryCreate(alt));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first63) __cb.AppendLine();
            }
            if (!__first62) __cb.AppendLine();
            __cb.Push("\t");
            #line (1273,2)-(1273,3) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (1274,1)-(1274,2) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (1277,9)-(1277,62) 22 "InternalSyntaxGenerator.mxg"
        public string GenerateInternalSyntaxFactoryCreate(Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (1278,3)-(1278,11) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (1278,11)-(1278,12) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1278,13)-(1278,26) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (1278,27)-(1278,28) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1278,29)-(1278,43) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.CSharpName);
            #line hidden
            #line (1278,44)-(1278,45) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (1278,46)-(1278,71) 24 "InternalSyntaxGenerator.mxg"
            __cb.Write(alt.GreenUpdateParameters);
            #line hidden
            #line (1278,72)-(1278,73) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (1279,3)-(1279,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (1280,1)-(1280,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("#if");
            #line hidden
            #line (1280,4)-(1280,5) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (1280,5)-(1280,10) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("DEBUG");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first64 = true;
            #line (1281,5)-(1281,39) 13 "InternalSyntaxGenerator.mxg"
            foreach (var elem in alt.Elements)
            #line hidden
            
            {
                if (__first64)
                {
                    __first64 = false;
                }
                #line (1282,6)-(1282,66) 17 "InternalSyntaxGenerator.mxg"
                var greenSyntaxNullCondition = elem.GreenSyntaxNullCondition;
                #line hidden
                
                var __first65 = true;
                #line (1283,6)-(1283,47) 17 "InternalSyntaxGenerator.mxg"
                if (greenSyntaxNullCondition is not null)
                #line hidden
                
                {
                    if (__first65)
                    {
                        __first65 = false;
                    }
                    __cb.Push("\t\t\t");
                    #line (1284,4)-(1284,6) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (1284,6)-(1284,7) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1284,7)-(1284,8) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (1284,9)-(1284,33) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(greenSyntaxNullCondition);
                    #line hidden
                    #line (1284,34)-(1284,35) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (1284,35)-(1284,36) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1284,36)-(1284,41) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("throw");
                    #line hidden
                    #line (1284,41)-(1284,42) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1284,42)-(1284,45) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (1284,45)-(1284,46) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1284,46)-(1284,77) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("__ArgumentNullException(nameof(");
                    #line hidden
                    #line (1284,78)-(1284,96) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(elem.ParameterName);
                    #line hidden
                    #line (1284,97)-(1284,100) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("));");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first65) __cb.AppendLine();
                #line (1286,6)-(1286,58) 17 "InternalSyntaxGenerator.mxg"
                var greenSyntaxCondition = elem.GreenSyntaxCondition;
                #line hidden
                
                var __first66 = true;
                #line (1287,6)-(1287,43) 17 "InternalSyntaxGenerator.mxg"
                if (greenSyntaxCondition is not null)
                #line hidden
                
                {
                    if (__first66)
                    {
                        __first66 = false;
                    }
                    __cb.Push("\t\t\t");
                    #line (1288,4)-(1288,6) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (1288,6)-(1288,7) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1288,7)-(1288,8) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (1288,9)-(1288,29) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(greenSyntaxCondition);
                    #line hidden
                    #line (1288,30)-(1288,31) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (1288,31)-(1288,32) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1288,32)-(1288,37) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("throw");
                    #line hidden
                    #line (1288,37)-(1288,38) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1288,38)-(1288,41) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (1288,41)-(1288,42) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1288,42)-(1288,69) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("__ArgumentException(nameof(");
                    #line hidden
                    #line (1288,70)-(1288,88) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(elem.ParameterName);
                    #line hidden
                    #line (1288,89)-(1288,92) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write("));");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first66) __cb.AppendLine();
            }
            if (!__first64) __cb.AppendLine();
            __cb.Push("");
            #line (1291,1)-(1291,7) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("#endif");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first67 = true;
            #line (1292,5)-(1292,33) 13 "InternalSyntaxGenerator.mxg"
            if (alt.Elements.Count <= 3)
            #line hidden
            
            {
                if (__first67)
                {
                    __first67 = false;
                }
                __cb.Push("\t\t\t");
                #line (1293,4)-(1293,7) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("int");
                #line hidden
                #line (1293,7)-(1293,8) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1293,8)-(1293,13) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("hash;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (1294,4)-(1294,7) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (1294,7)-(1294,8) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1294,8)-(1294,14) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("cached");
                #line hidden
                #line (1294,14)-(1294,15) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1294,15)-(1294,16) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (1294,16)-(1294,17) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1294,17)-(1294,52) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("__SyntaxNodeCache.TryGetNode((int)(");
                #line hidden
                #line (1294,53)-(1294,57) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (1294,58)-(1294,69) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind)");
                #line hidden
                #line (1294,70)-(1294,74) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (1294,75)-(1294,86) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (1294,87)-(1294,101) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(alt.CSharpName);
                #line hidden
                var __first68 = true;
                #line (1294,103)-(1294,137) 17 "InternalSyntaxGenerator.mxg"
                foreach (var elem in alt.Elements)
                #line hidden
                
                {
                    if (__first68)
                    {
                        __first68 = false;
                    }
                    #line (1294,138)-(1294,139) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (1294,139)-(1294,140) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1294,141)-(1294,165) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(elem.GreenParameterValue);
                    #line hidden
                }
                #line (1294,179)-(1294,180) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (1294,180)-(1294,181) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1294,181)-(1294,184) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("out");
                #line hidden
                #line (1294,184)-(1294,185) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1294,185)-(1294,191) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("hash);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (1295,4)-(1295,6) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (1295,6)-(1295,7) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1295,7)-(1295,14) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("(cached");
                #line hidden
                #line (1295,14)-(1295,15) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1295,15)-(1295,17) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("!=");
                #line hidden
                #line (1295,17)-(1295,18) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1295,18)-(1295,23) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (1295,23)-(1295,24) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1295,24)-(1295,30) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (1295,30)-(1295,31) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1295,31)-(1295,32) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (1295,33)-(1295,46) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(alt.GreenName);
                #line hidden
                #line (1295,47)-(1295,55) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(")cached;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t");
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (1297,4)-(1297,7) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (1297,7)-(1297,8) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1297,8)-(1297,14) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("result");
                #line hidden
                #line (1297,14)-(1297,15) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1297,15)-(1297,16) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (1297,16)-(1297,17) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1297,17)-(1297,20) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (1297,20)-(1297,21) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1297,22)-(1297,35) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(alt.GreenName);
                #line hidden
                #line (1297,36)-(1297,37) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (1297,38)-(1297,42) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (1297,43)-(1297,54) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (1297,55)-(1297,69) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(alt.CSharpName);
                #line hidden
                var __first69 = true;
                #line (1297,71)-(1297,105) 17 "InternalSyntaxGenerator.mxg"
                foreach (var elem in alt.Elements)
                #line hidden
                
                {
                    if (__first69)
                    {
                        __first69 = false;
                    }
                    #line (1297,106)-(1297,107) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (1297,107)-(1297,108) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1297,109)-(1297,133) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(elem.GreenParameterValue);
                    #line hidden
                }
                #line (1297,147)-(1297,149) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (1298,4)-(1298,6) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (1298,6)-(1298,7) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1298,7)-(1298,12) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("(hash");
                #line hidden
                #line (1298,12)-(1298,13) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1298,13)-(1298,15) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(">=");
                #line hidden
                #line (1298,15)-(1298,16) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1298,16)-(1298,18) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("0)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (1299,4)-(1299,5) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t\t");
                #line (1300,5)-(1300,38) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("__SyntaxNodeCache.AddNode(result,");
                #line hidden
                #line (1300,38)-(1300,39) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1300,39)-(1300,45) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("hash);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (1301,4)-(1301,5) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t");
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("\t\t\t");
                #line (1303,4)-(1303,10) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (1303,10)-(1303,11) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1303,11)-(1303,18) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("result;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (1304,5)-(1304,9) 13 "InternalSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first67)
                {
                    __first67 = false;
                }
                __cb.Push("\t\t\t");
                #line (1305,4)-(1305,10) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (1305,10)-(1305,11) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1305,11)-(1305,14) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (1305,14)-(1305,15) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (1305,16)-(1305,29) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(alt.GreenName);
                #line hidden
                #line (1305,30)-(1305,31) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (1305,32)-(1305,36) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (1305,37)-(1305,48) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (1305,49)-(1305,63) 28 "InternalSyntaxGenerator.mxg"
                __cb.Write(alt.CSharpName);
                #line hidden
                var __first70 = true;
                #line (1305,65)-(1305,99) 17 "InternalSyntaxGenerator.mxg"
                foreach (var elem in alt.Elements)
                #line hidden
                
                {
                    if (__first70)
                    {
                        __first70 = false;
                    }
                    #line (1305,100)-(1305,101) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (1305,101)-(1305,102) 33 "InternalSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (1305,103)-(1305,127) 32 "InternalSyntaxGenerator.mxg"
                    __cb.Write(elem.GreenParameterValue);
                    #line hidden
                }
                #line (1305,141)-(1305,143) 29 "InternalSyntaxGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first67) __cb.AppendLine();
            __cb.Push("\t\t");
            #line (1307,3)-(1307,4) 25 "InternalSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}