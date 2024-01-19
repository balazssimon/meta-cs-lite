﻿using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaGenerator.Syntax;

var filePath = @"..\..\..\GenTest1.mgen";
var mgenCompiler = new MetaGeneratorParser(filePath, SourceText.From(File.ReadAllText(filePath)));
var csharpCode = mgenCompiler.Compile();
if (mgenCompiler.Diagnostics.Length > 0)
{
    foreach (var diag in mgenCompiler.Diagnostics)
    {
        Console.WriteLine(diag);
    }
}
else
{
    File.WriteAllText(filePath + ".g", csharpCode);
}
