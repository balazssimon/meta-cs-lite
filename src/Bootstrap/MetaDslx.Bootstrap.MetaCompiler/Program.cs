
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Syntax;

var code = @"
namespace A.B.C;

using D.E;
using D;

[B(x = true, y = 'a'+/**/3)]
g: aa# a=A 
 | bb# b=B
 ;

[def A]
f: a;

[C]
G: 'a'..'z';
";

var parser = new MetaCompilerParser("sample.mcomp", SourceText.From(code));
var language = parser.Parse();

Console.WriteLine(language.Namespace);
