
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Syntax;

var code = @"
namespace A.B.C;

using D.E;
using D;

language Sample;

[B(x = true, y = 'a'+/**/3)]
g: [Q] aa# [T] a+= [R] A*? eof
 | bb# b=B
 ;

[def A]
f: a;

a: A;

al: f [P] a [Q] (',' [R] a)* G;

fragment A: 'a';
B: 'b';

[C]
G: 'a'..'z';
";

var parser = new MetaCompilerParser("sample.mcomp", SourceText.From(code));
var language = parser.Parse();

Console.WriteLine(language.Namespace);
